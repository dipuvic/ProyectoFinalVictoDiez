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
    public class DA_Clientes 
    {
        private ConnectionToMySql conexion =  new ConnectionToMySql();

        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarClientes(){
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT nombre,nif,calle,municipio,provincia,codpostal,telf,email FROM cliente;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarClientes(string nombre, string nif, string calle, string municipio, string provincia, string codpostal, int telf, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO cliente VALUES('" + nombre + "','" + nif + "','" + calle + "','" + municipio + "','" + provincia + "','" + codpostal + "'," + telf + ",'" + email + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        

    }
}
