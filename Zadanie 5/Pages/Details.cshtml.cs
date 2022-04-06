using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;
namespace Zadanie_5.Pages.Shared
{
    public class DetailsModel : MyPageModel
    {
        public Product detailsProduct = new Product();

       // public List<Product> productList;

        public void OnGet(int id)
        {
            LoadDB();
            detailsProduct = productDB.List().FirstOrDefault(x => x.id == id);
            SaveDB();
        }
        public IActionResult OnPost(int id)
        {
            LoadDB();
            productDB.AddToBucket(productDB.List().FirstOrDefault(x => x.id == id));
            SaveDB();
            return RedirectToPage("Bucket");
        }

    }
}
