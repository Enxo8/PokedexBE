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
    public class UsuariosRepository : IUsuariosRepository
    {
        public PokedexContext context { get; set; }
        public UsuariosRepository(PokedexContext context)
        {
            this.context = context;
        }
        public void Insertar(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "insert into usuarios (username,password) values (@username,@password)";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.password);

            conn.Open();
            int result = command.ExecuteNonQuery();

            if (result < 0)
                Console.WriteLine("Error insertando datos en la base de datos");

        }

        public void Actualizar(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "update usuarios set password = @password where username = @username";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.password);

            conn.Open();
            int result = command.ExecuteNonQuery();

            
            if (result < 0)
                Console.WriteLine("Error actualizando datos en la base de datos");
        }

        public void Delete(string username)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "delete from usuarios where username = @username";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", username);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error actualizando datos en la base de datos");
        }
    }
}
