namespace Trabajo_Práctico_Integrador
{
    partial class GrillaDeAlumnos
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
            grillaDeDatosDeAlumnos = new DataGridView();
            Legajo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            botonAgregarAlumno = new Button();
            botonModificarAlumno = new Button();
            botonEliminarAlumno = new Button();
            etiquetaAntiguedad = new Label();
            campoDeTextoDeAntiguedad = new TextBox();
            selectorDeUnidadesDeAntiguedad = new ComboBox();
            campoDeTextoDeMateriasNoAprobadas = new TextBox();
            etiquetaMateriasNoAprobadas = new Label();
            campoDeTextoDeEdadDeIngreso = new TextBox();
            etiquetaEdadDeIngreso = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaDeDatosDeAlumnos).BeginInit();
            SuspendLayout();
            // 
            // grillaDeDatosDeAlumnos
            // 
            grillaDeDatosDeAlumnos.AllowUserToAddRows = false;
            grillaDeDatosDeAlumnos.AllowUserToDeleteRows = false;
            grillaDeDatosDeAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaDeDatosDeAlumnos.Columns.AddRange(new DataGridViewColumn[] { Legajo, Nombre, Apellido, Edad, Activo });
            grillaDeDatosDeAlumnos.Location = new Point(0, 0);
            grillaDeDatosDeAlumnos.MultiSelect = false;
            grillaDeDatosDeAlumnos.Name = "grillaDeDatosDeAlumnos";
            grillaDeDatosDeAlumnos.ReadOnly = true;
            grillaDeDatosDeAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaDeDatosDeAlumnos.Size = new Size(543, 450);
            grillaDeDatosDeAlumnos.TabIndex = 0;
            grillaDeDatosDeAlumnos.SelectionChanged += GrillaDeDatosDeAlumnos_SelectionChanged;
            // 
            // Legajo
            // 
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            // 
            // botonAgregarAlumno
            // 
            botonAgregarAlumno.Location = new Point(549, 0);
            botonAgregarAlumno.Name = "botonAgregarAlumno";
            botonAgregarAlumno.Size = new Size(122, 26);
            botonAgregarAlumno.TabIndex = 1;
            botonAgregarAlumno.Text = "Agregar Alumno";
            botonAgregarAlumno.UseVisualStyleBackColor = true;
            botonAgregarAlumno.Click += BotonAgregarAlumno_Click;
            // 
            // botonModificarAlumno
            // 
            botonModificarAlumno.Enabled = false;
            botonModificarAlumno.Location = new Point(549, 32);
            botonModificarAlumno.Name = "botonModificarAlumno";
            botonModificarAlumno.Size = new Size(122, 26);
            botonModificarAlumno.TabIndex = 2;
            botonModificarAlumno.Text = "Modificar Alumno";
            botonModificarAlumno.UseVisualStyleBackColor = true;
            botonModificarAlumno.Click += BotonModificarAlumno_Click;
            // 
            // botonEliminarAlumno
            // 
            botonEliminarAlumno.Enabled = false;
            botonEliminarAlumno.Location = new Point(549, 64);
            botonEliminarAlumno.Name = "botonEliminarAlumno";
            botonEliminarAlumno.Size = new Size(122, 26);
            botonEliminarAlumno.TabIndex = 3;
            botonEliminarAlumno.Text = "Eliminar Alumno";
            botonEliminarAlumno.UseVisualStyleBackColor = true;
            botonEliminarAlumno.Click += BotonEliminarAlumno_Click;
            // 
            // etiquetaAntiguedad
            // 
            etiquetaAntiguedad.AutoSize = true;
            etiquetaAntiguedad.Location = new Point(549, 277);
            etiquetaAntiguedad.Name = "etiquetaAntiguedad";
            etiquetaAntiguedad.Size = new Size(69, 15);
            etiquetaAntiguedad.TabIndex = 5;
            etiquetaAntiguedad.Text = "Antiguedad";
            // 
            // campoDeTextoDeAntiguedad
            // 
            campoDeTextoDeAntiguedad.Location = new Point(549, 295);
            campoDeTextoDeAntiguedad.Name = "campoDeTextoDeAntiguedad";
            campoDeTextoDeAntiguedad.ReadOnly = true;
            campoDeTextoDeAntiguedad.Size = new Size(131, 23);
            campoDeTextoDeAntiguedad.TabIndex = 6;
            // 
            // selectorDeUnidadesDeAntiguedad
            // 
            selectorDeUnidadesDeAntiguedad.FormattingEnabled = true;
            selectorDeUnidadesDeAntiguedad.Items.AddRange(new object[] { "AÑOS", "MESES", "DÍAS" });
            selectorDeUnidadesDeAntiguedad.Location = new Point(686, 295);
            selectorDeUnidadesDeAntiguedad.Name = "selectorDeUnidadesDeAntiguedad";
            selectorDeUnidadesDeAntiguedad.Size = new Size(102, 23);
            selectorDeUnidadesDeAntiguedad.TabIndex = 7;
            selectorDeUnidadesDeAntiguedad.SelectedIndexChanged += SelectorDeUnidadesDeAntiguedad_SelectedIndexChanged;
            // 
            // campoDeTextoDeMateriasNoAprobadas
            // 
            campoDeTextoDeMateriasNoAprobadas.Location = new Point(549, 350);
            campoDeTextoDeMateriasNoAprobadas.Name = "campoDeTextoDeMateriasNoAprobadas";
            campoDeTextoDeMateriasNoAprobadas.ReadOnly = true;
            campoDeTextoDeMateriasNoAprobadas.Size = new Size(131, 23);
            campoDeTextoDeMateriasNoAprobadas.TabIndex = 9;
            // 
            // etiquetaMateriasNoAprobadas
            // 
            etiquetaMateriasNoAprobadas.AutoSize = true;
            etiquetaMateriasNoAprobadas.Location = new Point(549, 332);
            etiquetaMateriasNoAprobadas.Name = "etiquetaMateriasNoAprobadas";
            etiquetaMateriasNoAprobadas.Size = new Size(131, 15);
            etiquetaMateriasNoAprobadas.TabIndex = 8;
            etiquetaMateriasNoAprobadas.Text = "Materias No Aprobadas";
            // 
            // campoDeTextoDeEdadDeIngreso
            // 
            campoDeTextoDeEdadDeIngreso.Location = new Point(549, 405);
            campoDeTextoDeEdadDeIngreso.Name = "campoDeTextoDeEdadDeIngreso";
            campoDeTextoDeEdadDeIngreso.ReadOnly = true;
            campoDeTextoDeEdadDeIngreso.Size = new Size(131, 23);
            campoDeTextoDeEdadDeIngreso.TabIndex = 11;
            // 
            // etiquetaEdadDeIngreso
            // 
            etiquetaEdadDeIngreso.AutoSize = true;
            etiquetaEdadDeIngreso.Location = new Point(549, 387);
            etiquetaEdadDeIngreso.Name = "etiquetaEdadDeIngreso";
            etiquetaEdadDeIngreso.Size = new Size(91, 15);
            etiquetaEdadDeIngreso.TabIndex = 10;
            etiquetaEdadDeIngreso.Text = "Edad de Ingreso";
            // 
            // GrillaDeAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(campoDeTextoDeEdadDeIngreso);
            Controls.Add(etiquetaEdadDeIngreso);
            Controls.Add(campoDeTextoDeMateriasNoAprobadas);
            Controls.Add(etiquetaMateriasNoAprobadas);
            Controls.Add(selectorDeUnidadesDeAntiguedad);
            Controls.Add(campoDeTextoDeAntiguedad);
            Controls.Add(etiquetaAntiguedad);
            Controls.Add(botonEliminarAlumno);
            Controls.Add(botonModificarAlumno);
            Controls.Add(botonAgregarAlumno);
            Controls.Add(grillaDeDatosDeAlumnos);
            Name = "GrillaDeAlumnos";
            Text = "Grilla de Alumnos";
            Load += GrillaDeAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)grillaDeDatosDeAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaDeDatosDeAlumnos;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Activo;
        private Button botonAgregarAlumno;
        private Button botonModificarAlumno;
        private Button botonEliminarAlumno;
        private Label etiquetaAntiguedad;
        private TextBox campoDeTextoDeAntiguedad;
        private ComboBox selectorDeUnidadesDeAntiguedad;
        private TextBox campoDeTextoDeMateriasNoAprobadas;
        private Label etiquetaMateriasNoAprobadas;
        private TextBox campoDeTextoDeEdadDeIngreso;
        private Label etiquetaEdadDeIngreso;
    }
}
