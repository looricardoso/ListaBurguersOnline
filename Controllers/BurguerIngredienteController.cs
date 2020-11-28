using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurguerIngredienteController : ControllerBase
    {
        private hamburgueriaContext _db { get; set; }
        public BurguerIngredienteController(hamburgueriaContext config)
        {
            _db = config;
        }

        [HttpGet]
        public List<BurguerIngrediente> Get()
        {
            var ListaBurguerIngrediente = _db.BurguerIngrediente
                .ToList();

            return ListaBurguerIngrediente;
        }
    }
}

