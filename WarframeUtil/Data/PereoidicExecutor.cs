using System.Net;
using System.Timers;
using Microsoft.EntityFrameworkCore;
using SimpleJSON;
using Timer = System.Timers.Timer;

namespace WarframeUtil.Data;
public class JobExecutedEventArgs : EventArgs {}

public class PereoidicExecutor : IDisposable
{
    private ApplicationDbContext db;

    public PereoidicExecutor(IServiceProvider serviceProvider)
    {
        db = serviceProvider.GetRequiredService<ApplicationDbContext>();
    }

    public event EventHandler<JobExecutedEventArgs> JobExecuted;

    void OnJobExecuted()
    {
        JobExecuted?.Invoke(this, new JobExecutedEventArgs());
    }

    System.Timers.Timer _Timer;
    bool _Running;

    public void StartExecuting()
    {
        if (!_Running)
        {
            //initiate a timer
            _Timer = new System.Timers.Timer();
            _Timer.Interval = 36000000;
            _Timer.AutoReset = true;
            _Timer.Enabled = true;
            _Timer.Elapsed += HandleTimer;
            _Running = true;
        }
    }

    void HandleTimer(object source, ElapsedEventArgs e)
    {
        TimerLogic(); 

        //Execute required jobn
        //notify any subscibers to the event
        OnJobExecuted();
    }

    public void Dispose()
    {
        if (_Running)
        {
            //clear up the timer
            _Timer.Dispose();
        }
    }
    
    
    // db.Rivens.Add(new RivenDBClass()
    // {
    //     DDate = new List<DbDate>(){new DbDate(){ DDate = DateTime.Now}},
    //     Id = 1,
    //     PriceAvg = new List<PriceAvg>() { new PriceAvg(){price = 2}},
    //     Prices = new List<Price>() {new Price() {price = 3}},
    //     UnrolledAvg = new List<UnrolledAvg>() {new UnrolledAvg() {price = 4}}
    // });
    public async Task TimerLogic()
    {
        
        List<RivenDBClass> rivens = new List<RivenDBClass>();

        JSONNode json = JSONNode.Parse(new WebClient().DownloadString("https://10o.io/pricehistory.json?v2"));

        foreach (JSONNode weapon in json)
        {
            List<int> prices = new List<int>();
            List<int> unrolledPrices = new List<int>();
            foreach (JSONNode data in weapon)
            {
                foreach (JSONNode riven in data)
                {
                    if (riven["rolls"] == 0)
                    {
                        unrolledPrices.Add(int.Parse(riven["price"]));
                    }

                    prices.Add(int.Parse(riven["price"]));
                }
            }
            List<int> filteredUnrolledPrices = new List<int>();
            foreach (int item in unrolledPrices)//filter unreasonably high prices on unrolled rivens
            {
                if (item < (int) Math.Round(unrolledPrices.Average() * 0.75))
                {
                    filteredUnrolledPrices.Add(item);
                }
            }
            if (filteredUnrolledPrices.Count == 0)
            {
                filteredUnrolledPrices.Add(1);
            }
            
            List<int> filteredTotalPrices = new List<int>();
            foreach (int item in prices)//filter unreasonably high prices on all rivens
            {
                if (item < (int) Math.Round(prices.Average() * 0.90))
                {
                    filteredTotalPrices.Add(item);
                }
            }
            if (filteredTotalPrices.Count == 0)
            {
                filteredTotalPrices.Add(1);
            }


            rivens.Add(new RivenDBClass()
            {
                Name = weapon["name"].ToString().Trim('\"'),
                PriceAvg = new List<PriceAvg>().Add(new PriceAvg(){ price = int.Parse(Math.Round(filteredTotalPrices.Average()))}),
                UnrolledAvg = filteredUnrolledPrices,
                DDate = new List<DbDate>(){new DbDate(){ DDate = DateTime.Now}}
            });
        }

        foreach (var item in rivens)
        {
            db.Add(item);
        }
        


        await db.SaveChangesAsync();
    }
}