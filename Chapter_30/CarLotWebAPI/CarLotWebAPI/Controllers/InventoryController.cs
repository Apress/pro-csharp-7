using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using AutoMapper;

namespace CarLotWebAPI.Controllers
{
    [RoutePrefix("api/Inventory")]
    public class InventoryController : ApiController
    {
        //[HttpGet, Route("")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] {"value1", "value2"};
        //}

        //// GET api/values/5
        //[HttpGet, Route("{id}")]
        //public string Get(int id)
        //{
        //    return id.ToString();
        //}
        private readonly InventoryRepo _repo = new InventoryRepo();

        public InventoryController()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<Inventory, Inventory>()
                        .ForMember(x => x.Orders, opt => opt.Ignore());
                });
        }


        // GET: api/Inventory
        [HttpGet, Route("")]
        public IEnumerable<Inventory> GetInventory()
        {
            var inventories = _repo.GetAll();
            return Mapper.Map<List<Inventory>, List<Inventory>>(inventories);
        }

        // GET: api/Inventory/5
        [HttpGet, Route("{id}", Name = "DisplayRoute")]
        [ResponseType(typeof(Inventory))]
        public IHttpActionResult GetInventory(int id)
        {
            Inventory inventory = _repo.GetOne(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Inventory, Inventory>(inventory));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }
            base.Dispose(disposing);
        }

        // PUT: api/Inventory/5
        [HttpPut, Route("{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInventory(int id, Inventory inventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != inventory.Id)
            {
                return BadRequest();
            }
            try
            {
                _repo.Save(inventory);
            }
            catch (Exception ex)
            {
                //Production app should do more here
                throw;
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Inventory
        [HttpPost, Route("", Name = "CreateRoute")]
        [ResponseType(typeof(Inventory))]
        public IHttpActionResult PostInventory(Inventory inventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _repo.Add(inventory);
            }
            catch (Exception ex)
            {
                //Production app should do more here
                throw;
            }
            return CreatedAtRoute("DisplayRoute", new { id = inventory.Id }, inventory);
        }

        // DELETE: api/Inventory/5
        [HttpDelete, Route("{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult DeleteInventory(int id, Inventory inventory)
        {
            if (id != inventory.Id)
            {
                return BadRequest();
            }
            try
            {
                _repo.Delete(inventory);
            }
            catch (Exception ex)
            {
                //Production app should do more here
                throw;
            }
            return Ok();
        }

    }
}