namespace WarframeUtil.Data;

public class Riven
{
    public string Name { get; set; }
    public int Count { get; set; }
    public int PriceMin { get; set; }
    public int PriceMax { get; set; }
    public double PriceAvg { get; set; }
    public int UnfilteredPriceMin { get; set; }
    public int UnfilteredPriceMax { get; set; }
    public double UnfilteredPriceAvg { get; set; }
    public RivenStats RivenStats { get; set; }
    public double AverageUnrolled { get; set; }
}

public class RivenStats
{
    public RivenStats()
    {
        Buffs = new List<Buff>();
        Curses = new List<Curse>();
    }
    public List<Buff> Buffs { get; set; }
    public List<Curse> Curses { get; set; }
}

public class Buff
{
    public Buff(string name, int count)
    {
        Name = name;
        Count = count;
    }
    public string Name { get; set; }
    public int Count { get; set; }
}

public class Curse
{
    public Curse(string name, int count)
    {
        Name = name;
        Count = count;
    }
    public string Name { get; set; }
    public int Count { get; set; }
}
