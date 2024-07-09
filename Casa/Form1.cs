using Casa.Casa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa
{
    public partial class Form1 : Form
    {
        casa casa = new casa();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            casa.Pintar(cbxColor.Text);
        }

        private void btnCortars_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            casa.Cortarservicio();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            panel1.Enabled= false;
            casa.Vender();
        }

        private void btnHipotecar_Click(object sender, EventArgs e)
        {
            casa.Hipotecar(txtHipoteca.Text);
        }

        private void btnDeshipotecar_Click(object sender, EventArgs e)
        {
            casa.Deshipotecar(txtHipoteca.Text);
        }
    }
}
