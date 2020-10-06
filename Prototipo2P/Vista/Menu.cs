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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compras usu = new Compras();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventas usu = new Ventas();
            usu.Show();
            this.Hide();
        }
    }
}
