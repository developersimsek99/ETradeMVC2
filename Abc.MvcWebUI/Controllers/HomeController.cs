using Abc.MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext(); //DataInitializer (veritabanını) tanıtma
        
        // GET: Home
        public ActionResult Index()
        {
            //Anasayfada tüm ürünlerin listelenmesi
            return View(_context.Products.Where(i=>i.IsHome && i.IsApproved).ToList());
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).FirstOrDefault());
        }
        public ActionResult List()
        {
            return View(_context.Products.Where(i => i.IsApproved).ToList());
        }
    }
}