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
        public void InsertarProducto(string descripcion, string precio)
        {
            //DA_Productos objetoDA = new DA_Productos();
            objetoDA.InsertarProducto(descripcion, precio);
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
