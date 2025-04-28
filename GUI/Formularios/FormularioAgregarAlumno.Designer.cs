namespace Trabajo_Práctico_Integrador.GUI.Formularios
{
    partial class FormularioAgregarAlumno
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
            ((System.ComponentModel.ISupportInitialize)campoDeTextoLegajo).BeginInit();
            SuspendLayout();
            // 
            // campoDeTextoLegajo
            // 
            campoDeTextoLegajo.Location = new Point(326, 87);
            // 
            // campoDeTextoNombre
            // 
            campoDeTextoNombre.Location = new Point(326, 116);
            // 
            // campoDeTextoApellido
            // 
            campoDeTextoApellido.Location = new Point(326, 146);
            // 
            // selectorFechaDeNacimiento
            // 
            selectorFechaDeNacimiento.Location = new Point(326, 175);
            // 
            // selectorFechaDeIngreso
            // 
            selectorFechaDeIngreso.Location = new Point(326, 204);
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(388, 233);
            botonAceptar.Click += BotonAceptar_Click;
            // 
            // etiquetaLegajo
            // 
            etiquetaLegajo.Location = new Point(278, 89);
            // 
            // etiquetaNombre
            // 
            etiquetaNombre.Location = new Point(269, 116);
            // 
            // etiquetaApellido
            // 
            etiquetaApellido.Location = new Point(269, 149);
            // 
            // etiquetaFechaDeNacimiento
            // 
            etiquetaFechaDeNacimiento.Location = new Point(201, 181);
            // 
            // etiquetaFechaDeIngreso
            // 
            etiquetaFechaDeIngreso.Location = new Point(224, 210);
            // 
            // FormularioAgregarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FormularioAgregarAlumno";
            Text = "FormularioAgregarAlumno";
            ((System.ComponentModel.ISupportInitialize)campoDeTextoLegajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
