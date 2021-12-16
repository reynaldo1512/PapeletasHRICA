using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
   public class TrabajadorNegocio

    {
        TrabajadorDao data = new TrabajadorDao();
        TrabajadorModel trabajador = new TrabajadorModel();

        public DataTable ListarTrabajadores (int id_departamento)
        {
            TrabajadorNegocio trabajador = new TrabajadorNegocio();
            return data.ListarTrabajador(id_departamento);
        }



        public DataTable Buscartrabajador(string DNI,int id_departamento)
        {

            trabajador.DNI = DNI;
            trabajador.id_departamento = id_departamento;
            return data.BuscarTrabajador(trabajador);
        }


        public void AgregarTrabajador(TrabajadorModel trabajador)
        {
            data.AgregarTrabajador(trabajador);
        }

        public void EditarTrabajador(TrabajadorModel trabajador)
        {
            data.EditarTrabajador(trabajador);
        }



    }
}
