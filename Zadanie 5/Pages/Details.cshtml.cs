using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_5.Models;
namespace Zadanie_5.Pages.Shared
{
    public class DetailsModel : MyPageModel
    {
        [BindProperty(SupportsGet =true)]
        public Product detailsProduct { get; set; }
        public void OnGet(int id,string desc)
        {
            detailsProduct.id = id;
            detailsProduct.description = desc;  
           // detailsProduct.name = productDB.List(id).ToString();
        }
    }
}
