using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Coche
        {
        public DateTime Fecha;
        public int Precio { get; set; }
        public string Patente { get; set; }
        public string Vehiculo { get; set; }
        public string Marca { get; set; }

        public DataTable DT { get; set; } = new DataTable();

        public Coche()
            {
            DT.TableName = "Vehiculos";
            DT.Columns.Add("Precio", typeof(int));
            DT.Columns.Add("Patente", typeof(string));
            DT.Columns.Add("Tipo de vehiculo", typeof(string));
            DT.Columns.Add("Marca", typeof(string));

            LeerDT();

            }
        public bool CargarVehiculo(Coche vehiculos)
            {
                {
                bool res = false;
                if (!Validar(vehiculos))
                    {

                    DT.Rows.Add();
                    int i = DT.Rows.Count - 1;

                    DT.Rows[i]["Patente"] = Patente;
                    DT.Rows[i]["Precio"] = Precio;
                    DT.Rows[i]["Tipo de vehiculo"] = Vehiculo;
                    DT.Rows[i]["Marca"] = Marca;


                    DT.WriteXml("Vehiculos.xml");

                    res = true;
                    }
                return res;

                }


            }
        private void LeerDT()
            {
            if (System.IO.File.Exists("Vehiculos.xml"))
                {
                DT.ReadXml("Vehiculos.xml");
                }
            }

        public int BuscarFila(string vehiculo)
            {
            int fila = -1;

            for (int i = 0; i < DT.Rows.Count; i++)
                {
                if (DT.Rows[i]["Patente"].ToString() == vehiculo)
                    {
                    fila = i;
                    break;
                    }
                }
            return fila;
            }
        private bool Validar(Coche veh)
            {
            bool res = false;
            int fila = BuscarFila(Patente);

            if (fila != -1)
                {
                res = true;
                }

            return res;
            }
        }
    }
