namespace EjemploDetalle.Consulta
{
    partial class ReporEstudiantes
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
            this.EstudiantesreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // EstudiantesreportViewer
            // 
            this.EstudiantesreportViewer.Location = new System.Drawing.Point(-1, 0);
            this.EstudiantesreportViewer.Name = "EstudiantesreportViewer";
            this.EstudiantesreportViewer.Size = new System.Drawing.Size(526, 305);
            this.EstudiantesreportViewer.TabIndex = 0;
            // 
            // ReporEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 302);
            this.Controls.Add(this.EstudiantesreportViewer);
            this.Name = "ReporEstudiantes";
            this.Text = "ReporEstudiantes";
            this.Load += new System.EventHandler(this.ReporEstudiantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer EstudiantesreportViewer;
    }
}