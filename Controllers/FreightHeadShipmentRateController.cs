using System;
using GP.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP.Controllers
{
    public class FreightHeadShipmentRateController : Controller
    {
        // GET: FreightHeadShipmentRate
        public ActionResult Index()
        {

            //int Id = (int)TempData["ID"];

            //if (TempData["ID"] != null)
            //    Id = TempData["ID"];
            //return View();
            //ViewBag.ID = Id;
            return View();
        }

        [HttpPost]
        public ActionResult Index(FreightHeadShipmentRate model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB_GPEntities1 db = new DB_GPEntities1();


                    FreightHeadShipmentRate fhSR = new FreightHeadShipmentRate();
                    fhSR.FreightHeadID = (int)TempData["ID"];
                    fhSR.FreightHeadShipmentTypeID = model.FreightHeadShipmentTypeID;
                    fhSR.FreightContainerType = model.FreightContainerType;
                    fhSR.FreightPackingType = model.FreightPackingType;
                  
                    fhSR.RateOfferedToTraders = model.RateOfferedToTraders;
                    fhSR.RateOfferedByShippingLine = model.RateOfferedByShippingLine;
                    fhSR.RateOfferedByShippingLine = model.RateOfferedByShippingLine;
                    fhSR.TotalAmoutToTraders = model.TotalAmoutToTraders;
                    fhSR.TotalAmountOfShippingLine = model.TotalAmountOfShippingLine;
                    fhSR.LastUpdatedBy = "Admin";
                    fhSR.LastUpdatedOn = DateTime.Now;

                    db.FreightHeadShipmentRates.Add(fhSR);
                    db.SaveChanges();
                    return RedirectToAction("Index", "FrightHead");
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            return View();

        }
    }
}