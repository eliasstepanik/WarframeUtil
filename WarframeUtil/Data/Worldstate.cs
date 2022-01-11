using Newtonsoft.Json;

namespace WarframeUtil.Data;

public class Id
{
    [JsonProperty("$oid")] public string Oid { get; set; }
}

public class Message
{
    public string LanguageCode { get; set; }
    [JsonProperty("Message")] public string message { get; set; }
}

public class Date2
{
    [JsonProperty("$numberLong")] public string NumberLong { get; set; }
}

public class Date
{
    [JsonProperty("$date")] public Date date { get; set; }
}

public class Event
{
    public Id _id { get; set; }
    public List<Message> Messages { get; set; }
    public string Prop { get; set; }
    public Date Date { get; set; }
    public string ImageUrl { get; set; }
    public bool Priority { get; set; }
    public bool MobileOnly { get; set; }
    public bool Community { get; set; }
}

public class Activation
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class Expiry
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class UpgradeId
{
    [JsonProperty("$oid")] public string Oid { get; set; }
}

public class Reward
{
    public int credits { get; set; }
    public int xp { get; set; }
    public List<string> items { get; set; }
    public List<object> countedItems { get; set; }
}

public class InterimReward
{
    public int credits { get; set; }
    public int xp { get; set; }
    public List<string> items { get; set; }
    public List<object> countedItems { get; set; }
}

