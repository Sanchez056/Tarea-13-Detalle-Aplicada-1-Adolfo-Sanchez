namespace EjemploDetalle.Consulta
{
    partial class ConsultaGrupos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsultaGruposdataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.NombreGrupotextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaGruposdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreGrupotextBox);
            this.groupBox1.Controls.Add(this.ConsultaGruposdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(11, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 264);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiantes De Grupo:";
            // 
            // ConsultaGruposdataGridView
            // 
            this.ConsultaGruposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaGruposdataGridView.Location = new System.Drawing.Point(19, 46);
            this.ConsultaGruposdataGridView.Name = "ConsultaGruposdataGridView";
            this.ConsultaGruposdataGridView.Size = new System.Drawing.Size(395, 206);
            this.ConsultaGruposdataGridView.TabIndex = 0;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(173, 42);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(176, 20);
            this.FiltrotextBox.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Filtrar";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(46, 39);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 117;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.AutoSize = true;
            this.Imprimirbutton.ForeColor = System.Drawing.Color.Black;
            this.Imprimirbutton.Image = global::EjemploDetalle.Properties.Resources.print;
            this.Imprimirbutton.Location = new System.Drawing.Point(30, 381);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(93, 57);
            this.Imprimirbutton.TabIndex = 121;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Image = global::EjemploDetalle.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(355, 1);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(85, 61);
            this.Buscarbutton.TabIndex = 120;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // NombreGrupotextBox
            // 
            this.NombreGrupotextBox.Location = new System.Drawing.Point(113, 19);
            this.NombreGrupotextBox.Name = "NombreGrupotextBox";
            this.NombreGrupotextBox.Size = new System.Drawing.Size(169, 20);
            this.NombreGrupotextBox.TabIndex = 1;
            // 
            // ConsultaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "ConsultaGrupos";
            this.Text = "Consulta Grupos";
            this.Load += new System.EventHandler(this.ConsultaGrupos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaGruposdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ConsultaGruposdataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.TextBox NombreGrupotextBox;
    }
}