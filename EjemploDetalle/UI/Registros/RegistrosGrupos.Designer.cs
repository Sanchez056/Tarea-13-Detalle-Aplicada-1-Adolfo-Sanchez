namespace EjemploDetalle.Registros
{
    partial class RegistrosGrupos
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
            this.components = new System.ComponentModel.Container();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.GrupoIdtextBox = new System.Windows.Forms.TextBox();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.EstudiantesIdlabel = new System.Windows.Forms.Label();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SeleEstudiantescomboBox = new System.Windows.Forms.ComboBox();
            this.Insertarbutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SelecionEstudianteserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DaTaGripwerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IngresarEstudianteserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstuGruposdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecionEstudianteserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaGripwerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresarEstudianteserrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstuGruposdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::EjemploDetalle.Properties.Resources.cancel;
            this.Eliminarbutton.Location = new System.Drawing.Point(205, 262);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(88, 46);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::EjemploDetalle.Properties.Resources.save;
            this.Guardarbutton.Location = new System.Drawing.Point(104, 262);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 46);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::EjemploDetalle.Properties.Resources._new;
            this.Nuevobutton.Location = new System.Drawing.Point(9, 262);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(79, 46);
            this.Nuevobutton.TabIndex = 15;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(82, 134);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(130, 20);
            this.NombrestextBox.TabIndex = 14;
            // 
            // GrupoIdtextBox
            // 
            this.GrupoIdtextBox.Location = new System.Drawing.Point(104, 88);
            this.GrupoIdtextBox.Name = "GrupoIdtextBox";
            this.GrupoIdtextBox.Size = new System.Drawing.Size(68, 20);
            this.GrupoIdtextBox.TabIndex = 13;
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(24, 134);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(52, 13);
            this.Nombrelabel.TabIndex = 12;
            this.Nombrelabel.Text = "Nombres:";
            // 
            // EstudiantesIdlabel
            // 
            this.EstudiantesIdlabel.AutoSize = true;
            this.EstudiantesIdlabel.Location = new System.Drawing.Point(24, 95);
            this.EstudiantesIdlabel.Name = "EstudiantesIdlabel";
            this.EstudiantesIdlabel.Size = new System.Drawing.Size(48, 13);
            this.EstudiantesIdlabel.TabIndex = 11;
            this.EstudiantesIdlabel.Text = "GrupoId:";
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.Location = new System.Drawing.Point(54, 21);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(179, 23);
            this.Titulolabel.TabIndex = 10;
            this.Titulolabel.Text = "Registro De Grupos";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::EjemploDetalle.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(178, 60);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(102, 48);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // SeleEstudiantescomboBox
            // 
            this.SeleEstudiantescomboBox.FormattingEnabled = true;
            this.SeleEstudiantescomboBox.Location = new System.Drawing.Point(35, 20);
            this.SeleEstudiantescomboBox.Name = "SeleEstudiantescomboBox";
            this.SeleEstudiantescomboBox.Size = new System.Drawing.Size(121, 21);
            this.SeleEstudiantescomboBox.TabIndex = 18;
            this.SeleEstudiantescomboBox.SelectedIndexChanged += new System.EventHandler(this.SeleEstudiantescomboBox_SelectedIndexChanged);
            // 
            // Insertarbutton
            // 
            this.Insertarbutton.Location = new System.Drawing.Point(450, 256);
            this.Insertarbutton.Name = "Insertarbutton";
            this.Insertarbutton.Size = new System.Drawing.Size(87, 42);
            this.Insertarbutton.TabIndex = 22;
            this.Insertarbutton.Text = "Insertar";
            this.Insertarbutton.UseVisualStyleBackColor = true;
            this.Insertarbutton.Click += new System.EventHandler(this.Insertarbutton_Click);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // NombreserrorProvider
            // 
            this.NombreserrorProvider.ContainerControl = this;
            // 
            // SelecionEstudianteserrorProvider
            // 
            this.SelecionEstudianteserrorProvider.ContainerControl = this;
            // 
            // DaTaGripwerrorProvider
            // 
            this.DaTaGripwerrorProvider.ContainerControl = this;
            // 
            // IngresarEstudianteserrorProvider
            // 
            this.IngresarEstudianteserrorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstuGruposdataGridView);
            this.groupBox1.Controls.Add(this.SeleEstudiantescomboBox);
            this.groupBox1.Location = new System.Drawing.Point(303, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 238);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EstuGruposdataGridView
            // 
            this.EstuGruposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstuGruposdataGridView.Location = new System.Drawing.Point(21, 47);
            this.EstuGruposdataGridView.Name = "EstuGruposdataGridView";
            this.EstuGruposdataGridView.Size = new System.Drawing.Size(349, 177);
            this.EstuGruposdataGridView.TabIndex = 22;
            // 
            // RegistrosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Insertarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.GrupoIdtextBox);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.EstudiantesIdlabel);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "RegistrosGrupos";
            this.Text = "Registros de Grupos";
            this.Load += new System.EventHandler(this.RegistrosGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecionEstudianteserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaGripwerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresarEstudianteserrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstuGruposdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox GrupoIdtextBox;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label EstudiantesIdlabel;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox SeleEstudiantescomboBox;
        private System.Windows.Forms.Button Insertarbutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.ErrorProvider NombreserrorProvider;
        private System.Windows.Forms.ErrorProvider SelecionEstudianteserrorProvider;
        private System.Windows.Forms.ErrorProvider DaTaGripwerrorProvider;
        private System.Windows.Forms.ErrorProvider IngresarEstudianteserrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EstuGruposdataGridView;
    }
}