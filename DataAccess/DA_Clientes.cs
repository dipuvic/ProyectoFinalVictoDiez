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
            comando.CommandText = "SELECT id_cliente AS Código ,nombre AS Nombre,nif AS NIF,calle AS Calle,municipio AS Municipio,provincia AS Provincia,codpostal AS CP,telf AS Teléfono,email AS Email FROM cliente;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarClientes(string nombre, string nif, string calle, string municipio, string provincia, string codpostal, int telf, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO cliente (nombre,nif,calle,municipio,provincia,codpostal,telf,email) VALUES('" + nombre + "','" + nif + "','" + calle + "','"+municipio+"','"+provincia+"','"+codpostal+"',"+telf+",'"+email+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EditarCliente(int idcliente, string nombre, string nif, string calle, string municipio, string provincia, string codpostal, int telf, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText= "UPDATE cliente SET nombre='" + nombre + "', nif='" + nif + "', calle='"+calle+"', municipio='"+municipio+"',provincia='"+provincia+"',codpostal='"+codpostal+"',telf="+telf+",email='"+email+"' WHERE id_cliente = "+idcliente+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarCliente(string nombre, string municipio, string provincia, string codpostal)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT id_cliente AS Código ,nombre AS Nombre,nif AS NIF,calle AS Calle,municipio AS Municipio,provincia AS Provincia,codpostal AS CP, telf AS Teléfono,email AS Email FROM cliente WHERE (cliente.nombre LIKE CONCAT('%', @Nombre, '%')) AND (cliente.municipio LIKE CONCAT('%', @Municipio, '%')) AND (cliente.provincia LIKE CONCAT('%', @Provincia, '%')) AND (cliente.codpostal LIKE CONCAT('%', @CP, '%'));";
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Municipio", municipio);
            comando.Parameters.AddWithValue("@Provincia", provincia);
            comando.Parameters.AddWithValue("@Cp", codpostal);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }


    }
}
