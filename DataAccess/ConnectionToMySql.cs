using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Common.Cache;

namespace DataAccess
{
    public class ConnectionToMySql
    {
        private readonly string connectionString;
        public ConnectionToMySql()
        {
            connectionString = "Server=127.0.0.1; DataBase=dh; User=root ; password=";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


        ///////////////////////////////////////// Otro método para Abrir/Cerrar - Conexión Base Datos

        private readonly MySqlConnection conexion = new MySqlConnection ("Server=127.0.0.1; DataBase=dh;User=root; Password=");

        public MySqlConnection AbrirConexion()
        {
            if(conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public MySqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }

            return conexion;
        }
    }
}
