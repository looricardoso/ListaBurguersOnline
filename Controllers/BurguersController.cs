using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurguersController : ControllerBase
    {
        private hamburgueriaContext _db { get; set; }
        public BurguersController(hamburgueriaContext config)
        {
            _db = config;
        }

        [HttpGet]
        public List<Burguer> Get()
        {
            var listaDeBurguers = _db.Burguer
                .OrderBy(hb => hb.Nome)
                .ToList();

            return listaDeBurguers;
        }
    }
}