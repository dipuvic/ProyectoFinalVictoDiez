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
    public class DA_Llamadas
    {
        private ConnectionToMySql conexion = new ConnectionToMySql();
        MySqlCommand comando = new MySqlCommand();

        MySqlDataReader leerFilas;
        DataTable tabla = new DataTable();

        //Funciones datatable para listar los correspondientes combobox
        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select id_user, concat_ws(' ', usuario.nombre, usuario.apellido) as Persona From usuario ORDER BY Persona ASC;";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select id_cliente, nombre as Cliente From cliente ORDER BY Cliente ASC;";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }



        public DataTable MostrarProductos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT producto.referencia AS Referencia, producto.descripcion AS Descripción, categoria.catpadre AS Categoria, producto.precio AS Precio FROM producto INNER JOIN categoria ON producto.idcat = categoria.idcat ORDER BY referencia; ";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            conexion.CerrarConexion();

            return tabla;
        }

        public DataTable BuscarRef(int referencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT producto.referencia AS Referencia, producto.descripcion AS Descripción, categoria.catpadre AS Categoria, producto.precio AS Precio FROM producto INNER JOIN categoria ON producto.idcat = categoria.idcat WHERE (producto.referencia LIKE CONCAT('%', @Referencia, '%')) ORDER BY referencia ASC;";

            comando.Parameters.AddWithValue("@Referencia", referencia);

            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
                              