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
    public class D_Productos
    {
        private DA_Productos objetoDA = new DA_Productos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.MostrarProductos();

            return tabla;
        }

        public DataTable ListarCategorias()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.ListarCategorias();

            return tabla;
        }

        public void InsertarProducto(string idcat, string descripcion, string precio)
        {
            //DA_Productos objetoDA = new DA_Productos();
            string indice = idcat;
            int sumaindice = Convert.ToInt32(indice) + 1;

            objetoDA.InsertarProducto(sumaindice, descripcion, precio);
        }
        public void EditarProducto(string referencia, string descripcion, string precio)
        {
            
            objetoDA.EditarProducto(Convert.ToInt32(referencia), descripcion, precio);
        }
        public void EliminarProducto(string referencia)
        {
            objetoDA.EliminarProducto(Convert.ToInt32(referencia));
        }
        public void BuscarProducto(string referencia, string descripcion)
        {
            objetoDA.BuscarProducto(Convert.ToInt32(referencia), descripcion);
        }
    }
}
