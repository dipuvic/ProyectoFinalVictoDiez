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

        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select id_user, concat_ws(' ', usuario.nombre, usuario.apellido) as Persona From usuario;";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarRegistroLlamadas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT cargo.cargo as PasaLlamada, concat_ws(' ', usuario.nombre, usuario.apellido) as Atiende, cliente.nombre AS Cliente, producto.referencia AS Referencia, producto.descripcion As Descripción, llamadas.problema AS Problema, llamadas.observacion AS Observación FROM llamadas INNER JOIN cargo ON llamadas.idcargo = cargo.idcargo INNER JOIN usuario ON llamadas.idusuario = usuario.id_user INNER JOIN cliente ON llamadas.idcliente = cliente.id_cliente INNER JOIN llamadas_productos ON llamadas.idllamada = llamadas_productos.idllamada INNER JOIN producto ON llamadas_productos.referencia = producto.referencia; ; ";
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
                              