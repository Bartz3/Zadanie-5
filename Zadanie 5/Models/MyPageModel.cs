﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;
using Zadanie_5.DAL;

namespace Zadanie_5.Models
{
    public class MyPageModel : PageModel
    {
        public ProductDB productDB;

        public string jsonProductDB { get; set; }   

        public MyPageModel()
        {
            productDB = new ProductDB();
        }

        public void LoadDB()
        {
            jsonProductDB = HttpContext.Session.GetString("jsonProductDB");
            productDB.Load(jsonProductDB);
        }

        public void SaveDB() 
        { 
            jsonProductDB=productDB.Save();
            HttpContext.Session.SetString("jsonProductDB", jsonProductDB);
        }
    }
}
