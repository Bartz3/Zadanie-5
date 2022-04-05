using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;

namespace Zadanie_5.Pages
{
    public class DeleteModel : MyPageModel
    {
       //[BindProperty]
       public Product deleteProduct { get; set; }

        //public Product deleteProduct = new Product();

        public List<Product> productList;

        public void OnGet(int id)
        {
            LoadDB();
            //productList = productDB.List();
            deleteProduct = productDB.List().FirstOrDefault(x => x.id == id);

            //deleteProduct.id = productList.FirstOrDefault(x => x.id == id).id;
            //deleteProduct.name = productList.FirstOrDefault(x => x.id == id).name;
            //deleteProduct.price = productList.FirstOrDefault(x => x.id == id).price;
            //deleteProduct.description = productList.FirstOrDefault(x => x.id == id).description;
            SaveDB();
            
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
