using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task__2.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace task__2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Productdet> Get()
        {
            masterContext pnt = new masterContext();
            return pnt.Productdet;
        }

        // GET api/<ProductController>/5
        [HttpGet("{pcode}")]
        public IEnumerable<Productdet> Get(int pcode)
        {
            masterContext pnt = new masterContext();
            var sql = from i in pnt.Productdet where i.Pcode == pcode select i;
            return sql;
        }
        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Productdet value)
        {
            masterContext pnt = new masterContext();
            pnt.Productdet.Add(value);
            pnt.SaveChanges();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productdet value)
        {
            masterContext pnt = new masterContext();
            var det = pnt.Productdet.Find(id);
            if (det != null)
            {
                det.Pname = value.Pname;
                det.Pdesc = value.Pdesc;
                det.Unitprice = value.Unitprice;
                det.Category = value.Category;
                det.Stockinhand = value.Stockinhand;
                pnt.SaveChanges();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            masterContext pnt = new masterContext();
            var del = pnt.Productdet.Find(id);
            pnt.Productdet.Remove(del);
            pnt.SaveChanges();
        }
    }
}
