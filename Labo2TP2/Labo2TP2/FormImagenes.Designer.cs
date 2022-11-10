
namespace Labo2TP2
{
    partial class FormImagenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 288);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 288);
            this.Controls.Add(this.label1);
            this.Name = "FormImagenes";
            this.Text = "FormImagenes";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FormImagenes_Scroll);
            this.DoubleClick += new System.EventHandler(this.FormImagenes_DoubleClick);
            this.Enter += new System.EventHandler(this.FormImagenes_Enter);
            this.MouseLeave += new System.EventHandler(this.FormImagenes_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label label1;
    }
}