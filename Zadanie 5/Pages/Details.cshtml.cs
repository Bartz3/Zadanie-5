using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
using Zadanie_5.DAL;
namespace Zadanie_5.Pages.Shared
{
    public class DetailsModel : MyPageModel
    {
        public Product detailsProduct = new Product();

        public List<Product> productList;

        public void OnGet(int id)
        {
            LoadDB();
            productList = productDB.List();
            SaveDB();
            detailsProduct = productList.FirstOrDefault(x => x.id == id);
        }

    }
}
