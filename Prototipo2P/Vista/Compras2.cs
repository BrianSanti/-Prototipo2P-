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
    public partial class Compras2 : Form
    {
        ClassControlador metodos = new ClassControlador();
        public Compras2()
        {
            InitializeComponent();
        }

        private void Guardar2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodos.Insertar_comprasdetalle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
         
        }
    }
}
