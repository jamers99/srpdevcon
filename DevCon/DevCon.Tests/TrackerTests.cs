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
            Assert.Equal(0, tracker.UniqueVisits);

            tracker.Track("173.194.222.113");
            tracker.Track("64.233.165.190");
            tracker.Track("64.233.165.190");
            Assert.Equal(3, tracker.TotalVisits);
            Assert.Equal(2, tracker.UniqueVisits);
        }
    }
}
