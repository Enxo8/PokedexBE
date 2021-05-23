using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.BL.Contracts
{
    public interface IPokemonBL
    {
        public List<Pokemon> Pokemon(Pokemon pokemon);
    }
}
