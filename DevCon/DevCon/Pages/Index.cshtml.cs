using DevCon;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Concurrent;
using System.Linq;

namespace DevConClicker.Pages
{
    public class IndexModel : PageModel
    {
        public static Tracker Tracker { get; } = new Tracker();
        public void OnGet() => Tracker.Track(HttpContext.Connection.RemoteIpAddress.ToString());
    }
}
