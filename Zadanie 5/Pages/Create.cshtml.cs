using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class CreateModel :MyPageModel
    {
        [BindProperty(SupportsGet =true)]
        public Product newProduct { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                LoadDB();
                productDB.Create(newProduct);         
                SaveDB();
            }

            return RedirectToPage("List");
        }
    }
}
