namespace WindowsFormsApplication5
{
    partial class menuPrincipal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnMonedero = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.bntServicios = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pacientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consultas Médicas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monedero Electrónico ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inventario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.mi_farmacia;
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 141);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventario.Image = global::WindowsFormsApplication5.Properties.Resources.inventario;
            this.btnInventario.Location = new System.Drawing.Point(541, 337);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(186, 146);
            this.btnInventario.TabIndex = 10;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultas.Image = global::WindowsFormsApplication5.Properties.Resources.consultas3;
            this.btnConsultas.Location = new System.Drawing.Point(298, 337);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(186, 146);
            this.btnConsultas.TabIndex = 8;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnMonedero
            // 
            this.btnMonedero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMonedero.Image = global::WindowsFormsApplication5.Properties.Resources.monedero;
            this.btnMonedero.Location = new System.Drawing.Point(59, 337);
            this.btnMonedero.Name = "btnMonedero";
            this.btnMonedero.Size = new System.Drawing.Size(164, 146);
            this.btnMonedero.TabIndex = 6;
            this.btnMonedero.UseVisualStyleBackColor = false;
            this.btnMonedero.Click += new System.EventHandler(this.btnMonedero_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnPacientes.Image = global::WindowsFormsApplication5.Properties.Resources.paciente3;
            this.btnPacientes.Location = new System.Drawing.Point(541, 166);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(186, 147);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // bntServicios
            // 
            this.bntServicios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntServicios.Image = global::WindowsFormsApplication5.Properties.Resources.Servicios;
            this.bntServicios.Location = new System.Drawing.Point(298, 166);
            this.bntServicios.Name = "bntServicios";
            this.bntServicios.Size = new System.Drawing.Size(186, 147);
            this.bntServicios.TabIndex = 2;
            this.bntServicios.Text = "\r\n";
            this.bntServicios.UseVisualStyleBackColor = false;
            this.bntServicios.Click += new System.EventHandler(this.bntServicios_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVentas.Image = global::WindowsFormsApplication5.Properties.Resources.ventas;
            this.btnVentas.Location = new System.Drawing.Point(59, 166);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(164, 147);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(552, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 57);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(869, 597);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMonedero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntServicios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVentas);
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMonedero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}