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
    public class DA_Productos
    {
        private ConnectionToMySql conexion = new ConnectionToMySql();
        MySqlCommand comando = new MySqlCommand();

        public void InsertarProducto(string descripcion, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO productos (descripcion,precio) VALUE ('"+descripcion+"', "+precio+")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }




    }
}
