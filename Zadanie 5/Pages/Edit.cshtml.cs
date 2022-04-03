using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class EditModel : MyPageModel
    {
        [BindProperty(SupportsGet = true)]
        public Product editProduct { get; set; }
        public void OnGet(Product p)
        {
            editProduct = p;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                LoadDB();
                productDB.Create(editProduct);
                SaveDB();
            }

            return RedirectToPage("List");
        }
    }
}
