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
    public class DA_Proveedor
    {
        private ConnectionToMySql conexion = new ConnectionToMySql();

        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarProveedores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT id_proveedor AS Código ,nombre AS Nombre,nif AS NIF,municipio AS Municipio,provincia AS Provincia,pais AS País, calle AS Calle,cp AS CP,email AS Email, telf AS Teléfono FROM proveedor;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProveedor(string nombre, int nif, string municipio, string provincia, string pais, string calle, string cp, string email , int telf)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO proveedor (nombre,nif,municipio,provincia,pais,calle,cp,email,telf) VALUES('" + nombre + "'," + nif + ",'" + municipio + "','" + provincia + "','"+pais+"', '"+calle+"','" + cp + "','" + email + "'," + telf + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EditarProveedor(int idproveedor, string nombre, int nif, string municipio, string provincia, string pais, string calle, string cp, string email, int telf)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE proveedor SET nombre='" + nombre + "', nif=" + nif + ",municipio='" + municipio + "',provincia='" + provincia + "',pais='" + pais + "', calle='" + calle + "',cp='" + cp + "',email='" + email + "' ,telf=" + telf + " WHERE id_proveedor = " + idproveedor + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }



    }
}
