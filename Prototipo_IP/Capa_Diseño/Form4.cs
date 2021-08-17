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
    public partial class Form4 : Form
    {
        clsControlador logi = new clsControlador();
        public Form4()
        {
            InitializeComponent();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
