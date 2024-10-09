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
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.Snow;
            this.lblIngresar.Location = new System.Drawing.Point(50, 35);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(33, 16);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "hola";
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
            this.btnRegistro.Location = new System.Drawing.Point(278, 165);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(263, 103);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registrar Cliente";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}