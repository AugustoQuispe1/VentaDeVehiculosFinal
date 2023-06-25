using CapaNegocios;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VentaDeVehiculosFinal
    {
    public partial class Form1 :Form
        {
        
        Coche NuevoCoche;
        NegVehiculos ObjNegVehiculo = new NegVehiculos();
        public Form1()
            {

            InitializeComponent();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[1].HeaderText = "Precio";
            dataGridView1.Columns[2].HeaderText = "Patente";
            dataGridView1.Columns[3].HeaderText = "Tipo_de_vehiculo";
            dataGridView1.Columns[4].HeaderText = "Marca";
            dataGridView1.Columns[5].HeaderText = "Fecha";
			dataGridView1.Columns[0].Width = 100;
			dataGridView1.Columns[1].Width = 100;
			dataGridView1.Columns[2].Width = 100;
			dataGridView1.Columns[3].Width = 100;
			dataGridView1.Columns[4].Width = 100;
			dataGridView1.Columns[5].Width = 100;


			LlenarDGV();
            }

        private void LlenarDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = new DataSet();
            ds = ObjNegVehiculo.listadoVehiculos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
                foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5]);
                    }
           else
                MessageBox.Show("No hay vehiculos cargados en el sistema");



		}


        private void agregarBtn_Click(object sender, EventArgs e)
            {
            int nGrabados = -1;
            CargarCoche();

            nGrabados = ObjNegVehiculo.abmVehiculos("Alta", NuevoCoche);
            if (nGrabados == -1)
                {
                MessageBox.Show("No se pudo cargar el vehiculo en el sistema");
                }
            else
                {
                MessageBox.Show("Se cargo correctamente el vehiculo");
                LlenarDGV();
                }
            }

        private void CargarCoche()
            {

            }


        private void borrarBtn_Click(object sender, EventArgs e)
            {

            }
        }
    }
