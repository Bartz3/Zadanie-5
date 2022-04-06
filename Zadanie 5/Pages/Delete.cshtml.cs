using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;

namespace Zadanie_5.Pages
{
    public class DeleteModel : MyPageModel
    {
       [BindProperty]
       public Product deleteProduct { get; set; }

        public void OnGet(int id)
        {
           LoadDB();
           deleteProduct = productDB.List().FirstOrDefault(x => x.id == id);
           SaveDB();
            
        }
        public IActionResult OnPost(int id)
        {
            LoadDB();
            productDB.Delete(productDB.List().FirstOrDefault(x => x.id == id));
            SaveDB();
            
            return RedirectToPage("List");
        }
    }
}
