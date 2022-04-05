using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class EditModel : MyPageModel
    {
       
        public Product editProduct = new Product();
        
        public List<Product> productList;
        public void OnGet(int id)
        {

            LoadDB();
            productList = productDB.List();
            editProduct = productList.FirstOrDefault(x => x.id == id);
            SaveDB();
            
        }

        public IActionResult OnPost()
        {
            productDB.Edit(editProduct);
            productDB.Save();

            return RedirectToPage("List");
        }
    }
}
