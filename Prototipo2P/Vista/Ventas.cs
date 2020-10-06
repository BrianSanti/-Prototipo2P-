using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Ventas : Form
    {

        ClassControlador metodos = new ClassControlador();
        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodos.Insertar_ventasencabezado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            Ventas2 usu = new Ventas2();
            usu.Show();
            this.Hide();
        }
    }
}
