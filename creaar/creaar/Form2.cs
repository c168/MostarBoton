using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creaar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "1234")
            {
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("ingrese la contraseña");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }
    }
}
