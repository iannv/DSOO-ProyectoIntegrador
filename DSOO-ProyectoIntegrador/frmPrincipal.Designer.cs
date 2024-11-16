namespace DSOO_ProyectoIntegrador
{
    partial class frmPrincipal
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
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnListadoVenc = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.Snow;
            this.lblIngresar.Location = new System.Drawing.Point(50, 35);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(45, 16);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Admin";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(676, 25);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistro.Location = new System.Drawing.Point(173, 102);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(461, 61);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registrar Cliente";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnListadoVenc
            // 
            this.btnListadoVenc.AutoEllipsis = true;
            this.btnListadoVenc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListadoVenc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListadoVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoVenc.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoVenc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListadoVenc.Location = new System.Drawing.Point(173, 307);
            this.btnListadoVenc.Name = "btnListadoVenc";
            this.btnListadoVenc.Size = new System.Drawing.Size(461, 61);
            this.btnListadoVenc.TabIndex = 4;
            this.btnListadoVenc.Text = "Listado de Vencimientos";
            this.btnListadoVenc.UseVisualStyleBackColor = false;
            this.btnListadoVenc.Click += new System.EventHandler(this.btnListadoVenc_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.AutoEllipsis = true;
            this.btnCobrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCobrar.Location = new System.Drawing.Point(173, 206);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(461, 61);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnListadoVenc);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIngresar);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnListadoVenc;
        private System.Windows.Forms.Button btnCobrar;
    }
}