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
    public class D_Equipo
    {
        private DA_Equipo objetoDA = new DA_Equipo();


        public DataTable ListarCargos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.ListarCargos();

            return tabla;
        }


        public DataTable MostrarEquipo()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.MostrarEquipo();

            return tabla;
        }

        public void InsertarUsuario(string idcargo, string login, string password, string nombre, string apellido, string telf, string email)
        {
            objetoDA.InsertarUsuario(Convert.ToInt32(idcargo), login, password, nombre, apellido, Convert.ToInt32(telf), email);
        }
        public void EditarUsuario(string iduser, string idcargo, string login, string password, string nombre, string apellido, string telf, string email)
        {
            objetoDA.EditarUsuario(Convert.ToInt32(iduser), Convert.ToInt32(idcargo), login, password, nombre, apellido, Convert.ToInt32(telf), email);
        }

        public void EliminarUsuario(string iduser)
        {
            objetoDA.EliminarUsuario(Convert.ToInt32(iduser));
        }

        public DataTable BuscarUsuario(string nombre, string apellido, string cargo, string email)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.BuscarUsuario(nombre, apellido, cargo, email);

            return tabla;
        }
    }
}
