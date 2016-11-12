namespace EjemploDetalle.Consulta
{
    partial class ReporGrupos
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
            this.GruposreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // GruposreportViewer
            // 
            this.GruposreportViewer.Location = new System.Drawing.Point(3, -1);
            this.GruposreportViewer.Name = "GruposreportViewer";
            this.GruposreportViewer.Size = new System.Drawing.Size(603, 323);
            this.GruposreportViewer.TabIndex = 0;
            // 
            // ReporGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 334);
            this.Controls.Add(this.GruposreportViewer);
            this.Name = "ReporGrupos";
            this.Text = "ReporGrupos";
            this.Load += new System.EventHandler(this.ReporGrupos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer GruposreportViewer;
    }
}