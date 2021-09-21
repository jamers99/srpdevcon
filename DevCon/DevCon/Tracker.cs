using System.Collections.Concurrent;
using System.Linq;

namespace DevCon
{
    public class Tracker
    {
        public int TotalVisits { get; set; }

        public void Track()
        {
            TotalVisits++;
        }
    }
}
