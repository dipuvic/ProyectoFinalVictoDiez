using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using Common.Cache;

namespace Domain
{
    public class D_Clientes
    {
        private DA_Clientes objetoDA = new DA_Clientes();

        public DataTable MostrarClietes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.MostrarClientes();

            return tabla;
        }

        public void InsertarCliente(string nombre, string nif, string calle, string municipio, string provincia, string codpostal, string telf, string email)
        {
            objetoDA.InsertarClientes(nombre, nif, calle, municipio, provincia, codpostal, Convert.ToInt32(telf),email);
        }
        
        public void EditarCliente(string nombre, string nif, string calle, string municipio, string provincia, string codpostal, string telf, string email)
        {
            objetoDA.EditarCliente(nombre, nif, calle, municipio, provincia, codpostal, Convert.ToInt32(telf), email);
        }

    }
}
