namespace CieguitoVolador
{
    partial class frmPantallaPrincipal
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
            this.rtbAlumnos = new System.Windows.Forms.RichTextBox();
            this.rtbProfesores = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbAlumnos
            // 
            this.rtbAlumnos.Location = new System.Drawing.Point(81, 59);
            this.rtbAlumnos.Name = "rtbAlumnos";
            this.rtbAlumnos.Size = new System.Drawing.Size(180, 281);
            this.rtbAlumnos.TabIndex = 0;
            this.rtbAlumnos.Text = "";
            // 
            // rtbProfesores
            // 
            this.rtbProfesores.Location = new System.Drawing.Point(466, 59);
            this.rtbProfesores.Name = "rtbProfesores";
            this.rtbProfesores.Size = new System.Drawing.Size(180, 281);
            this.rtbProfesores.TabIndex = 1;
            this.rtbProfesores.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbProfesores);
            this.Controls.Add(this.rtbAlumnos);
            this.Name = "frmPantallaPrincipal";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmPantallaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAlumnos;
        private System.Windows.Forms.RichTextBox rtbProfesores;
        private System.Windows.Forms.Label label1;
    }
}