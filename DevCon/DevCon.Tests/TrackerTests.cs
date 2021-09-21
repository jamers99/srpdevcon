using DevCon;
using Xunit;

namespace DevConClicker.Tests
{
    public class TrackerTests
    {
        [Fact]
        public void Tracker_Visits()
        {
            var tracker = new Tracker();
            Assert.Equal(0, tracker.TotalVisits);

            tracker.Track("test");
            tracker.Track("test");
            tracker.Track("test2");
            Assert.Equal(2, tracker.UniqueVisits);
            Assert.Equal(3, tracker.TotalVisits);
        }
    }
}
