using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common.Cache;


namespace DataAccess
{
    public class UserDao: ConnectionToMySql
    {
        private ConnectionToMySql conexion = new ConnectionToMySql();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leer;
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_user, nombre, apellido, telefono, email, cargo FROM usuario INNER JOIN cargo ON usuario.idcargo = cargo.idcargo WHERE (login=@user and contraseña=@pass) or (email=@user and contraseña=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Apellido = reader.GetString(2);
                            UserLoginCache.Telefono = reader.GetString(3);
                            UserLoginCache.Email = reader.GetString(4);
                            UserLoginCache.Cargo = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                        return false;
                }
                
            }


        }
 
    }
}
