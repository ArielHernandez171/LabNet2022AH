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
    public class SuppiersController : Controller
    {
        // GET: Suppiers
        public ActionResult Index()
        {
            var logic = new SuppiersLogic();
            List<Suppliers> suppiers = logic.GetAll();
            var listSup =suppiers.Select(s => new SuplierModel
            {
                Id = s.SupplierID,
                Nombre = s.CompanyName
            });

            return View(listSup);
        }
       
        // POST: Suppiers/Create
        [HttpPost]
        public ActionResult Create(ShippersModel shippersModel)
        {
            try
            {
                var logic = new ShippersABLM();
                if (shippersModel.CompanyName == null)
                {
                    throw new ExcepcionIngresoNulo();
                }
                Shippers shippers = new Shippers();
                shippers.ShipperID = logic.GetAll().Count;
                shippers.CompanyName = shippersModel.CompanyName;
                logic.Add(shippers);
                return RedirectToAction("Index");
            }
            catch(ExcepcionIngresoNulo ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }catch(Exception ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }
        }


        // POST: Suppiers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ShippersModel shippersModel)
        {
            try
            {
                var logic = new ShippersABLM();
                if (shippersModel.CompanyName == null)
                {
                    throw new ExcepcionIngresoNulo();
                }
                Shippers shippers = new Shippers();
                shippers.ShipperID = logic.GetAll().Count;
                shippers.CompanyName = shippersModel.CompanyName;
                logic.Add(shippers);
                return RedirectToAction("Index");
            }
            catch(ExcepcionIngresoNulo ex)
            {
                return RedirectToAction("Index", "Error",ex.Message);
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error",ex.Message);
            }
        }


        // POST: Suppiers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var logic = new ShippersABLM();
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (ExcepcionEstaVinculada ex)
            {
                return RedirectToAction("Index","Error", ex.Message);
            }
        }
    }
}
