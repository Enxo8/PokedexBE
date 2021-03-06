using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioBL usuarioBL { get; set; }

        public UsuarioController(IUsuarioBL usuarioBL)
        {
            this.usuarioBL = usuarioBL;
        }

        [HttpPost]
        public ActionResult Crear(UsuarioDTO usuario)
        {
            usuarioBL.Insertar(usuario);
            return Ok();
        }

        [HttpPut]
        public void Actualizar(UsuarioDTO usuario)
        {
            usuarioBL.Actualizar(usuario);
        }

        [HttpGet]
        public void Get(int numero)
        {
            //TODO
        }

        [HttpDelete]
        public void Delete(string username)
        {
            usuarioBL.Delete(username);
        }

    }
}
