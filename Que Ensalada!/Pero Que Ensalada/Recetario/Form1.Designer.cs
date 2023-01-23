namespace Recetario
{
    partial class Receta
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
            this.rtbReceta = new System.Windows.Forms.RichTextBox();
            this.btnReceta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbReceta
            // 
            this.rtbReceta.Location = new System.Drawing.Point(12, 12);
            this.rtbReceta.Name = "rtbReceta";
            this.rtbReceta.Size = new System.Drawing.Size(884, 527);
            this.rtbReceta.TabIndex = 0;
            this.rtbReceta.Text = "";
            // 
            // btnReceta
            // 
            this.btnReceta.Location = new System.Drawing.Point(12, 545);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(884, 38);
            this.btnReceta.TabIndex = 1;
            this.btnReceta.Text = "Imprimir Receta";
            this.btnReceta.UseVisualStyleBackColor = true;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 583);
            this.Controls.Add(this.btnReceta);
            this.Controls.Add(this.rtbReceta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReceta;
        private System.Windows.Forms.Button btnReceta;
    }
}
