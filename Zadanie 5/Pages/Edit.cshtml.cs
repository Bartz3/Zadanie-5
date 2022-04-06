using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class EditModel : MyPageModel
    {
        [BindProperty(SupportsGet = true)]
        public Product editProduct { get; set; }

        
        public List<Product> productList;
        public void OnGet(int id)
        {

            LoadDB();
            productList = productDB.List();
            editProduct = productList.FirstOrDefault(x => x.id == id);
            SaveDB();
            
        }

        public IActionResult OnPost(int id)
        {
            LoadDB();
            productList = productDB.List();
            productDB.Edit(editProduct);
            SaveDB();

            return RedirectToPage("List");
        }
    }
}
