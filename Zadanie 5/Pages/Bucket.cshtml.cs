using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class BucketModel : MyPageModel
    {
        public List<Product> bucketList;

        public Product product { get; set; }
        public void OnGet()
        {
            LoadDB();
            bucketList = productDB.BucketList();
            SaveDB();
        }
        public IActionResult OnPost(Product p)
        {
            return RedirectToPage("Bucket", p);
        }
    }
}