public class Goal
{
    public Id _id { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Node { get; set; }
    public string ScoreVar { get; set; }
    public string ScoreLocTag { get; set; }
    public int Count { get; set; }
    public double HealthPct { get; set; }
    public List<int> Regions { get; set; }
    public string Desc { get; set; }
    public string ToolTip { get; set; }
    public bool OptionalInMission { get; set; }
    public string Tag { get; set; }
    public List<UpgradeId> UpgradeIds { get; set; }
    public bool Personal { get; set; }
    public bool Community { get; set; }
    [JsonProperty("Goal")] public int goal { get; set; }
    public Reward Reward { get; set; }
    public List<int> InterimGoals { get; set; }
    public List<InterimReward> InterimRewards { get; set; }
    public int? Success { get; set; }
    public string Faction { get; set; }
    public string Icon { get; set; }
}

public class Variant
{
    public string missionType { get; set; }
    public string modifierType { get; set; }
    public string node { get; set; }
    public string tileset { get; set; }
}

public class Sorty
{
    public Id _id { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Boss { get; set; }
    public string Reward { get; set; }
    public List<object> ExtraDrops { get; set; }
    public int Seed { get; set; }
    public List<Variant> Variants { get; set; }
    public bool Twitter { get; set; }
}

public class Job
{
    public string jobType { get; set; }
    public string rewards { get; set; }
    public int masteryReq { get; set; }
    public int minEnemyLevel { get; set; }
    public int maxEnemyLevel { get; set; }
    public List<int> xpAmounts { get; set; }
    public bool? endless { get; set; }
    public double? bonusXpMultiplier { get; set; }
    public string locationTag { get; set; }
    public bool? isVault { get; set; }
}

public class SyndicateMission
{
    public Id _id { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Tag { get; set; }
    public int Seed { get; set; }
    public List<string> Nodes { get; set; }
    public List<Job> Jobs { get; set; }
}

public class ActiveMission
{
    public Id _id { get; set; }
    public int Region { get; set; }
    public int Seed { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Node { get; set; }
    public string MissionType { get; set; }
    public string Modifier { get; set; }
}

public class StartDate
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class EndDate
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class FlashSale
{
    public string TypeName { get; set; }
    public StartDate StartDate { get; set; }
    public EndDate EndDate { get; set; }
    public bool Featured { get; set; }
    public bool Popular { get; set; }
    public bool ShowInMarket { get; set; }
    public bool ShowWithRecommended { get; set; }
    public int BannerIndex { get; set; }
    public int Discount { get; set; }
    public int RegularOverride { get; set; }
    public int PremiumOverride { get; set; }
    public int BogoBuy { get; set; }
    public int BogoGet { get; set; }
}

public class ChainID
{
    [JsonProperty("$oid")] public string Oid { get; set; }
}

public class AttackerMissionInfo
{
    public int seed { get; set; }
    public string faction { get; set; }
}

public class CountedItem
{
    public string ItemType { get; set; }
    public int ItemCount { get; set; }
}

public class DefenderReward
{
    public List<CountedItem> countedItems { get; set; }
}

public class DefenderMissionInfo
{
    public int seed { get; set; }
    public string faction { get; set; }
    public List<object> missionReward { get; set; }
}

public class Invasion
{
    public Id _id { get; set; }
    public string Faction { get; set; }
    public string DefenderFaction { get; set; }
    public string Node { get; set; }
    public int Count { get; set; }
    public int Goal { get; set; }
    public string LocTag { get; set; }
    public bool Completed { get; set; }
    public ChainID ChainID { get; set; }
    public object AttackerReward { get; set; }
    public AttackerMissionInfo AttackerMissionInfo { get; set; }
    public DefenderReward DefenderReward { get; set; }
    public DefenderMissionInfo DefenderMissionInfo { get; set; }
    public Activation Activation { get; set; }
}

public class NodeOverride
{
    public Id _id { get; set; }
    public string Node { get; set; }
    public bool Hide { get; set; }
    public int? Seed { get; set; }
    public string LevelOverride { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Faction { get; set; }
    public List<string> CustomNpcEncounters { get; set; }
    public string EnemySpec { get; set; }
    public string ExtraEnemySpec { get; set; }
}

public class VoidTrader
{
    public Id _id { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Character { get; set; }
    public string Node { get; set; }
}

public class InitialStartDate
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class Manifest
{
    public string ItemType { get; set; }
    public int PrimePrice { get; set; }
    public int? RegularPrice { get; set; }
}

public class ScheduleInfo
{
    public Expiry Expiry { get; set; }
    public string FeaturedItem { get; set; }
}

public class PrimeVaultTrader
{
    public Id _id { get; set; }
    public Activation Activation { get; set; }
    public string Node { get; set; }
    public InitialStartDate InitialStartDate { get; set; }
    public bool Completed { get; set; }
    public List<Manifest> Manifest { get; set; }
    public Expiry Expiry { get; set; }
    public List<ScheduleInfo> ScheduleInfo { get; set; }
}

public class VoidStorm
{
    public Id _id { get; set; }
    public string Node { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string ActiveMissionTier { get; set; }
}

public class PrimeAccessAvailability
{
    public string State { get; set; }
}

public class DailyDeal
{
    public string StoreItem { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public int Discount { get; set; }
    public int OriginalPrice { get; set; }
    public int SalePrice { get; set; }
    public int AmountTotal { get; set; }
    public int AmountSold { get; set; }
}

public class LibraryInfo
{
    public string LastCompletedTargetType { get; set; }
}

public class StartDate2
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class EndDate2
{
    [JsonProperty("$date")] public Date Date { get; set; }
}

public class Param
{
    public string n { get; set; }
    public int v { get; set; }
}

public class SubChallenge
{
    [JsonProperty("$oid")] public string Oid { get; set; }
}

public class PVPChallengeInstance
{
    public Id _id { get; set; }
    public string challengeTypeRefID { get; set; }
    public StartDate startDate { get; set; }
    public EndDate endDate { get; set; }
    public List<Param> @params { get; set; }
    public bool isGenerated { get; set; }
    public string PVPMode { get; set; }
    public List<SubChallenge> subChallenges { get; set; }
    public string Category { get; set; }
}

public class AllianceId
{
    [JsonProperty("$oid")] public string Oid { get; set; }
}

public class FeaturedGuild
{
    public Id _id { get; set; }
    public string Name { get; set; }
    public int Tier { get; set; }
    public AllianceId AllianceId { get; set; }
}

public class ActiveChallenge
{
    public Id _id { get; set; }
    public bool Daily { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string Challenge { get; set; }
}

public class SeasonInfo
{
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public string AffiliationTag { get; set; }
    public int Season { get; set; }
    public int Phase { get; set; }
    public string Params { get; set; }
    public List<ActiveChallenge> ActiveChallenges { get; set; }
}

public class Root
{
    public string WorldSeed { get; set; }
    public int Version { get; set; }
    public string MobileVersion { get; set; }
    public string BuildLabel { get; set; }
    public int Time { get; set; }
    public List<Event> Events { get; set; }
    public List<Goal> Goals { get; set; }
    public List<object> Alerts { get; set; }
    public List<Sorty> Sorties { get; set; }
    public List<SyndicateMission> SyndicateMissions { get; set; }
    public List<ActiveMission> ActiveMissions { get; set; }
    public List<object> GlobalUpgrades { get; set; }
    public List<FlashSale> FlashSales { get; set; }
    public List<Invasion> Invasions { get; set; }
    public List<object> HubEvents { get; set; }
    public List<NodeOverride> NodeOverrides { get; set; }
    public List<VoidTrader> VoidTraders { get; set; }
    public List<PrimeVaultTrader> PrimeVaultTraders { get; set; }
    public List<VoidStorm> VoidStorms { get; set; }
    public PrimeAccessAvailability PrimeAccessAvailability { get; set; }
    public List<bool> PrimeVaultAvailabilities { get; set; }
    public bool PrimeTokenAvailability { get; set; }
    public List<DailyDeal> DailyDeals { get; set; }
    public LibraryInfo LibraryInfo { get; set; }
    public List<PVPChallengeInstance> PVPChallengeInstances { get; set; }
    public List<object> PersistentEnemies { get; set; }
    public List<object> PVPAlternativeModes { get; set; }
    public List<object> PVPActiveTournaments { get; set; }
    public List<double> ProjectPct { get; set; }
    public List<object> ConstructionProjects { get; set; }
    public List<object> TwitchPromos { get; set; }
    public List<object> ExperimentRecommended { get; set; }
    public int ForceLogoutVersion { get; set; }
    public List<FeaturedGuild> FeaturedGuilds { get; set; }
    public SeasonInfo SeasonInfo { get; set; }
    public string Tmp { get; set; }
}