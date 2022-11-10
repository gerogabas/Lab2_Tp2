using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2TP2
{
    public partial class FormCargaPropiedad : Form
    {
        public FormCargaPropiedad()
        {
            InitializeComponent();
        }

        private void rbHotel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHotel.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            if (rbCasa.Checked)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
