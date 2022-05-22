using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Entidades;
using System.Collections.Generic;


namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresControllers : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>(){
                new Autor() {Id = 1, Nombre = "Felipe"},
                new Autor() {Id = 2, Nombre = "Claudia"}
                };
        }
    }
}