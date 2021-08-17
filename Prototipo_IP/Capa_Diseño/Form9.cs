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
    public partial class Form9 : Form
    {
        clsControlador logi = new clsControlador();
        public Form9()
        {
            InitializeComponent();
        }
   

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }
    }
}
