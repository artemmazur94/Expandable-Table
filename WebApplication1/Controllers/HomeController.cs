using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private DataService dataService;

        public HomeController()
        {
            dataService = new DataService(new DataRepository(new DataContext()));
        }

        public ActionResult Index()
        {
            List<SomeModel> listModels = new List<SomeModel>();   
            return View(listModels);
        }


        [HttpPost]
        public JsonResult SaveInDB(string[][] myTable)
        {
            foreach (var row in myTable)
            {
                dataService.Add(new SomeModel()
                {
                    Clicks = Int32.Parse(row[2]),
                    Date = row[1],
                    Value = Int32.Parse(row[0])

                });
            }
            return Json(new {Success = true, Message = "Data was saved to database"});
        }

    }
}