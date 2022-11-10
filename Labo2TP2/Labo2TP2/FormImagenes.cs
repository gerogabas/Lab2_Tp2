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
    public partial class FormImagenes : Form
    {
        public FormImagenes()
        {
            InitializeComponent();
            label1.ImageIndex = 0;
            this.Width = 300;
            this.Height = 300;
        }
        int indice = 0;
        
        private void label1_Click(object sender, EventArgs e)
        {
            this.Size = imageList1.ImageSize;
            if (indice > imageList1.Images.Count)
                indice = 0;
            else indice++;
            label1.ImageIndex = indice;
        }

        #region Basura
        private void FormImagenes_MouseLeave(object sender, EventArgs e)
        {
        }

        private void FormImagenes_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FormImagenes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FormImagenes_Enter(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
