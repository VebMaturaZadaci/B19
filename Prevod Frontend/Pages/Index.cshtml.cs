using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace PrevodApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string RecLat { get; set; }
        [BindProperty]
        public string RecCir { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> OnPostPrCir()
        {
            string putanja = "https://localhost:7186/api/Prevod/LatinicaUCirilicu/";
            using (var klijent = new HttpClient())
            {
                var response = await klijent.GetAsync(putanja + RecLat);
                RecCir = await response.Content.ReadAsStringAsync();
            }
            return Page();

        }
        public async Task<IActionResult> OnPostPrLat()
        {
            string putanja = "https://localhost:7186/api/Prevod/CirilicaULatinicu/";
            using (var klijent = new HttpClient())
            {
                var response = await klijent.GetAsync(putanja + RecCir);
                RecLat = await response.Content.ReadAsStringAsync();
            }
            return Page();

        }
    }
}