﻿namespace Casa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtHipoteca = new System.Windows.Forms.TextBox();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtNiveles = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.btnPintar = new System.Windows.Forms.Button();
            this.btnCortars = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnHipotecar = new System.Windows.Forms.Button();
            this.btnDeshipotecar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niveles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dueño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Servicios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hipoteca";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(122, 35);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtHipoteca
            // 
            this.txtHipoteca.Location = new System.Drawing.Point(122, 254);
            this.txtHipoteca.Name = "txtHipoteca";
            this.txtHipoteca.Size = new System.Drawing.Size(100, 22);
            this.txtHipoteca.TabIndex = 8;
            // 
            // txtDueño
            // 
            this.txtDueño.Location = new System.Drawing.Point(122, 169);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(100, 22);
            this.txtDueño.TabIndex = 9;
            // 
            // txtNiveles
            // 
            this.txtNiveles.Location = new System.Drawing.Point(122, 82);
            this.txtNiveles.Name = "txtNiveles";
            this.txtNiveles.Size = new System.Drawing.Size(100, 22);
            this.txtNiveles.TabIndex = 10;
            this.txtNiveles.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeshipotecar);
            this.panel1.Controls.Add(this.btnHipotecar);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.btnCortars);
            this.panel1.Controls.Add(this.btnPintar);
            this.panel1.Controls.Add(this.cbxColor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNiveles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDueño);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHipoteca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(33, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 388);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(29, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 43);
            this.panel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agua";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Luz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Gas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Verde",
            "Blanco",
            "Negro"});
            this.cbxColor.Location = new System.Drawing.Point(122, 124);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 24);
            this.cbxColor.TabIndex = 12;
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(416, 46);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(75, 23);
            this.btnPintar.TabIndex = 13;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // btnCortars
            // 
            this.btnCortars.Location = new System.Drawing.Point(416, 97);
            this.btnCortars.Name = "btnCortars";
            this.btnCortars.Size = new System.Drawing.Size(75, 23);
            this.btnCortars.TabIndex = 14;
            this.btnCortars.Text = "CortarServicio";
            this.btnCortars.UseVisualStyleBackColor = true;
            this.btnCortars.Click += new System.EventHandler(this.btnCortars_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(416, 147);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 15;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnHipotecar
            // 
            this.btnHipotecar.Location = new System.Drawing.Point(416, 205);
            this.btnHipotecar.Name = "btnHipotecar";
            this.btnHipotecar.Size = new System.Drawing.Size(75, 23);
            this.btnHipotecar.TabIndex = 16;
            this.btnHipotecar.Text = "Hipotecar";
            this.btnHipotecar.UseVisualStyleBackColor = true;
            this.btnHipotecar.Click += new System.EventHandler(this.btnHipotecar_Click);
            // 
            // btnDeshipotecar
            // 
            this.btnDeshipotecar.Location = new System.Drawing.Point(416, 252);
            this.btnDeshipotecar.Name = "btnDeshipotecar";
            this.btnDeshipotecar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshipotecar.TabIndex = 17;
            this.btnDeshipotecar.Text = "Deshipotecar";
            this.btnDeshipotecar.UseVisualStyleBackColor = true;
            this.btnDeshipotecar.Click += new System.EventHandler(this.btnDeshipotecar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtHipoteca;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.TextBox txtNiveles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeshipotecar;
        private System.Windows.Forms.Button btnHipotecar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCortars;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

