namespace Trabajo_Pr�ctico_Integrador.GUI.Formularios
{
    public partial class FormularioBaseAlumno : Form
    {
        protected NumericUpDown campoDeTextoLegajo;
        protected TextBox campoDeTextoNombre;
        protected TextBox campoDeTextoApellido;
        protected DateTimePicker selectorFechaDeNacimiento;
        protected DateTimePicker selectorFechaDeIngreso;
        protected Button botonAceptar;

        // Labels para los campos
        protected Label etiquetaLegajo;
        protected Label etiquetaNombre;
        protected Label etiquetaApellido;
        protected Label etiquetaFechaDeNacimiento;
        protected Label etiquetaFechaDeIngreso;

        public FormularioBaseAlumno()
        {
            InicializarControlesComunes(); // Inicializar los controles sin configurar ubicaci�n
        }

        private void InicializarControlesComunes()
        {
            // Inicializar controles comunes
            campoDeTextoLegajo = new NumericUpDown
            {
                Minimum = 1, // Valor m�nimo
                Maximum = 999999, // Valor m�ximo
                Value = 1, // Valor por defecto
                Size = new Size(200, 23) // Tama�o predeterminado
            };

            campoDeTextoNombre = new TextBox
            {
                Size = new Size(200, 23)
            };

            campoDeTextoApellido = new TextBox
            {
                Size = new Size(200, 23)
            };

            selectorFechaDeNacimiento = new DateTimePicker
            {
                Size = new Size(200, 23),
                MaxDate = DateTime.Now.AddYears(-18) // Limitar a personas de 18 a�os o m�s
            };

            selectorFechaDeIngreso = new DateTimePicker
            {
                Size = new Size(200, 23),
                MaxDate = DateTime.Now.AddYears(70), // Fecha m�xima es hoy
                MinDate = DateTime.Now // Fecha m�xima es hoy
            };

            botonAceptar = new Button
            {
                Text = "Aceptar",
                Enabled = false,
                Size = new Size(100, 30)
            };

            // Inicializar labels
            etiquetaLegajo = new Label
            {
                Text = "Legajo",
                AutoSize = true
            };

            etiquetaNombre = new Label
            {
                Text = "Nombre",
                AutoSize = true
            };

            etiquetaApellido = new Label
            {
                Text = "Apellido",
                AutoSize = true
            };

            etiquetaFechaDeNacimiento = new Label
            {
                Text = "Fecha de Nacimiento",
                AutoSize = true
            };

            etiquetaFechaDeIngreso = new Label
            {
                Text = "Fecha de Ingreso",
                AutoSize = true
            };

            // Configurar eventos comunes
            campoDeTextoLegajo.ValueChanged += ValidarCampos!;
            campoDeTextoNombre.TextChanged += ValidarCampos!;
            campoDeTextoApellido.TextChanged += ValidarCampos!;
            selectorFechaDeNacimiento.ValueChanged += ActualizarSelectorDeFechaDeIngreso!;

            // Agregar controles al formulario
            Controls.Add(campoDeTextoLegajo);
            Controls.Add(campoDeTextoNombre);
            Controls.Add(campoDeTextoApellido);
            Controls.Add(selectorFechaDeNacimiento);
            Controls.Add(selectorFechaDeIngreso);
            Controls.Add(botonAceptar);

            // Agregar labels al formulario
            Controls.Add(etiquetaLegajo);
            Controls.Add(etiquetaNombre);
            Controls.Add(etiquetaApellido);
            Controls.Add(etiquetaFechaDeNacimiento);
            Controls.Add(etiquetaFechaDeIngreso);
        }

        protected virtual void ValidarCampos(object? sender, EventArgs e)
        {
            botonAceptar.Enabled = campoDeTextoLegajo.Value > 0 &&
                                   !string.IsNullOrWhiteSpace(campoDeTextoNombre.Text) &&
                                   !string.IsNullOrWhiteSpace(campoDeTextoApellido.Text);
        }

        private void ActualizarSelectorDeFechaDeIngreso(object sender, EventArgs e)
        {
            var fechaDeReferencia = selectorFechaDeNacimiento.Value.AddYears(18);
            selectorFechaDeIngreso.MaxDate = fechaDeReferencia.AddYears(70);
            selectorFechaDeIngreso.MinDate = fechaDeReferencia;
            selectorFechaDeIngreso.Value = fechaDeReferencia;
        }
    }
}

