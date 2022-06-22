using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Trabajo.Practico.Entity.Framework.Entities;
using Trabajo.Practico.Entity.Framework.Logic;

namespace Trabajo.Practico.Entity.Framework.Api.Controllers
{
    public class ShippersController : ApiController
    {
        private ShippersABLM logic=new ShippersABLM();

        // GET: api/Shippers
        public List<Shippers> GetShippers()
        {
            return logic.GetAll();
        }

        // GET: api/Suppliers/5
        [ResponseType(typeof(Shippers))]
        public IHttpActionResult GetShippers(int id)
        {
            Shippers shippers = logic.GetOne(id);
            if (shippers == null)
            {
                return NotFound();
            }

            return Ok(shippers);
        }

        // PUT: api/Suppliers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSuppliers(int id, Shippers shippers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shippers.ShipperID)
            {
                return BadRequest();
            }

            logic.Udate(shippers);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Suppliers
        [ResponseType(typeof(Shippers))]
        public IHttpActionResult PostSuppliers(Shippers shippers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            logic.Add(shippers);

            return CreatedAtRoute("DefaultApi", new { id = shippers.ShipperID }, shippers);
        }

        // DELETE: api/Suppliers/5
        [ResponseType(typeof(Suppliers))]
        public IHttpActionResult DeleteSuppliers(int id)
        {
            Shippers shippers =logic.GetOne(id);
            if (shippers == null)
            {
                return NotFound();
            }

            logic.Delete(id);

            return Ok(shippers);
        }
    }
}
