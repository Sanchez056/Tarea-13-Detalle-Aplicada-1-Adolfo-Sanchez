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
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.GrupoIdtextBox = new System.Windows.Forms.TextBox();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.EstudiantesIdlabel = new System.Windows.Forms.Label();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::EjemploDetalle.Properties.Resources.cancel;
            this.Eliminarbutton.Location = new System.Drawing.Point(205, 197);
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
            this.Guardarbutton.Location = new System.Drawing.Point(104, 197);
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
            this.Nuevobutton.Location = new System.Drawing.Point(9, 197);
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
            this.NombrestextBox.Location = new System.Drawing.Point(82, 127);
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
            this.Nombrelabel.Location = new System.Drawing.Point(24, 130);
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
            // RegistrosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 266);
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
    }
}