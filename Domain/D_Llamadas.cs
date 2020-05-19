using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
using Common;

namespace Domain
{
    public class D_Llamadas
    {
        private DA_Llamadas objLlamadas = new DA_Llamadas();


        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.ListarUsuarios();
            return tabla;
        }
        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.ListarClientes();
            return tabla;
        }


        public DataTable MostrarRegistros()
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.MostrarRegistros();

            return tabla;
        }

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.MostrarProductos();

            return tabla;
        }


        public void InsertarLlamada(string idusuario, string atiende, string idcliente, string referencia, string problema, string observacion)
        {
            objLlamadas.InsertarLlamada(Convert.ToInt32(idusuario), Convert.ToInt32(atiende), Convert.ToInt32(idcliente),Convert.ToInt32(referencia), problema, observacion);
        }


        public DataTable BuscarRef(string referencia)
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.BuscarRef(Convert.ToInt32(referencia));

            return tabla;
        }

        public DataTable BuscarRegistro(string user, string cliente, string referencia)
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.BuscarRegistro(user, cliente, Convert.ToInt32(referencia));

            return tabla;
        }
    }
}
