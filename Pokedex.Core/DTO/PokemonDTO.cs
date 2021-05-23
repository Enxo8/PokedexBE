using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.DTO
{
    public class PokemonDTO
    {
        public int Numero { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public float Altura { get; set; }

        public float Peso { get; set; }

        public string Categoria { get; set; }

        public string Habilidad { get; set; }

    }
}
