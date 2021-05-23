using AutoMapper;
using Pokedex.DAL.Contracts;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.BL.Implementations
{
    public class PokemonBL
    {
        public IPokemonRepository Pokemonrepository { get; set; }

        

        public PokemonBL(IPokemonRepository pokemonRepository)
        {
            this.Pokemonrepository = Pokemonrepository;
            
        }

        public List<Pokemon> Pokemon(Pokemon pokemon)
        {
            return Pokemonrepository.Pokemon(pokemon);
        }
    }
}
