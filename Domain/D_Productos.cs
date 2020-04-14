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
        public void InsertarProducto(string descripcion, string precio)
        {
            DA_Productos objetoDA = new DA_Productos();
            objetoDA.InsertarProducto(descripcion, Convert.ToDouble(precio));
        }

        

    }
}
