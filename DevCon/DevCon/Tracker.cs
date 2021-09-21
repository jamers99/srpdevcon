namespace DevCon
{
    public class Tracker
    {
        public int TotalVisits { get; private set; }

        public void Track()
        {
            TotalVisits++;
        }
    }
}
