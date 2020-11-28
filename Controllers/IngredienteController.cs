using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredienteController : ControllerBase
    {
        private hamburgueriaContext _db { get; set; }
        public IngredienteController(hamburgueriaContext config)
        {
            _db = config;
        }

        [HttpGet]
        public List<Ingrediente> Get()
        {
            var listaDeIngredientes = _db.Ingrediente
                .OrderBy(listaBgIng => listaBgIng.Nome)
                .ToList();

            return listaDeIngredientes;
        }
    }
}