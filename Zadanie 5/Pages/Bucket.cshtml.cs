using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages
{
    public class BucketModel : MyPageModel
    {
        public List<Product> bucketList=new List<Product>();
        
        public Product product { get; set; }
        public void OnGet()
        {
            LoadDB();
            var cookie = Request.Cookies["ciastkowyProdukt"];
            if (cookie == null)
            {
                return;
            }
            string[] IDs = cookie.Split(',');
            int pom;
            Product proudkt;
            foreach (var id in IDs)
            {
               bool bool2 = int.TryParse(id, out pom);
                if (!bool2)
                    continue;
               proudkt=productDB.List().FirstOrDefault(x => x.id == pom);
               bucketList.Add(proudkt);
            }
           
            SaveDB();
        }
        public IActionResult OnPost()
        {
            Response.Cookies.Delete("ciastkowyProdukt");
            return RedirectToPage("Bucket");
        }
      
    }
}
