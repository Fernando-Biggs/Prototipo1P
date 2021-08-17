using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Logica;

namespace Capa_Diseño
{
    public partial class Form11 : Form
    {
        clsControlador logi = new clsControlador();
        public Form11()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


       /*     if (logi.insertar_compras_detalle(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
         */
       
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
