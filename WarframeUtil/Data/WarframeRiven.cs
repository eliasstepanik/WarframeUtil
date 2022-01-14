using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    public List<Price> Prices { get; set; }
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

public class RivenDBClass
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Price> Prices { get; set; }
    public virtual ICollection<PriceAvg> PriceAvg { get; set; }
    public virtual ICollection<UnrolledAvg> UnrolledAvg { get; set; }
    public virtual ICollection<DbDate> DDate { get; set; } 
}

public class Price
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int PriceId { get; set; }
    public int price { get; set; }
    public int RivenDBClassId { get; set; }
    public RivenDBClass RivenDbClass { get; set; }
}
public class PriceAvg
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int PriceAvgId { get; set; }
    
    public int price { get; set; }
    public int RivenDBClassId { get; set; }
    public RivenDBClass RivenDbClass { get; set; }
}
public class UnrolledAvg
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int UnrolledAvgId { get; set; }
    
    public int price { get; set; }
    public int RivenDBClassId { get; set; }
    public RivenDBClass RivenDbClass { get; set; }
}
public class DbDate
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int DateId { get; set; }
    
    public DateTime DDate { get; set; }
    public int RivenDBClassId { get; set; }
    public RivenDBClass RivenDbClass { get; set; }
}



