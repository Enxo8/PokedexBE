using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.BL.Contracts;
using Pokedex.Core.DTO;
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
        public IUsuariosBL usuarioBL { get; set; }

        public UsuarioController(IUsuariosBL usuarioBL)
        {
            this.usuarioBL = usuarioBL;
        }

        [HttpPost]
        public ActionResult Crear(UsuariosDTO usuario)
        {
            usuarioBL.Insertar(usuario);
            return Ok();
        }

        [HttpPut]
        public void Actualizar(UsuariosDTO usuario)
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
