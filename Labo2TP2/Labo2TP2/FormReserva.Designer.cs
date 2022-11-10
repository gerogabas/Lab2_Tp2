namespace Labo2TP2
{
    partial class FormReserva
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
            this.label5 = new System.Windows.Forms.Label();
            this.numHuespedes = new System.Windows.Forms.NumericUpDown();
            this.numNroHab = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHuespedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNroHab)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Huespedes";
            // 
            // numHuespedes
            // 
            this.numHuespedes.Location = new System.Drawing.Point(15, 27);
            this.numHuespedes.Name = "numHuespedes";
            this.numHuespedes.Size = new System.Drawing.Size(120, 20);
            this.numHuespedes.TabIndex = 11;
            // 
            // numNroHab
            // 
            this.numNroHab.Location = new System.Drawing.Point(15, 66);
            this.numNroHab.Name = "numNroHab";
            this.numNroHab.Size = new System.Drawing.Size(120, 20);
            this.numNroHab.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Habitacion Nro (solo hotel)";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(15, 105);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cliente";
            // 
            // butReserva
            // 
            this.butReserva.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butReserva.Location = new System.Drawing.Point(42, 132);
            this.butReserva.Name = "butReserva";
            this.butReserva.Size = new System.Drawing.Size(75, 23);
            this.butReserva.TabIndex = 17;
            this.butReserva.Text = "Continuar";
            this.butReserva.UseVisualStyleBackColor = true;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 163);
            this.Controls.Add(this.butReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNroHab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numHuespedes);
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            ((System.ComponentModel.ISupportInitialize)(this.numHuespedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNroHab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numHuespedes;
        public System.Windows.Forms.NumericUpDown numNroHab;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbCliente;
        public System.Windows.Forms.Button butReserva;
        public System.Windows.Forms.Label label2;
    }
}