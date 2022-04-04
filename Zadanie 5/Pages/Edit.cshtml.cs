using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class EditModel : MyPageModel
    {
        [BindProperty(SupportsGet = true)]
        public Product editProduct { get; set; }
        public void OnGet(int id)
        {
            editProduct.id = id;
            editProduct.name = productDB.List().Find(x => x.id == id).ToString();
            editProduct.name = productDB.List().FirstOrDefault(x => x.id == id).ToString() ?? string.Empty;
            //editProduct.price = productDB.List().Find(x => x.id == id).ToString();
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
