using Trabajo_Práctico_Integrador.Clases;

namespace Trabajo_Práctico_Integrador.GUI.Formularios
{
    public partial class FormularioModificarAlumno : FormularioBaseAlumno
    {
        private CheckBox checkBoxActivo;
        private NumericUpDown campoMateriasAprobadas;

        // Variables para rastrear si los valores han sido modificados
        private bool fechaNacimientoModificada = false;
        private bool fechaIngresoModificada = false;
        private bool materiasAprobadasModificadas = false;

        public Alumno Alumno { get; set; }


        public FormularioModificarAlumno(Alumno alumno) : base()
        {
            Alumno = alumno; // Guardar referencia al alumno a modificar
            InitializeComponent();
        }

        private void CargarDatosAlumno()
        {
            // Inicializar los controles con valores predeterminados
            campoDeTextoLegajo.Value = Alumno.Legajo;
            campoDeTextoNombre.Text = Alumno.Nombre;
            campoDeTextoApellido.Text = Alumno.Apellido;
            checkBoxActivo.Checked = Alumno.Activo;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            // Actualizar los datos del alumno
            Alumno.Legajo = (uint)campoDeTextoLegajo.Value;
            Alumno.Nombre = campoDeTextoNombre.Text;
            Alumno.Apellido = campoDeTextoApellido.Text;

            // Actualizar solo si los valores han sido modificados
            if (fechaNacimientoModificada)
            {
                Alumno.Fecha_Nacimiento = DateOnly.FromDateTime(selectorFechaDeNacimiento.Value);
            }

            if (fechaIngresoModificada)
            {
                Alumno.Fecha_Ingreso = DateOnly.FromDateTime(selectorFechaDeIngreso.Value);
            }

            if (materiasAprobadasModificadas)
            {
                Alumno.Cant_Materias_Aprobadas = (uint)campoMateriasAprobadas.Value;
            }

            Alumno.Activo = checkBoxActivo.Checked;

            DialogResult = DialogResult.OK; // Indicar que los cambios se guardaron
            Close();
        }

        private void SelectorFechaDeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            fechaNacimientoModificada = true; // Marcar que la fecha de nacimiento ha sido modificada
        }

        private void SelectorFechaDeIngreso_ValueChanged(object sender, EventArgs e)
        {
            fechaIngresoModificada = true; // Marcar que la fecha de ingreso ha sido modificada
        }

        private void CampoMateriasAprobadas_ValueChanged(object sender, EventArgs e)
        {
            materiasAprobadasModificadas = true; // Marcar que la cantidad de materias aprobadas ha sido modificada
        }

        private void FormularioModificarAlumno_Load(object sender, EventArgs e)
        {
            CargarDatosAlumno();
        }
    }
}
