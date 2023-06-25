using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Clases;

namespace CapaNegocios
{
    public class NegVehiculos
    {
        AdminVehiculos DatosObjVehiculo = new AdminVehiculos();

        public int abmVehiculos (string accion, Coche objVehicles)
            {
            return DatosObjVehiculo.abmVehiculos(accion, objVehicles);
            }

		public DataSet listadoVehiculos(string cual)
            {
            return DatosObjVehiculo.listadoVehiculos (cual);
            }


	}
}
