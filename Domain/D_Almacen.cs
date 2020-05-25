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
    public class D_Almacen
    {
        private DA_Almacen objAlmacen = new DA_Almacen();

        public DataTable MostrarAlmacen()
        {
            DataTable tabla = new DataTable();
            tabla = objAlmacen.MostrarAlmacen();

            return tabla;
        }

        public void InsertarAlmacen(string referencia, string lugar, string nota)
        {
            objAlmacen.InsertarAlmacen(Convert.ToInt32(referencia), lugar, nota);
        }
        public DataTable BuscarAlmacen(string referencia, string lugar)
        {
            DataTable tabla = new DataTable();
            tabla = objAlmacen.BuscarAlmacen(Convert.ToInt32(referencia), lugar);

            return tabla;
        }
    }
}
