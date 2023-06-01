using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;


namespace VentaDeVehiculosFinal
    {
    public partial class Form1 :Form
        {
        Coche instancia = new Coche();
        public Form1()
            {
            InitializeComponent();
            dataGridView1.DataSource = instancia.DT;
            }

        private void agregarBtn_Click(object sender, EventArgs e)
            {
            instancia.Fecha = dateTimePicker1.Value;
            instancia.Patente = textBox1.Text;
            instancia.Precio = Convert.ToInt32(textBox2.Text);
            instancia.Vehiculo = textBox3.Text;
            instancia.Marca = textBox4.Text;
            instancia.CargarVehiculo(instancia);   
            }

        private void borrarBtn_Click(object sender, EventArgs e)
            {
            int i = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(i);
            }
        }
    }
