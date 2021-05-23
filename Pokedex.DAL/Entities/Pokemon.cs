using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Entities
{
    public class Pokemon
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
