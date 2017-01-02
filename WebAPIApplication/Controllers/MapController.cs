using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Models;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class MapController : Controller
    {
        [HttpGet]
        public IEnumerable<Map> Get()
        {
            return new Map[] { new Map() { MapID = 1, MapName="TestContent", Width = 200, Height=100 } };
        }

        [HttpGet("{MapID}")]
        public Map Get(int MapID)
        {
            return new Map() { MapID = 1, MapName="TestContent", Width = 200, Height=100 };
        }

        [HttpPost]
        public void Post([FromBody]Map value)
        {
        }

        [HttpPut("{MapID}")]
        public void Put(int MapID, [FromBody]Map value)
        {
        }

        [HttpDelete("{MapID}")]
        public void Delete(int MapID)
        {
        }
    }
}
