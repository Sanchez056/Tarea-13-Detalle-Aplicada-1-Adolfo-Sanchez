﻿namespace EjemploDetalle.Registros
{
    partial class RegistrosEstudiantes
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
            this.Titulolabel = new System.Windows.Forms.Label();
            this.EstudiantesIdlabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.EstudiantesIdtextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GruposdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GruposdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.Location = new System.Drawing.Point(65, 26);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(228, 23);
            this.Titulolabel.TabIndex = 1;
            this.Titulolabel.Text = "Registros De  Estudiantes";
            // 
            // EstudiantesIdlabel
            // 
            this.EstudiantesIdlabel.AutoSize = true;
            this.EstudiantesIdlabel.Location = new System.Drawing.Point(35, 100);
            this.EstudiantesIdlabel.Name = "EstudiantesIdlabel";
            this.EstudiantesIdlabel.Size = new System.Drawing.Size(74, 13);
            this.EstudiantesIdlabel.TabIndex = 2;
            this.EstudiantesIdlabel.Text = "EstudiantesId:";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(35, 135);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(52, 13);
            this.Nombrelabel.TabIndex = 3;
            this.Nombrelabel.Text = "Nombres:";
            // 
            // EstudiantesIdtextBox
            // 
            this.EstudiantesIdtextBox.Location = new System.Drawing.Point(115, 93);
            this.EstudiantesIdtextBox.Name = "EstudiantesIdtextBox";
            this.EstudiantesIdtextBox.Size = new System.Drawing.Size(68, 20);
            this.EstudiantesIdtextBox.TabIndex = 4;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(93, 132);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(130, 20);
            this.NombrestextBox.TabIndex = 5;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::EjemploDetalle.Properties.Resources.cancel;
            this.Eliminarbutton.Location = new System.Drawing.Point(207, 361);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(88, 46);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::EjemploDetalle.Properties.Resources.save;
            this.Guardarbutton.Location = new System.Drawing.Point(106, 361);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 46);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::EjemploDetalle.Properties.Resources._new;
            this.Nuevobutton.Location = new System.Drawing.Point(11, 361);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(79, 46);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::EjemploDetalle.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(189, 65);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(102, 48);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // NombreserrorProvider
            // 
            this.NombreserrorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GruposdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(8, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "El Grupos en que Esta el Estudiantes";
            // 
            // GruposdataGridView
            // 
            this.GruposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GruposdataGridView.Location = new System.Drawing.Point(9, 43);
            this.GruposdataGridView.Name = "GruposdataGridView";
            this.GruposdataGridView.Size = new System.Drawing.Size(255, 117);
            this.GruposdataGridView.TabIndex = 11;
            // 
            // RegistrosEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.EstudiantesIdtextBox);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.EstudiantesIdlabel);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "RegistrosEstudiantes";
            this.Text = "Registros De Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GruposdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Label EstudiantesIdlabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.TextBox EstudiantesIdtextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.ErrorProvider NombreserrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GruposdataGridView;
    }
}