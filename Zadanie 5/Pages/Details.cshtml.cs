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
            // 1, 2
            LoadDB();
            var cookie = Request.Cookies["ciastkowyProdukt"];
            if(cookie == null)
            {
                cookie = String.Empty;
            }

                cookie += "," + id.ToString();
              Response.Cookies.Append("ciastkowyProdukt", cookie);
            
            //var cookieValue = Request.Cookies["MyCookie"];
            SaveDB();
            return RedirectToPage("Bucket");
        }

    }
}
