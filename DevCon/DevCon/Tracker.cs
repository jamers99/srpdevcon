using System.Collections.Concurrent;
using System.Linq;

namespace DevCon
{
    public class Tracker
    {
        public int TotalVisits { get; set; }
        public int UniqueVisits => IPVisits.Count;

        public ConcurrentBag<string> IPVisits { get; } = new ConcurrentBag<string>();

        public void Track(string ip)
        {
            TotalVisits++;
            if (!IPVisits.Contains(ip))
                IPVisits.Add(ip);
        }
    }
}
