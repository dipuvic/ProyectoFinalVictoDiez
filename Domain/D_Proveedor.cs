﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using Common.Cache;

namespace Domain
{
    public class D_Proveedor
    {
        private DA_Proveedor objetoDA = new DA_Proveedor();


        public DataTable MostrarProveedores()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.MostrarProveedores();

            return tabla;
        }

        public void InsertarProveedor(string nombre, string nif, string municipio, string provincia, string pais, string calle, string cp, string email, string telf)
        {
            objetoDA.InsertarProveedor(nombre, Convert.ToInt32(nif), municipio, provincia, pais, calle, cp, email, Convert.ToInt32(telf));
        }

        public void EditarProveedor(string idproveedor, string nombre, string nif, string municipio, string provincia, string pais, string calle, string cp, string email, string telf)
        {
            objetoDA.EditarProveedor(Convert.ToInt32(idproveedor),nombre,Convert.ToInt32(nif),municipio,provincia,pais,calle,cp,email,Convert.ToInt32(telf));
        }



    }
}
