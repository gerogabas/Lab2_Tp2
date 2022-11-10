
namespace Labo2TP2
{
    partial class FormCargaPropiedad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.numNroProp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSimple = new System.Windows.Forms.NumericUpDown();
            this.numDobles = new System.Windows.Forms.NumericUpDown();
            this.numTriples = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3estrellas = new System.Windows.Forms.RadioButton();
            this.rb2estrellas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCamas = new System.Windows.Forms.NumericUpDown();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMascota = new System.Windows.Forms.CheckBox();
            this.cbDesayuno = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.cbLimpieza = new System.Windows.Forms.CheckBox();
            this.cbPileta = new System.Windows.Forms.CheckBox();
            this.cbCochera = new System.Windows.Forms.CheckBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNroProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDobles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriples)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro de Propiedad";
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Checked = true;
            this.rbHotel.Location = new System.Drawing.Point(255, 13);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(50, 17);
            this.rbHotel.TabIndex = 2;
            this.rbHotel.TabStop = true;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            this.rbHotel.CheckedChanged += new System.EventHandler(this.rbHotel_CheckedChanged);
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(255, 37);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(49, 17);
            this.rbCasa.TabIndex = 3;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(121, 12);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 4;
            // 
            // numNroProp
            // 
            this.numNroProp.Location = new System.Drawing.Point(121, 37);
            this.numNroProp.Name = "numNroProp";
            this.numNroProp.Size = new System.Drawing.Size(100, 20);
            this.numNroProp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hab. Simples";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hab. Dobles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hab. Triples";
            // 
            // numSimple
            // 
            this.numSimple.Location = new System.Drawing.Point(99, 46);
            this.numSimple.Name = "numSimple";
            this.numSimple.Size = new System.Drawing.Size(100, 20);
            this.numSimple.TabIndex = 9;
            // 
            // numDobles
            // 
            this.numDobles.Location = new System.Drawing.Point(99, 72);
            this.numDobles.Name = "numDobles";
            this.numDobles.Size = new System.Drawing.Size(100, 20);
            this.numDobles.TabIndex = 10;
            // 
            // numTriples
            // 
            this.numTriples.Location = new System.Drawing.Point(99, 98);
            this.numTriples.Name = "numTriples";
            this.numTriples.Size = new System.Drawing.Size(100, 20);
            this.numTriples.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3estrellas);
            this.groupBox1.Controls.Add(this.rb2estrellas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numDobles);
            this.groupBox1.Controls.Add(this.numTriples);
            this.groupBox1.Controls.Add(this.numSimple);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Hotel";
            // 
            // rb3estrellas
            // 
            this.rb3estrellas.AutoSize = true;
            this.rb3estrellas.Location = new System.Drawing.Point(99, 19);
            this.rb3estrellas.Name = "rb3estrellas";
            this.rb3estrellas.Size = new System.Drawing.Size(61, 17);
            this.rb3estrellas.TabIndex = 13;
            this.rb3estrellas.Text = "★★★";
            this.rb3estrellas.UseVisualStyleBackColor = true;
            // 
            // rb2estrellas
            // 
            this.rb2estrellas.AutoSize = true;
            this.rb2estrellas.Checked = true;
            this.rb2estrellas.Location = new System.Drawing.Point(21, 19);
            this.rb2estrellas.Name = "rb2estrellas";
            this.rb2estrellas.Size = new System.Drawing.Size(49, 17);
            this.rb2estrellas.TabIndex = 12;
            this.rb2estrellas.TabStop = true;
            this.rb2estrellas.Text = "★★";
            this.rb2estrellas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCamas);
            this.groupBox2.Controls.Add(this.numDias);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbMascota);
            this.groupBox2.Controls.Add(this.cbDesayuno);
            this.groupBox2.Controls.Add(this.cbWifi);
            this.groupBox2.Controls.Add(this.cbLimpieza);
            this.groupBox2.Controls.Add(this.cbPileta);
            this.groupBox2.Controls.Add(this.cbCochera);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(255, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 135);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Casa";
            // 
            // numCamas
            // 
            this.numCamas.Location = new System.Drawing.Point(87, 44);
            this.numCamas.Name = "numCamas";
            this.numCamas.Size = new System.Drawing.Size(97, 20);
            this.numCamas.TabIndex = 9;
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(87, 19);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(97, 20);
            this.numDias.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cant Camas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dias Minimos";
            // 
            // cbMascota
            // 
            this.cbMascota.AutoSize = true;
            this.cbMascota.Location = new System.Drawing.Point(170, 101);
            this.cbMascota.Name = "cbMascota";
            this.cbMascota.Size = new System.Drawing.Size(72, 17);
            this.cbMascota.TabIndex = 5;
            this.cbMascota.Text = "Mascotas";
            this.cbMascota.UseVisualStyleBackColor = true;
            // 
            // cbDesayuno
            // 
            this.cbDesayuno.AutoSize = true;
            this.cbDesayuno.Location = new System.Drawing.Point(170, 75);
            this.cbDesayuno.Name = "cbDesayuno";
            this.cbDesayuno.Size = new System.Drawing.Size(74, 17);
            this.cbDesayuno.TabIndex = 4;
            this.cbDesayuno.Text = "Desayuno";
            this.cbDesayuno.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(87, 101);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(50, 17);
            this.cbWifi.TabIndex = 3;
            this.cbWifi.Text = "Wi-Fi";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // cbLimpieza
            // 
            this.cbLimpieza.AutoSize = true;
            this.cbLimpieza.Location = new System.Drawing.Point(87, 75);
            this.cbLimpieza.Name = "cbLimpieza";
            this.cbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.cbLimpieza.TabIndex = 2;
            this.cbLimpieza.Text = "Limpieza";
            this.cbLimpieza.UseVisualStyleBackColor = true;
            // 
            // cbPileta
            // 
            this.cbPileta.AutoSize = true;
            this.cbPileta.Location = new System.Drawing.Point(6, 101);
            this.cbPileta.Name = "cbPileta";
            this.cbPileta.Size = new System.Drawing.Size(52, 17);
            this.cbPileta.TabIndex = 1;
            this.cbPileta.Text = "Pileta";
            this.cbPileta.UseVisualStyleBackColor = true;
            // 
            // cbCochera
            // 
            this.cbCochera.AutoSize = true;
            this.cbCochera.Location = new System.Drawing.Point(6, 75);
            this.cbCochera.Name = "cbCochera";
            this.cbCochera.Size = new System.Drawing.Size(66, 17);
            this.cbCochera.TabIndex = 0;
            this.cbCochera.Text = "Cochera";
            this.cbCochera.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(328, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(125, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCargaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numNroProp);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.rbCasa);
            this.Controls.Add(this.rbHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCargaPropiedad";
            this.Text = "FormCargaPropiedad";
            ((System.ComponentModel.ISupportInitialize)(this.numNroProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDobles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriples)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbHotel;
        public System.Windows.Forms.RadioButton rbCasa;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.NumericUpDown numNroProp;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numSimple;
        public System.Windows.Forms.NumericUpDown numDobles;
        public System.Windows.Forms.NumericUpDown numTriples;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rb3estrellas;
        public System.Windows.Forms.RadioButton rb2estrellas;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox cbMascota;
        public System.Windows.Forms.CheckBox cbDesayuno;
        public System.Windows.Forms.CheckBox cbWifi;
        public System.Windows.Forms.CheckBox cbLimpieza;
        public System.Windows.Forms.CheckBox cbPileta;
        public System.Windows.Forms.CheckBox cbCochera;
        public System.Windows.Forms.NumericUpDown numCamas;
        public System.Windows.Forms.NumericUpDown numDias;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.Button button1;
    }
}