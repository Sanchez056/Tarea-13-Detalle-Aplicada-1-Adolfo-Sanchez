namespace EjemploDetalle.Consulta
{
    partial class ConsultaEstudiantes
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
            this.ConsultaClienterlabel = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ConsultaEstudiantesdataGridView = new System.Windows.Forms.DataGridView();
            this.NombreEstudiantetextBox = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEstudiantesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaClienterlabel
            // 
            this.ConsultaClienterlabel.AutoSize = true;
            this.ConsultaClienterlabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaClienterlabel.Location = new System.Drawing.Point(159, -34);
            this.ConsultaClienterlabel.Name = "ConsultaClienterlabel";
            this.ConsultaClienterlabel.Size = new System.Drawing.Size(313, 40);
            this.ConsultaClienterlabel.TabIndex = 115;
            this.ConsultaClienterlabel.Text = "Consulta De Clientes";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.AutoSize = true;
            this.Imprimirbutton.ForeColor = System.Drawing.Color.Black;
            this.Imprimirbutton.Image = global::EjemploDetalle.Properties.Resources.print;
            this.Imprimirbutton.Location = new System.Drawing.Point(35, 427);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(93, 57);
            this.Imprimirbutton.TabIndex = 114;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Image = global::EjemploDetalle.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(360, 42);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(85, 61);
            this.Buscarbutton.TabIndex = 111;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(178, 83);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(176, 20);
            this.FiltrotextBox.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Filtrar";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(51, 80);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 105;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.NombreEstudiantetextBox);
            this.groupBox.Controls.Add(this.ConsultaEstudiantesdataGridView);
            this.groupBox.Location = new System.Drawing.Point(16, 141);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(429, 258);
            this.groupBox.TabIndex = 116;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Grupos De Estudiante:";
            // 
            // ConsultaEstudiantesdataGridView
            // 
            this.ConsultaEstudiantesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaEstudiantesdataGridView.Location = new System.Drawing.Point(19, 41);
            this.ConsultaEstudiantesdataGridView.Name = "ConsultaEstudiantesdataGridView";
            this.ConsultaEstudiantesdataGridView.Size = new System.Drawing.Size(395, 211);
            this.ConsultaEstudiantesdataGridView.TabIndex = 0;
            // 
            // NombreEstudiantetextBox
            // 
            this.NombreEstudiantetextBox.Location = new System.Drawing.Point(124, 15);
            this.NombreEstudiantetextBox.Name = "NombreEstudiantetextBox";
            this.NombreEstudiantetextBox.Size = new System.Drawing.Size(169, 20);
            this.NombreEstudiantetextBox.TabIndex = 2;
            // 
            // ConsultaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 511);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ConsultaClienterlabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "ConsultaEstudiantes";
            this.Text = "Consulta Estudiantes";
            this.Load += new System.EventHandler(this.ConsultaEstudiantes_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEstudiantesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultaClienterlabel;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView ConsultaEstudiantesdataGridView;
        private System.Windows.Forms.TextBox NombreEstudiantetextBox;
    }
}