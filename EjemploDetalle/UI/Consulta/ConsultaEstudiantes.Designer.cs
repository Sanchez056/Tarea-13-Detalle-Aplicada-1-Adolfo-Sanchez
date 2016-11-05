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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultaClienterlabel = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.ConsultaEstudiantesdataGridView = new System.Windows.Forms.DataGridView();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicke = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
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
            this.Imprimirbutton.Location = new System.Drawing.Point(16, 478);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(93, 57);
            this.Imprimirbutton.TabIndex = 114;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // ConsultaEstudiantesdataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultaEstudiantesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultaEstudiantesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaEstudiantesdataGridView.Location = new System.Drawing.Point(13, 156);
            this.ConsultaEstudiantesdataGridView.Name = "ConsultaEstudiantesdataGridView";
            this.ConsultaEstudiantesdataGridView.Size = new System.Drawing.Size(529, 309);
            this.ConsultaEstudiantesdataGridView.TabIndex = 113;
            this.ConsultaEstudiantesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultaEstudiantesdataGridView_CellContentClick);
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(33, 134);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 112;
            this.Desdelabel.Text = "Desde";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Location = new System.Drawing.Point(447, 46);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 61);
            this.Buscarbutton.TabIndex = 111;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(197, 81);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(244, 20);
            this.FiltrotextBox.TabIndex = 110;
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hastalabel.Location = new System.Drawing.Point(194, 129);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(47, 18);
            this.Hastalabel.TabIndex = 109;
            this.Hastalabel.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(246, 129);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.HastadateTimePicker.TabIndex = 108;
            // 
            // DesdeDateTimePicke
            // 
            this.DesdeDateTimePicke.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicke.Location = new System.Drawing.Point(76, 125);
            this.DesdeDateTimePicke.Margin = new System.Windows.Forms.Padding(2);
            this.DesdeDateTimePicke.Name = "DesdeDateTimePicke";
            this.DesdeDateTimePicke.Size = new System.Drawing.Size(114, 22);
            this.DesdeDateTimePicke.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Filtrar";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(69, 80);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 105;
            // 
            // ConsultaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 548);
            this.Controls.Add(this.ConsultaClienterlabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultaEstudiantesdataGridView);
            this.Controls.Add(this.Desdelabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "ConsultaEstudiantes";
            this.Text = "Consulta Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEstudiantesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultaClienterlabel;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridView ConsultaEstudiantesdataGridView;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
    }
}