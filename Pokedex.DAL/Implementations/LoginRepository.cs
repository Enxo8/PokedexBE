
using MySqlConnector;
using Pokedex.DAL.Contracts;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Implementations
{
    public class LoginRepository : ILoginRepository
    {
        public PokedexContext context { get; set; }
        public LoginRepository(PokedexContext context)
        {
            this.context = context;
        }

        public bool Login(Usuario usuario)
        {
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("select * from login " +
                                                    "where Username = '{0}' and" +
                                                    " Password = '{1}'", usuario.Username, usuario.password), conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
