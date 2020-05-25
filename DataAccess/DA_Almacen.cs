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
    public class DA_Almacen
    {
        private ConnectionToMySql conexion = new ConnectionToMySql();
        MySqlCommand comando = new MySqlCommand();

        MySqlDataReader leerFilas;
        DataTable tabla = new DataTable();


        public DataTable MostrarAlmacen()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT referencia AS Referencia, lugar AS Lugar, fecha AS Fecha, nota AS Nota FROM almacen; ";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            conexion.CerrarConexion();

            return tabla;
        }

        public void InsertarAlmacen(int referencia, string lugar, string nota)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO almacen (referencia, lugar, nota) VALUE (" + referencia + ", '" + lugar + "','" + nota + "');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarAlmacen(int referencia, string lugar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT almacen.referencia AS Referencia, almacen.lugar AS Lugar, almacen.fecha AS Fecha, almacen.nota AS Nota FROM almacen WHERE(almacen.referencia LIKE CONCAT('%', @Referencia, '%')) AND(almacen.lugar LIKE CONCAT('%', @Lugar, '%')); ";

            comando.Parameters.AddWithValue("@Referencia", referencia);
            comando.Parameters.AddWithValue("@Lugar", lugar);

            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
