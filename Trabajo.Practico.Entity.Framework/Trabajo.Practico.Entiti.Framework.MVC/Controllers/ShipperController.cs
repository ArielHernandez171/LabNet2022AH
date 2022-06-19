using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabajo.Practico.Entiti.Framework.MVC.Models;
using Trabajo.Practico.Entity.Framework.Entities;
using Trabajo.Practico.Entity.Framework.Exceptions;
using Trabajo.Practico.Entity.Framework.Logic;

namespace Trabajo.Practico.Entiti.Framework.MVC.Controllers
{
    public class ShipperController : Controller
    {
        // GET: Shipper
        public ActionResult Index()
        {
            var logic = new ShippersABLM();
            var listShipper = logic.GetAll();
            var shippers = listShipper.Select(s => new ShippersModel
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName
            }).ToList();
            return View(shippers);
        }


        // POST: Shipper/Create
        [HttpPost]
        public ActionResult Create(ShippersModel shippers)
        {
            try
            {
                var logic = new ShippersABLM();
                Shippers shippers1 = new Shippers();
                shippers1.ShipperID = logic.GetAll().Count;
                if (shippers.CompanyName==null) {
                    throw new ExcepcionIngresoNulo(); }
                shippers1.CompanyName = shippers.CompanyName;

                logic.Add(shippers1);
                return RedirectToAction("Index");
            }
            catch(ExcepcionIngresoNulo ex)
            {
                return RedirectToAction("Index", "Error",ex.Message);
            }
        }

        // POST: Shipper/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ShippersModel shippers)
        {
            try
            {
                var logic = new ShippersABLM();
                Shippers shippers1 = new Shippers();
                if (shippers.CompanyName == null)
                {
                    throw new ExcepcionIngresoNulo();
                }
                shippers1.CompanyName = shippers.CompanyName;

                logic.Udate(shippers1);
                return RedirectToAction("Index");
            }
            catch(ExcepcionIngresoNulo ex)
            {
                return RedirectToAction("Index", "Error", ex.Message); ;
            }
        }

        // GET: Shipper/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var logic = new ShippersABLM();
                logic.Delete(id);
                return View("Index");
            }catch(ExcepcionEstaVinculada ex)
            {
                return RedirectToAction("Index", "Error",ex.Message);
            }
        }
        


    }
}
