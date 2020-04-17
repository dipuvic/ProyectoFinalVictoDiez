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

        MySqlDataReader leerprod;
        DataTable tabla = new DataTable();

        public DataTable MostrarProductos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM producto;";
            leerprod = comando.ExecuteReader();
            tabla.Load(leerprod);
            conexion.CerrarConexion();

            return tabla;
        }

        public void InsertarProducto(string descripcion, string precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO producto (descripcion,precio) VALUE ('"+descripcion+"', "+precio+");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EditarProducto(int referencia, string descripcion, string precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE producto SET descripcion='"+descripcion+"', precio='"+precio+"' WHERE referencia="+referencia+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarProducto(int referencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM producto WHERE referencia=" + referencia + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void BuscarProducto(int referencia, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM producto WHERE referencia='%"+ referencia + "%' OR '%'" + descripcion + "'%';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


    }
}
