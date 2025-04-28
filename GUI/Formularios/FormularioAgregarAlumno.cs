using Trabajo_Práctico_Integrador.Clases;

namespace Trabajo_Práctico_Integrador.GUI.Formularios
{
    public partial class FormularioAgregarAlumno : FormularioBaseAlumno
    {
        public Alumno Alumno { get; private set; }

        public FormularioAgregarAlumno()
        {
            Text = "Agregar Alumno";
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            Alumno = new Alumno(
                (int)campoDeTextoLegajo.Value,
                campoDeTextoNombre.Text,
                campoDeTextoApellido.Text,
                DateOnly.FromDateTime(selectorFechaDeNacimiento.Value),
                DateOnly.FromDateTime(selectorFechaDeIngreso.Value)
            );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

