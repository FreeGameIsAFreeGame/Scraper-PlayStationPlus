using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FreeGameIsAFreeGame.Scraper.PlayStationPlus
{
    using J = JsonPropertyAttribute;
    using N = NullValueHandling;

    public partial class PlayStationPlusFreeGamesData
    {
        [J("data")] public Data Data { get; set; }
        [J("included")] public List<Included> Included { get; set; }
    }

    public partial class Data
    {
        [J("attributes")] public DataAttributes Attributes { get; set; }
        [J("id")] public string Id { get; set; }
        [J("relationships")] public Relationships Relationships { get; set; }
        [J("type")] public string Type { get; set; }
    }

    public partial class DataAttributes
    {
        [J("banners")] public List<object> Banners { get; set; }
        [J("facets")] public List<Facet> Facets { get; set; }
        [J("name")] public string Name { get; set; }
        [J("nsx-ps-plus-upsell")] public object NsxPsPlusUpsell { get; set; }
        [J("promo-backgrounds")] public List<object> PromoBackgrounds { get; set; }
        [J("sub-scenes")] public SubScenes SubScenes { get; set; }
        [J("template-id")] public long TemplateId { get; set; }
        [J("thumbnail-url-base")] public Uri ThumbnailUrlBase { get; set; }
        [J("total-results")] public long TotalResults { get; set; }
    }

    public partial class Facet
    {
        [J("name")] public string Name { get; set; }
        [J("values")] public List<Value> Values { get; set; }
    }

    public partial class Value
    {
        [J("count")] public long Count { get; set; }
        [J("key")] public string Key { get; set; }
        [J("name")] public string Name { get; set; }
    }

    public partial class SubScenes
    {
    }

    public partial class Relationships
    {
        [J("children")] public Children Children { get; set; }
        [J("legacy-skus")] public Children LegacySkus { get; set; }
    }

    public partial class Children
    {
        [J("data")] public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {
        [J("id")] public string Id { get; set; }
        [J("type")] public string Type { get; set; }
    }

    public partial class Included
    {
        [J("attributes")] public IncludedAttributes Attributes { get; set; }
        [J("id")] public string Id { get; set; }
        [J("relationships")] public Relationships Relationships { get; set; }
        [J("type")] public string Type { get; set; }
    }

    public partial class IncludedAttributes
    {
        [J("amortizeFlag", NullValueHandling = N.Ignore)]
        public bool? AmortizeFlag { get; set; }

        [J("bundleExclusiveFlag", NullValueHandling = N.Ignore)]
        public bool? BundleExclusiveFlag { get; set; }

        [J("chargeImmediatelyFlag", NullValueHandling = N.Ignore)]
        public bool? ChargeImmediatelyFlag { get; set; }

        [J("charge_type_id", NullValueHandling = N.Ignore)]
        public long? ChargeTypeId { get; set; }

        [J("credit_card_required_flag", NullValueHandling = N.Ignore)]
        public long? CreditCardRequiredFlag { get; set; }

        [J("defaultSku", NullValueHandling = N.Ignore)]
        public bool? DefaultSku { get; set; }

        [J("display_price", NullValueHandling = N.Ignore)]
        public string DisplayPrice { get; set; }

        [J("eligibilities", NullValueHandling = N.Ignore)]
        public List<object> Eligibilities { get; set; }

        [J("entitlements", NullValueHandling = N.Ignore)]
        public List<AttributesEntitlement> Entitlements { get; set; }

        [J("id", NullValueHandling = N.Ignore)]
        public string Id { get; set; }

        [J("is_original", NullValueHandling = N.Ignore)]
        public bool? IsOriginal { get; set; }

        [J("name")] public string Name { get; set; }
        [J("platforms")] public List<Platform> Platforms { get; set; }

        [J("price", NullValueHandling = N.Ignore)]
        public long? Price { get; set; }

        [J("rewards", NullValueHandling = N.Ignore)]
        public List<Reward> Rewards { get; set; }

        [J("seasonPassExclusiveFlag", NullValueHandling = N.Ignore)]
        public bool? SeasonPassExclusiveFlag { get; set; }

        [J("skuAvailabilityOverrideFlag", NullValueHandling = N.Ignore)]
        public bool? SkuAvailabilityOverrideFlag { get; set; }

        [J("sku_type", NullValueHandling = N.Ignore)]
        public long? SkuType { get; set; }

        [J("type", NullValueHandling = N.Ignore)]
        public string Type { get; set; }

        [J("badge-info", NullValueHandling = N.Ignore)]
        public BadgeInfo BadgeInfo { get; set; }

        [J("cero-z-status", NullValueHandling = N.Ignore)]
        public CeroZStatus CeroZStatus { get; set; }

        [J("content-rating", NullValueHandling = N.Ignore)]
        public ContentRating ContentRating { get; set; }

        [J("content-type", NullValueHandling = N.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ContentType { get; set; }

        [J("default-sku-id", NullValueHandling = N.Ignore)]
        public string DefaultSkuId { get; set; }

        [J("dob-required", NullValueHandling = N.Ignore)]
        public bool? DobRequired { get; set; }

        [J("file-size", NullValueHandling = N.Ignore)]
        public FileSize FileSize { get; set; }

        [J("game-content-type", NullValueHandling = N.Ignore)]
        public string GameContentType { get; set; }

        [J("genres", NullValueHandling = N.Ignore)]
        public List<string> Genres { get; set; }

        [J("has-igc", NullValueHandling = N.Ignore)]
        public bool? HasIgc { get; set; }

        [J("is-igc-upsell", NullValueHandling = N.Ignore)]
        public bool? IsIgcUpsell { get; set; }

        [J("is-multiplayer-upsell", NullValueHandling = N.Ignore)]
        public bool? IsMultiplayerUpsell { get; set; }

        [J("kamaji-relationship", NullValueHandling = N.Ignore)]
        public string KamajiRelationship { get; set; }

        [J("legal-text", NullValueHandling = N.Ignore)]
        public string LegalText { get; set; }

        [J("long-description", NullValueHandling = N.Ignore)]
        public string LongDescription { get; set; }

        [J("macross-brain-context", NullValueHandling = N.Ignore)]
        public string MacrossBrainContext { get; set; }

        [J("media-list", NullValueHandling = N.Ignore)]
        public MediaList MediaList { get; set; }

        [J("nsx-confirm-message", NullValueHandling = N.Ignore)]
        public string NsxConfirmMessage { get; set; }

        [J("parent")] public object Parent { get; set; }

        [J("plus-reward-description", NullValueHandling = N.Ignore)]
        public string PlusRewardDescription { get; set; }

        [J("primary-classification", NullValueHandling = N.Ignore)]
        public string PrimaryClassification { get; set; }

        [J("provider-name", NullValueHandling = N.Ignore)]
        public string ProviderName { get; set; }

        [J("ps-camera-compatibility", NullValueHandling = N.Ignore)]
        public string PsCameraCompatibility { get; set; }

        [J("ps-move-compatibility", NullValueHandling = N.Ignore)]
        public string PsMoveCompatibility { get; set; }

        [J("ps-vr-compatibility", NullValueHandling = N.Ignore)]
        public string PsVrCompatibility { get; set; }

        [J("release-date", NullValueHandling = N.Ignore)]
        public DateTimeOffset? ReleaseDate { get; set; }

        [J("secondary-classification", NullValueHandling = N.Ignore)]
        public string SecondaryClassification { get; set; }

        [J("skus", NullValueHandling = N.Ignore)]
        public List<Skus> Skus { get; set; }

        [J("star-rating", NullValueHandling = N.Ignore)]
        public StarRating StarRating { get; set; }

        [J("subtitle-language-codes", NullValueHandling = N.Ignore)]
        public List<object> SubtitleLanguageCodes { get; set; }

        [J("tertiary-classification", NullValueHandling = N.Ignore)]
        public string TertiaryClassification { get; set; }

        [J("thumbnail-url-base", NullValueHandling = N.Ignore)]
        public string ThumbnailUrlBase { get; set; }

        [J("top-category", NullValueHandling = N.Ignore)]
        public string TopCategory { get; set; }

        [J("upsell-info", NullValueHandling = N.Ignore)]
        public UpsellInfo UpsellInfo { get; set; }

        [J("voice-language-codes", NullValueHandling = N.Ignore)]
        public List<object> VoiceLanguageCodes { get; set; }
    }

    public partial class BadgeInfo
    {
        [J("non-plus-user")] public BadgeInfoNonPlusUser NonPlusUser { get; set; }
        [J("plus-user")] public BadgeInfoNonPlusUser PlusUser { get; set; }
    }

    public partial class BadgeInfoNonPlusUser
    {
        [J("discount-percentage")] public long DiscountPercentage { get; set; }
        [J("is-plus")] public bool IsPlus { get; set; }
        [J("type")] public string Type { get; set; }
    }

    public partial class CeroZStatus
    {
        [J("is-allowed-in-cart")] public bool IsAllowedInCart { get; set; }
        [J("is-on")] public bool IsOn { get; set; }
    }

    public partial class ContentRating
    {
        [J("content-descriptors")] public List<ContentDescriptor> ContentDescriptors { get; set; }
        [J("contentInteractiveElement")] public List<object> ContentInteractiveElement { get; set; }
        [J("rating-system")] public string RatingSystem { get; set; }
        [J("url")] public Uri Url { get; set; }
    }

    public partial class ContentDescriptor
    {
        [J("description")] public string Description { get; set; }
        [J("name")] public string Name { get; set; }
        [J("url")] public object Url { get; set; }
    }

    public partial class AttributesEntitlement
    {
        [J("description")] public object Description { get; set; }
        [J("drms")] public List<object> Drms { get; set; }
        [J("duration")] public long Duration { get; set; }
        [J("durationOverrideTypeId")] public object DurationOverrideTypeId { get; set; }
        [J("exp_after_first_use")] public long ExpAfterFirstUse { get; set; }
        [J("feature_type_id")] public long FeatureTypeId { get; set; }
        [J("id")] public string Id { get; set; }
        [J("license_type")] public long LicenseType { get; set; }
        [J("metadata")] public object Metadata { get; set; }
        [J("name")] public string Name { get; set; }
        [J("packageType")] public string PackageType { get; set; }
        [J("packages")] public List<Package> Packages { get; set; }
        [J("preorder_placeholder_flag")] public bool PreorderPlaceholderFlag { get; set; }
        [J("size")] public long Size { get; set; }
        [J("subType")] public long SubType { get; set; }
        [J("subtitle_language_codes")] public object SubtitleLanguageCodes { get; set; }
        [J("type")] public long Type { get; set; }
        [J("use_count")] public long UseCount { get; set; }
        [J("voice_language_codes")] public object VoiceLanguageCodes { get; set; }
    }

    public partial class Package
    {
        [J("platformId")] public long PlatformId { get; set; }
        [J("platformName")] public string PlatformName { get; set; }
        [J("size")] public long Size { get; set; }
    }

    public partial class FileSize
    {
        [J("unit")] public string Unit { get; set; }
        [J("value")] public double Value { get; set; }
    }

    public partial class MediaList
    {
        [J("preview")] public List<Preview> Preview { get; set; }
        [J("promo")] public Promo Promo { get; set; }
        [J("screenshots")] public List<Preview> Screenshots { get; set; }
    }

    public partial class Preview
    {
        [J("url")] public Uri Url { get; set; }
    }

    public partial class Promo
    {
        [J("images")] public List<object> Images { get; set; }
        [J("videos")] public List<object> Videos { get; set; }
    }

    public partial class Reward
    {
        [J("description")] public string Description { get; set; }
        [J("discount")] public long Discount { get; set; }
        [J("display_price")] public string DisplayPrice { get; set; }
        [J("end_date")] public DateTimeOffset EndDate { get; set; }
        [J("entitlement_id")] public string EntitlementId { get; set; }
        [J("id")] public string Id { get; set; }
        [J("isPlus")] public bool IsPlus { get; set; }
        [J("name")] public string Name { get; set; }
        [J("price")] public long Price { get; set; }
        [J("rewardSourceId")] public long RewardSourceId { get; set; }
        [J("reward_source_type_id")] public long RewardSourceTypeId { get; set; }
        [J("reward_type")] public long RewardType { get; set; }
        [J("service_provider_id")] public string ServiceProviderId { get; set; }
        [J("start_date")] public DateTimeOffset StartDate { get; set; }
    }

    public partial class Skus
    {
        [J("entitlements")] public List<SkusEntitlement> Entitlements { get; set; }
        [J("id")] public string Id { get; set; }
        [J("is-preorder")] public bool IsPreorder { get; set; }
        [J("multibuy")] public object Multibuy { get; set; }
        [J("name")] public string Name { get; set; }
        [J("playability-date")] public string PlayabilityDate { get; set; }
        [J("plus-reward-description")] public string PlusRewardDescription { get; set; }
        [J("prices")] public Prices Prices { get; set; }
    }

    public partial class SkusEntitlement
    {
        [J("duration")] public long Duration { get; set; }
        [J("exp-after-first-use")] public long ExpAfterFirstUse { get; set; }
    }

    public partial class Prices
    {
        [J("non-plus-user")] public PricesNonPlusUser NonPlusUser { get; set; }
        [J("plus-user")] public PricesNonPlusUser PlusUser { get; set; }
    }

    public partial class PricesNonPlusUser
    {
        [J("actual-price")] public Price ActualPrice { get; set; }
        [J("availability")] public Availability Availability { get; set; }
        [J("discount-percentage")] public long DiscountPercentage { get; set; }
        [J("is-plus")] public bool IsPlus { get; set; }
        [J("strikethrough-price")] public Price StrikethroughPrice { get; set; }
        [J("upsell-price")] public Price UpsellPrice { get; set; }
    }

    public partial class Price
    {
        [J("display")] public string Display { get; set; }
        [J("value")] public long Value { get; set; }
    }

    public partial class Availability
    {
        [J("end-date")] public DateTimeOffset? EndDate { get; set; }
        [J("start-date")] public DateTimeOffset? StartDate { get; set; }
    }

    public partial class StarRating
    {
        [J("score")] public double? Score { get; set; }
        [J("total")] public long? Total { get; set; }
    }

    public partial class UpsellInfo
    {
        [J("discount-percentage-difference")] public long DiscountPercentageDifference { get; set; }
        [J("display-price")] public string DisplayPrice { get; set; }
        [J("is-free")] public bool IsFree { get; set; }
        [J("type")] public string Type { get; set; }
    }

    public partial struct Platform
    {
        public long? Integer;
        public string String;

        public static implicit operator Platform(long Integer) => new Platform {Integer = Integer};
        public static implicit operator Platform(string String) => new Platform {String = String};
    }

    public partial class PlayStationPlusFreeGamesData
    {
        public static PlayStationPlusFreeGamesData FromJson(string json) =>
            JsonConvert.DeserializeObject<PlayStationPlusFreeGamesData>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PlayStationPlusFreeGamesData self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PlatformConverter.Singleton,
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            string value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }

            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            long value = (long) untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class PlatformConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Platform) || t == typeof(Platform?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    long integerValue = serializer.Deserialize<long>(reader);
                    return new Platform {Integer = integerValue};
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);
                    return new Platform {String = stringValue};
            }

            throw new Exception("Cannot unmarshal type Platform");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            Platform value = (Platform) untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }

            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }

            throw new Exception("Cannot marshal type Platform");
        }

        public static readonly PlatformConverter Singleton = new PlatformConverter();
    }
}
