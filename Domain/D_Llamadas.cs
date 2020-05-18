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


        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.MostrarProductos();

            return tabla;
        }

        public DataTable BuscarRef(string referencia)
        {
            DataTable tabla = new DataTable();
            tabla = objLlamadas.BuscarRef(Convert.ToInt32(referencia));

            return tabla;
        }
    }
}
