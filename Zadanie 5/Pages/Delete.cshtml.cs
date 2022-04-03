using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;

namespace Zadanie_5.Pages
{
    public class DeleteModel : MyPageModel
    {
        [BindProperty(SupportsGet = true)]
        public Product deleteProduct { get; set; }
        public void OnGet(Product p)
        {
            deleteProduct = p;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                
                LoadDB();
                productDB.Delete(deleteProduct);
                SaveDB();

            }
            return RedirectToPage("List");
        }
    }
}
