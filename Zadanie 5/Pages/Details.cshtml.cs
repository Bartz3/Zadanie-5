using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;
namespace Zadanie_5.Pages.Shared
{
    public class DetailsModel : MyPageModel
    {
        [BindProperty]
        public Product detailsProduct { get; set; }
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
            //var cookieValue = Request.Cookies["MyCookie"];
            //Response.Cookies.Append("ciastkowyProdukt", "productDB.List().FirstOrDefault(x => x.id == id)");
            productDB.AddToBucket(productDB.List().FirstOrDefault(x => x.id == id));
            SaveDB();
            return RedirectToPage("Bucket");
        }

    }
}
