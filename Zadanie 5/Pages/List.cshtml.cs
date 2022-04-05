using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Zadanie_5.Models;
namespace Zadanie_5
{
    public class ListModel : MyPageModel
    {
        public List<Product> productList;

        public Product product { get; set; }
        public void OnGet()
        {
            LoadDB();
            productList = productDB.List();
            SaveDB();
        }
        public IActionResult OnPost(Product p)
        {
            return RedirectToPage("Edit",p);
        }
    }
}
