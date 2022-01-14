using Newtonsoft.Json;

namespace WarframeUtil.Data.RivenHunter;

public class Buff
{
    [JsonProperty("tag")]
    public string Tag { get; set; }

    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("curse")]
    public bool Curse { get; set; }
}

public class Datum
{
    [JsonProperty("itemtype")]
    public string Itemtype { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("guid")]
    public string Guid { get; set; }

    [JsonProperty("riven_id")]
    public int RivenId { get; set; }

    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("lastseen")]
    public DateTime Lastseen { get; set; }

    [JsonProperty("mastery")]
    public int Mastery { get; set; }

    [JsonProperty("polarity")]
    public int Polarity { get; set; }

    [JsonProperty("rolls")]
    public int Rolls { get; set; }

    [JsonProperty("sendername")]
    public string Sendername { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("price")]
    public int? Price { get; set; }

    [JsonProperty("buffs")]
    public List<Buff> Buffs { get; set; }

    [JsonProperty("matching_buffs")]
    public int MatchingBuffs { get; set; }

    [JsonProperty("forumid")]
    public int? Forumid { get; set; }

    [JsonProperty("forum_image")]
    public string ForumImage { get; set; }

    [JsonProperty("message_count")]
    public int MessageCount { get; set; }

    [JsonProperty("messageplacementid")]
    public int Messageplacementid { get; set; }
}

public class Meta
{
}

public class Root
{
    [JsonProperty("data")]
    public List<Datum> Data { get; set; }

    [JsonProperty("meta")]
    public Meta Meta { get; set; }
}