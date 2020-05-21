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

        public DataTable MostrarRegistros()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT llamadas.idllamada AS ID, concat_ws(' ', usuario.nombre, usuario.apellido) as Usuario, cliente.nombre AS Cliente, producto.referencia AS Referencia, llamadas.problema AS Problema, llamadas.observacion AS Observacion, llamadas.fecha AS Fecha FROM llamadas INNER JOIN usuario ON llamadas.idusuario = usuario.id_user INNER JOIN cliente ON llamadas.idcliente = cliente.id_cliente INNER JOIN producto ON llamadas.referencia = producto.referencia; ";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
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

        public void InsertarLlamada(int idusuario, int atiende, int idcliente, int referencia, string problema, string observacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO llamadas (idusuario,atiende,idcliente,referencia,problema,observacion) VALUE ("+idusuario+","+atiende+","+idcliente+","+referencia+",'"+problema+"','"+observacion+"');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
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
        public DataTable BuscarRegistro(string user, string cliente, int referencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT llamadas.idllamada AS ID, concat_ws(' ', usuario.nombre, usuario.apellido) as Usuario, cliente.nombre AS Cliente, producto.referencia AS Referencia, llamadas.problema AS Problema, llamadas.observacion AS Observacion, llamadas.fecha AS Fecha FROM llamadas  INNER JOIN usuario ON llamadas.idusuario = usuario.id_user INNER JOIN cliente ON llamadas.idcliente = cliente.id_cliente INNER JOIN producto ON llamadas.referencia = producto.referencia where(cliente.nombre LIKE CONCAT('%', @Cliente, '%')) AND(producto.referencia LIKE CONCAT('%', @Referencia, '%')) AND((usuario.nombre LIKE CONCAT('%', @Usuario, '%')) OR(usuario.apellido LIKE CONCAT('%', @Usuario, '%'))); ";
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Cliente", cliente);
            comando.Parameters.AddWithValue("@Referencia", referencia);

            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            conexion.CerrarConexion();

            return tabla;
        }

    }
}
                              