using DevConClicker.Pages;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Timers;

namespace DevCon
{
    public class Tracker
    {
        Timer timer;
        public Tracker()
        {
            timer = new Timer(5000);
            timer.AutoReset = false;
            timer.Elapsed += Timer_Elapsed;
        }

        public int TotalVisits { get; set; }
        public int UniqueVisits => IPVisits.Count;

        public ConcurrentBag<string> IPVisits { get; } = new ConcurrentBag<string>();

        public void Track(string ip)
        {
            TotalVisits++;
            if (!IPVisits.Contains(ip))
                IPVisits.Add(ip);

            lock (timer)
            {
                timer.Stop();
                timer.Start();
            }
        }

        public void Load()
        {
            if (File.Exists("ipvisits.txt"))
            {
                var ips = File.ReadAllLines("ipvisits.txt");
                foreach (var ip in ips)
                    IPVisits.Add(ip);
            }
            if (File.Exists("totalvisits.txt"))
                TotalVisits = int.Parse(File.ReadAllText("totalvisits.txt"));
        }

        public void Save()
        {
            File.WriteAllLines("ipvisits.txt", IPVisits);
            File.WriteAllText("totalvisits.txt", TotalVisits.ToString());
        }

        void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Save();
        }
    }
}
