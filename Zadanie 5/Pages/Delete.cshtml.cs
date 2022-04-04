using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;

namespace Zadanie_5.Pages
{
    public class DeleteModel : MyPageModel
    {
        [BindProperty(SupportsGet = true)]
        public Product deleteProduct { get; set; }

        public ProductDB productDB { get; set; }

        public List<Product> products = new List<Product>();
        public void OnGet(int id)
        {
            deleteProduct.id = id;
            deleteProduct = (Product)productDB.List().Where(x => x.id == id);
            
        }
        public IActionResult OnPost()
        {
                LoadDB();
                productDB.Delete(deleteProduct);
                SaveDB();
            
            return RedirectToPage("List");
        }
    }
}
