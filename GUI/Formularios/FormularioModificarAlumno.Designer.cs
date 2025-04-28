using Trabajo_Práctico_Integrador.Constantes;

namespace Trabajo_Práctico_Integrador.GUI.Formularios
{
    partial class FormularioModificarAlumno
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
            checkBoxActivo = new CheckBox();
            campoMateriasAprobadas = new NumericUpDown();
            etiquetaCantidadDeMateriasAprobadas = new Label();
            ((System.ComponentModel.ISupportInitialize)campoDeTextoLegajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoMateriasAprobadas).BeginInit();
            SuspendLayout();
            // 
            // campoDeTextoLegajo
            // 
            campoDeTextoLegajo.Location = new Point(288, 95);
            // 
            // campoDeTextoNombre
            // 
            campoDeTextoNombre.Location = new Point(288, 124);
            // 
            // campoDeTextoApellido
            // 
            campoDeTextoApellido.Location = new Point(288, 153);
            // 
            // selectorFechaDeNacimiento
            // 
            selectorFechaDeNacimiento.Location = new Point(288, 182);
            selectorFechaDeNacimiento.ValueChanged += SelectorFechaDeNacimiento_ValueChanged;
            // 
            // selectorFechaDeIngreso
            // 
            selectorFechaDeIngreso.Location = new Point(288, 211);
            selectorFechaDeIngreso.ValueChanged += SelectorFechaDeIngreso_ValueChanged;
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(337, 299);
            botonAceptar.Size = new Size(104, 30);
            botonAceptar.Click += BotonAceptar_Click;
            // 
            // etiquetaLegajo
            // 
            etiquetaLegajo.Location = new Point(240, 97);
            // 
            // etiquetaNombre
            // 
            etiquetaNombre.Location = new Point(231, 127);
            // 
            // etiquetaApellido
            // 
            etiquetaApellido.Location = new Point(231, 156);
            // 
            // etiquetaFechaDeNacimiento
            // 
            etiquetaFechaDeNacimiento.Location = new Point(163, 188);
            // 
            // etiquetaFechaDeIngreso
            // 
            etiquetaFechaDeIngreso.Location = new Point(186, 217);
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.Location = new Point(288, 269);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(104, 24);
            checkBoxActivo.TabIndex = 11;
            checkBoxActivo.Text = "Activo";
            // 
            // campoMateriasAprobadas
            // 
            campoMateriasAprobadas.Location = new Point(288, 240);
            campoMateriasAprobadas.Name = "campoMateriasAprobadas";
            campoMateriasAprobadas.Size = new Size(200, 23);
            campoMateriasAprobadas.TabIndex = 12;
            campoMateriasAprobadas.ValueChanged += CampoMateriasAprobadas_ValueChanged;
            // 
            // etiquetaCantidadDeMateriasAprobadas
            // 
            etiquetaCantidadDeMateriasAprobadas.AutoSize = true;
            etiquetaCantidadDeMateriasAprobadas.Location = new Point(103, 242);
            etiquetaCantidadDeMateriasAprobadas.Name = "etiquetaCantidadDeMateriasAprobadas";
            etiquetaCantidadDeMateriasAprobadas.Size = new Size(179, 15);
            etiquetaCantidadDeMateriasAprobadas.TabIndex = 13;
            etiquetaCantidadDeMateriasAprobadas.Text = "Cantidad de Materias Aprobadas";
            // 
            // FormularioModificarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(etiquetaCantidadDeMateriasAprobadas);
            Controls.Add(checkBoxActivo);
            Controls.Add(campoMateriasAprobadas);
            Name = "FormularioModificarAlumno";
            Text = "FormularioModificarAlumno";
            Load += FormularioModificarAlumno_Load;
            Controls.SetChildIndex(campoMateriasAprobadas, 0);
            Controls.SetChildIndex(checkBoxActivo, 0);
            Controls.SetChildIndex(etiquetaFechaDeIngreso, 0);
            Controls.SetChildIndex(etiquetaFechaDeNacimiento, 0);
            Controls.SetChildIndex(etiquetaApellido, 0);
            Controls.SetChildIndex(etiquetaNombre, 0);
            Controls.SetChildIndex(etiquetaLegajo, 0);
            Controls.SetChildIndex(botonAceptar, 0);
            Controls.SetChildIndex(selectorFechaDeIngreso, 0);
            Controls.SetChildIndex(selectorFechaDeNacimiento, 0);
            Controls.SetChildIndex(campoDeTextoApellido, 0);
            Controls.SetChildIndex(campoDeTextoNombre, 0);
            Controls.SetChildIndex(campoDeTextoLegajo, 0);
            Controls.SetChildIndex(etiquetaCantidadDeMateriasAprobadas, 0);
            ((System.ComponentModel.ISupportInitialize)campoDeTextoLegajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoMateriasAprobadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiquetaCantidadDeMateriasAprobadas;
    }
}