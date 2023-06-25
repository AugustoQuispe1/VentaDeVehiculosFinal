using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Clases;


namespace CapaDatos
	{
	public class AdminVehiculos : DatosConexion
		{
		public int abmVehiculos(string accion, Coche objVehicles)
			{
			int resultado = -1; //controlar que se realice la operacion
			string orden = string.Empty;

			if (accion == "alta") //agregar
				orden = "insert into Vehiculos values (" + objVehicles.Codigo + ",'" + objVehicles.Precio + ",'" + objVehicles.Patente + ",'" + objVehicles.Tipo_de_vehiculo + ",'" + objVehicles.Marca + ",'" + objVehicles.Fecha + "');";

			//if (accion == "baja") //borrar
				//orden = $"DELETE FROM Vehiculos='"

			if (accion == "modificar") //modificar
				orden = "update Vehiculos set Precio='" + objVehicles.Precio;


			OleDbCommand cmd = new OleDbCommand(orden, conexion);
			try
				{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
				}
			catch (Exception e)
				{
				throw new Exception($"Error al tratar de guardar,borrar o modificar de Vehiculos", e);


			}
			finally
				{
				Cerrarconexion();
				cmd.Dispose();
				}
			return resultado;




			}

		public DataSet listadoVehiculos (string cual)
			{
			string orden = string.Empty;

			if (cual == "Todos")
				orden = "select * from Vehiculos where Codigo = " + int.Parse(cual) + ";";
			else
				orden = "select * from Vehiculos;";


			OleDbCommand cmd = new OleDbCommand (orden, conexion);

			DataSet ds = new DataSet();
			OleDbDataAdapter da = new OleDbDataAdapter();

			try
				{
				Abrirconexion();
				cmd.ExecuteNonQuery();
				da.SelectCommand = cmd;
				da.Fill(ds);
				}
			catch (Exception e)
				{
				throw new Exception("Error al listar los vehiculos", e);
				}
			finally
				{
				Cerrarconexion();
				cmd.Dispose();
				}
			return ds;
			}
			

		}
	}
