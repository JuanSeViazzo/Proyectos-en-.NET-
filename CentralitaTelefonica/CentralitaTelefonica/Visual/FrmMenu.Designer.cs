namespace Visual
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_llamada = new System.Windows.Forms.Button();
            this.btn_FacturacionTotal = new System.Windows.Forms.Button();
            this.btn_FacturacionLocal = new System.Windows.Forms.Button();
            this.btn_FacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_llamada
            // 
            this.btn_llamada.Location = new System.Drawing.Point(120, 102);
            this.btn_llamada.Name = "btn_llamada";
            this.btn_llamada.Size = new System.Drawing.Size(222, 62);
            this.btn_llamada.TabIndex = 0;
            this.btn_llamada.Text = "Generar Llamada";
            this.btn_llamada.UseVisualStyleBackColor = true;
            this.btn_llamada.Click += new System.EventHandler(this.btn_llamada_Click);
            // 
            // btn_FacturacionTotal
            // 
            this.btn_FacturacionTotal.Location = new System.Drawing.Point(120, 170);
            this.btn_FacturacionTotal.Name = "btn_FacturacionTotal";
            this.btn_FacturacionTotal.Size = new System.Drawing.Size(222, 62);
            this.btn_FacturacionTotal.TabIndex = 1;
            this.btn_FacturacionTotal.Text = "Facturacion Total";
            this.btn_FacturacionTotal.UseVisualStyleBackColor = true;
            this.btn_FacturacionTotal.Click += new System.EventHandler(this.btn_FacturacionTotal_Click);
            // 
            // btn_FacturacionLocal
            // 
            this.btn_FacturacionLocal.Location = new System.Drawing.Point(120, 238);
            this.btn_FacturacionLocal.Name = "btn_FacturacionLocal";
            this.btn_FacturacionLocal.Size = new System.Drawing.Size(222, 62);
            this.btn_FacturacionLocal.TabIndex = 2;
            this.btn_FacturacionLocal.Text = "Facturacion Local";
            this.btn_FacturacionLocal.UseVisualStyleBackColor = true;
            // 
            // btn_FacturacionProvincial
            // 
            this.btn_FacturacionProvincial.Location = new System.Drawing.Point(120, 306);
            this.btn_FacturacionProvincial.Name = "btn_FacturacionProvincial";
            this.btn_FacturacionProvincial.Size = new System.Drawing.Size(222, 62);
            this.btn_FacturacionProvincial.TabIndex = 3;
            this.btn_FacturacionProvincial.Text = "Facturacion Provincial";
            this.btn_FacturacionProvincial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(120, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 62);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 526);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_FacturacionProvincial);
            this.Controls.Add(this.btn_FacturacionLocal);
            this.Controls.Add(this.btn_FacturacionTotal);
            this.Controls.Add(this.btn_llamada);
            this.Name = "FrmMenu";
            this.Text = "Centralita Telefonica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_llamada;
        private System.Windows.Forms.Button btn_FacturacionTotal;
        private System.Windows.Forms.Button btn_FacturacionLocal;
        private System.Windows.Forms.Button btn_FacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}
