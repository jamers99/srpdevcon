using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevConClicker.Pages
{
    public class IndexModel : PageModel
    {
        public static int TotalVisits { get; private set; }

        public void OnGet() => TotalVisits++;
    }
}
