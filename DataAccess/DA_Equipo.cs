using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Cache;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DA_Equipo
    {
        private ConnectionToMySql conexion = new ConnectionToMySql();

        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable ListarCargos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT idcargo, cargo FROM cargo;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable MostrarEquipo()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT id_user AS Código, login AS Login, contraseña AS Password, nombre AS Nombre, apellido AS Apellido, telefono AS Teléfono, email AS Email, cargo AS Cargo FROM usuario INNER JOIN cargo ON usuario.idcargo = cargo.idcargo;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarUsuario(int idcargo, string login, string password, string nombre, string apellido, int telf, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO usuario (idcargo,login,contraseña,nombre,apellido,telefono,email) VALUES("+ idcargo +",'" + login + "','" + password + "','" + nombre + "','" + apellido + "'," + telf + ",'" + email + "');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void EditarUsuario(int iduser, int idcargo, string login, string password, string nombre, string apellido, int telf, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE usuario SET idcargo=" + idcargo + ", login='" + login + "', contraseña='"+password+"', nombre='"+nombre+"', apellido='"+apellido+"', telefono="+telf+", email='"+email+"' WHERE id_user="+iduser+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarUsuario(int iduser)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM usuario WHERE id_usuario=" + iduser + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarUsuario(string nombre, string apellido, string cargo, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT id_user AS Código, login AS Login, contraseña AS Password, nombre AS Nombre, apellido AS Apellido, telefono AS Teléfono, email AS Email, cargo AS Cargo FROM usuario INNER JOIN cargo ON usuario.idcargo = cargo.idcargo WHERE usuario.nombre LIKE CONCAT('%', @Nombre, '%') AND usuario.apellido LIKE CONCAT('%', @Apellido, '%') AND cargo.cargo LIKE CONCAT('%', @Cargo, '%') AND usuario.email LIKE CONCAT('%', @Email, '%');";

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Email", email);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

    }
}
