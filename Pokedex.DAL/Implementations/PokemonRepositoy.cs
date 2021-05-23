using MySql.Data.MySqlClient;
using Pokedex.DAL.Contracts;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Implementations
{
    public class PokemonRepositoy : IPokemonRepository
    {
        public PokedexContext context { get; set; }

        public PokemonRepositoy(PokedexContext context)
        {
            this.context = context;
        }

        public List<Pokemon> Pokemon(Pokemon pokemon)
        {
            List<Pokemon> listaPokemon = new List<Pokemon>();
            using(MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("select * from pokemon"), conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPokemon.Add(
                            new Pokemon
                            {
                                Numero = reader.GetInt32("Numero"),
                                Nombre = reader.GetString("Nombre"),
                                Altura = reader.GetFloat("Altura"),
                                Categoria = reader.GetString("Categoria"),
                                Descripcion = reader.GetString("Descripcion"),
                                Habilidad = reader.GetString("Habilidad"),
                                Peso = reader.GetFloat("Peso")
                            }
                            );
                    }
                }


            }
            return listaPokemon;
        }

        
    }
}
