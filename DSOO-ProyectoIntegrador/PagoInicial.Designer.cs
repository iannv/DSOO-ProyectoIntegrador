namespace DSOO_ProyectoIntegrador
{
    partial class PagoInicial
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumInscripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.gbFormaPago = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnGenerarCarnet = new System.Windows.Forms.Button();
            this.gbFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblNumInscripcion
            // 
            this.lblNumInscripcion.AutoSize = true;
            this.lblNumInscripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInscripcion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNumInscripcion.Location = new System.Drawing.Point(97, 145);
            this.lblNumInscripcion.Name = "lblNumInscripcion";
            this.lblNumInscripcion.Size = new System.Drawing.Size(247, 21);
            this.lblNumInscripcion.TabIndex = 2;
            this.lblNumInscripcion.Text = "Ingresar número de inscripción";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Snow;
            this.lblTitulo.Location = new System.Drawing.Point(323, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 28);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Pago Inicial";
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbEfectivo.Location = new System.Drawing.Point(6, 41);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(67, 20);
            this.rbEfectivo.TabIndex = 5;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbTarjeta.Location = new System.Drawing.Point(6, 80);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(60, 20);
            this.rbTarjeta.TabIndex = 6;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // gbFormaPago
            // 
            this.gbFormaPago.Controls.Add(this.rbTarjeta);
            this.gbFormaPago.Controls.Add(this.rbEfectivo);
            this.gbFormaPago.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbFormaPago.Location = new System.Drawing.Point(511, 145);
            this.gbFormaPago.Name = "gbFormaPago";
            this.gbFormaPago.Size = new System.Drawing.Size(144, 128);
            this.gbFormaPago.TabIndex = 7;
            this.gbFormaPago.TabStop = false;
            this.gbFormaPago.Text = "Forma de pago";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(153, 231);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(134, 42);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarCarnet
            // 
            this.btnGenerarCarnet.Enabled = false;
            this.btnGenerarCarnet.Location = new System.Drawing.Point(280, 359);
            this.btnGenerarCarnet.Name = "btnGenerarCarnet";
            this.btnGenerarCarnet.Size = new System.Drawing.Size(243, 36);
            this.btnGenerarCarnet.TabIndex = 9;
            this.btnGenerarCarnet.Text = "GENERAR CARNET";
            this.btnGenerarCarnet.UseVisualStyleBackColor = true;
            // 
            // PagoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerarCarnet);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.gbFormaPago);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumInscripcion);
            this.Controls.Add(this.textBox1);
            this.Name = "PagoInicial";
            this.Text = "PagoInicial";
            this.Load += new System.EventHandler(this.PagoInicial_Load);
            this.gbFormaPago.ResumeLayout(false);
            this.gbFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumInscripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.GroupBox gbFormaPago;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnGenerarCarnet;
    }
}