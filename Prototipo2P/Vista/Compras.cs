using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista
{
   
    public partial class Compras : Form
    { 
        ClassControlador metodos = new ClassControlador();

        public Compras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodos.Insertar_comprasencabezado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras2 usu = new Compras2();
            usu.Show();

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas usu = new Ventas();
            usu.Show();
        }
    }
}
