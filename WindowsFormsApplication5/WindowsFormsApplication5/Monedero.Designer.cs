namespace WindowsFormsApplication5
{
    partial class Monedero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monedero));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMonedero = new System.Windows.Forms.Label();
            this.txtmonedero = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtpuntosMon = new System.Windows.Forms.TextBox();
            this.lblpuntosMon = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtgMonedero = new System.Windows.Forms.DataGridView();
            this.picbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonedero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(475, 180);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMonedero
            // 
            this.lblMonedero.AutoSize = true;
            this.lblMonedero.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedero.Location = new System.Drawing.Point(12, 140);
            this.lblMonedero.Name = "lblMonedero";
            this.lblMonedero.Size = new System.Drawing.Size(217, 25);
            this.lblMonedero.TabIndex = 1;
            this.lblMonedero.Text = "Numero de monedero";
            // 
            // txtmonedero
            // 
            this.txtmonedero.Location = new System.Drawing.Point(235, 145);
            this.txtmonedero.Name = "txtmonedero";
            this.txtmonedero.Size = new System.Drawing.Size(240, 20);
            this.txtmonedero.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(475, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(475, 338);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 44);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtpuntosMon
            // 
            this.txtpuntosMon.Location = new System.Drawing.Point(105, 180);
            this.txtpuntosMon.Name = "txtpuntosMon";
            this.txtpuntosMon.Size = new System.Drawing.Size(100, 20);
            this.txtpuntosMon.TabIndex = 7;
            // 
            // lblpuntosMon
            // 
            this.lblpuntosMon.AutoSize = true;
            this.lblpuntosMon.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntosMon.Location = new System.Drawing.Point(12, 176);
            this.lblpuntosMon.Name = "lblpuntosMon";
            this.lblpuntosMon.Size = new System.Drawing.Size(87, 25);
            this.lblpuntosMon.TabIndex = 6;
            this.lblpuntosMon.Text = "Puntos: ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApplication5.Properties.Resources.regresar;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(430, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 59);
            this.button4.TabIndex = 13;
            this.button4.Text = "Regresar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(475, 232);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 46);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(475, 399);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 44);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(177, 508);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 16;
            // 
            // dtgMonedero
            // 
            this.dtgMonedero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMonedero.Location = new System.Drawing.Point(17, 208);
            this.dtgMonedero.Name = "dtgMonedero";
            this.dtgMonedero.Size = new System.Drawing.Size(430, 235);
            this.dtgMonedero.TabIndex = 17;
            this.dtgMonedero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMonedero_CellClick);
            this.dtgMonedero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMonedero_CellContentClick);
            // 
            // picbxLogo
            // 
            this.picbxLogo.Image = global::WindowsFormsApplication5.Properties.Resources.mi_farmacia2;
            this.picbxLogo.Location = new System.Drawing.Point(134, 6);
            this.picbxLogo.Name = "picbxLogo";
            this.picbxLogo.Size = new System.Drawing.Size(304, 131);
            this.picbxLogo.TabIndex = 18;
            this.picbxLogo.TabStop = false;
            // 
            // Monedero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(603, 550);
            this.Controls.Add(this.picbxLogo);
            this.Controls.Add(this.dtgMonedero);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtpuntosMon);
            this.Controls.Add(this.lblpuntosMon);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmonedero);
            this.Controls.Add(this.lblMonedero);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monedero";
            this.Text = "Monedero";
            this.Load += new System.EventHandler(this.Monedero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonedero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMonedero;
        private System.Windows.Forms.TextBox txtmonedero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtpuntosMon;
        private System.Windows.Forms.Label lblpuntosMon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dtgMonedero;
        private System.Windows.Forms.PictureBox picbxLogo;
    }
}