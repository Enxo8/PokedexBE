using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.BL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonControler : ControllerBase
    {
        public IPokemonBL pokemonBL { get; set; }

        public PokemonControler(IPokemonBL pokemonBL)
        {
            this.pokemonBL = pokemonBL;
        }


    }
}
