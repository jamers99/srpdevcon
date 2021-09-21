using DevConClicker.Pages;
using System;
using Xunit;

namespace DevConClicker.Tests
{
    public class IndexTests
    {
        [Fact]
        public void Index_GlobalCounter()
        {
            var originalCount = IndexModel.TotalVisits;
            var index = new IndexModel();
            index.OnGet();
            Assert.Equal(originalCount + 1, IndexModel.TotalVisits);

            index.OnGet();
            Assert.Equal(originalCount + 2, IndexModel.TotalVisits);
        }
    }
}
