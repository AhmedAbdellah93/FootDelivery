using CooKHouseProject1.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CooKHouseProject1.Controllers
{
    public class HomeController : Controller
    {
        Service service = new Service();
        public ActionResult Index()
        {
            ViewBag.qrt = service.GetAllQuatrer(service.GetAllGovernorate().FirstOrDefault().ID);
            return View(service.GetAllGovernorate());
        }
       
        public JsonResult GetQuarter(int GovId)
        {
            List<CookHouseDB.DAL.Quarter> listQuarter = new List<CookHouseDB.DAL.Quarter>();
            listQuarter.Add(new CookHouseDB.DAL.Quarter() { Quarter_Name = "Select Quarter", ID = -1 });
             listQuarter.AddRange ( service.GetAllQuatrer(GovId));  
                    
            return Json(listQuarter, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(int GovId,int qrtId)
        {
            return View(service.GetResurants(GovId,qrtId));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}