using GP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP.Controllers
{
    public class FrightHeadController : Controller
    {
        // GET: FrightHead
        public ActionResult Index()
        {
            DB_GPEntities1 dB_GP = new DB_GPEntities1();
            //List<FreightHead> list = dB_GP.FreightHeads.ToList();
            //ViewBag.FreightTypeList = new SelectList(list, "FreightHeadID", "FreightType");
            return View();
        }

        [HttpPost]
        public ActionResult Index(FrieghtHeadServiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    DB_GPEntities1 db = new DB_GPEntities1();


                    FreightHead fh = new FreightHead();
                    fh.FHNumber = "";
                    fh.RequestDate = DateTime.Today;
                    fh.RequestedByUser = model.RequestedByUser;
                    fh.Company = model.Company;
                    fh.FreightType = Request.Form["FreightType"].ToString();
                    fh.IncoTerm = model.IncoTerm;
                    fh.Customer = model.Customer;
                    fh.PickUpLocation = model.PickUpLocation;
                    fh.LoadingPort = model.LoadingPort;
                    fh.DischargePort = model.DischargePort;
                    fh.PlaceOfDelivery = model.PlaceOfDelivery;
                    fh.Commodity = model.Commodity;
                    fh.FreightCargoType = model.FreightCargoType;
                    fh.TraderName = model.TraderName;
                    fh.Deparment = model.Deparment;
                    fh.Priority = Request.Form["Priority"].ToString();
                    fh.FreightHeadStatusID = model.FreightHeadStatusID;
                    fh.LastUpdatedBy = "Admin";
                    fh.LastUpdatedOn = DateTime.Now;

                    db.FreightHeads.Add(fh);
                    db.SaveChanges();

                    int latestId = fh.FreightHeadID;
                    TempData["ID"] = latestId;

                    FreightHeadService FHService = new FreightHeadService();
                    FHService.FreightHeadID = latestId;
                    FHService.FreightContainerType = model.FreightContainerType;
                    FHService.NumberOfContainers = model.NumberOfContainers;
                    FHService.FreightPackingType = model.FreightPackingType;
                    FHService.NetWeight = model.NetWeight;
                    FHService.GrossWeight = model.GrossWeight;
                    FHService.FreeTimePeriod = model.FreeTimePeriod;
                    FHService.BLClauses = model.BLClauses;
                    FHService.ShippingCertificate = model.ShippingCertificate;
                    FHService.Remarks = model.Remarks;
                    FHService.LastUpdatedBy = "Admin";
                    FHService.LastUpdatedOn = DateTime.Now;



                    db.FreightHeadServices.Add(FHService);
                    db.SaveChanges();

                    return RedirectToAction("Index", "FreightHeadShipmentRate");
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return View(model);

            
            //return RedirectToAction("Index", "FreightHeadShipmentRate");

        }
    }
}