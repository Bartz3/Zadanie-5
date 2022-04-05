using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;

namespace Zadanie_5.Pages
{
    public class DeleteModel : MyPageModel
    {
        
        public Product deleteProduct = new Product();

        public ProductDB productDB { get; set; }

        private ProductDB productdebe = new ProductDB();

        public List<Product> products = new List<Product>();
        public void OnGet(int id)
        {
            deleteProduct.id = id;
            //deleteProduct = (Product)productDB.List().Where(x => x.id == id);
           // deleteProduct.name= productdebe..Find(x => x.id == id).name.ToString();
            
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
