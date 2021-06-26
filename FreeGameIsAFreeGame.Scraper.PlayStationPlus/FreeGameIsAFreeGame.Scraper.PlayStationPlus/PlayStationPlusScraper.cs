using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Io;
using FreeGameIsAFreeGame.Core;
using FreeGameIsAFreeGame.Core.Models;
using NLog;

namespace FreeGameIsAFreeGame.Scraper.PlayStationPlus
{
    public class PlayStationPlusScraper : IScraper
    {
        private const string URL =
            "https://store.playstation.com/valkyrie-api/en/US/999/container/STORE-MSF77008-PSPLUSFREEGAMES?size=30&bucket=games&start=0";

        private IBrowsingContext context;
        private ILogger logger;

        string IScraper.Identifier => "PlayStationPlusFree";

        /// <inheritdoc />
        public Task Initialize(CancellationToken token)
        {
            context = BrowsingContext.New(Configuration.Default
                .WithDefaultLoader()
                .WithDefaultCookies());

            logger = LogManager.GetLogger(GetType().FullName);

            return Task.CompletedTask;
        }

        async Task<IEnumerable<IDeal>> IScraper.Scrape(CancellationToken token)
        {
            List<IDeal> deals = new List<IDeal>();

            try
            {
                string content = await GetContent(URL, token);
                if (token.IsCancellationRequested)
                    return null;

                PlayStationPlusFreeGamesData freeGamesData = PlayStationPlusFreeGamesData.FromJson(content);
                List<IDeal> parsedData = ParseFreeGamesData(freeGamesData);

                deals.AddRange(parsedData);
            }
            catch (Exception e)
            {
                logger.Warn(e.Message);
            }

            return deals;
        }

        private async Task<string> GetContent(string uri, CancellationToken token)
        {
            Url url = Url.Create(uri);
            DocumentRequest request = DocumentRequest.Get(url);
            IDocument document = await context.OpenAsync(request, token);
            if (token.IsCancellationRequested)
                return string.Empty;
            string content = document.Body.Text();
            return content;
        }

        private List<IDeal> ParseFreeGamesData(PlayStationPlusFreeGamesData data)
        {
            List<IDeal> freeGames = new List<IDeal>();

            foreach (Included included in data.Included)
            {
                if (included.Type.ToLower() != "game")
                    continue;

                PricesNonPlusUser plusUserSku = included.Attributes.Skus.First().Prices.PlusUser;
                if (plusUserSku.ActualPrice.Value != 0)
                    continue;

                Availability availability = plusUserSku.Availability;
                Deal freeGame = new Deal
                {
                    Discount = 100,
                    Image = included.Attributes.ThumbnailUrlBase,
                    Link = $"https://store.playstation.com/en-us/product/{included.Attributes.DefaultSkuId}",
                    Title = included.Attributes.Name,
                    End = GetUtcDateTime(availability.EndDate),
                    Start = GetUtcDateTime(availability.StartDate)
                };
                freeGames.Add(freeGame);
            }

            return freeGames;
        }

        private DateTime? GetUtcDateTime(DateTimeOffset? dto)
        {
            return dto?.UtcDateTime ?? default;
        }

        /// <inheritdoc />
        public Task Dispose()
        {
            context?.Dispose();
            return Task.CompletedTask;
        }
    }
}
