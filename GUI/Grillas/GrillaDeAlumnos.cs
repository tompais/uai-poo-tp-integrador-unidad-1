using Trabajo_Práctico_Integrador.Clases;
using Trabajo_Práctico_Integrador.Enums;
using Trabajo_Práctico_Integrador.GUI.Formularios;

namespace Trabajo_Práctico_Integrador
{
    public partial class GrillaDeAlumnos : Form
    {
        private readonly List<Alumno> Alumnos = [];
        public GrillaDeAlumnos()
        {
            InitializeComponent();
        }

        private void GrillaDeAlumnos_Load(object sender, EventArgs e)
        {
            selectorDeUnidadesDeAntiguedad.SelectedIndex = 0;
        }

        private void GrillaDeDatosDeAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            var hayFilasSeleccionadas = HayFilasSeleccionadas();
            if (hayFilasSeleccionadas)
            {
                ActualizarEstadoDeBotones(hayFilasSeleccionadas);
                InsertarAntiguedadEnCampoDeTextoFormateado();
                ActualizarCampoDeTextoDeMateriasNoAprobadas();
                ActualizarCampoDeTextoDeEdadDeIngreso();
            }
            else
            {
                campoDeTextoDeAntiguedad.Text = string.Empty;
                campoDeTextoDeMateriasNoAprobadas.Text = string.Empty;
                campoDeTextoDeEdadDeIngreso.Text = string.Empty;
            }
        }

        private void ActualizarCampoDeTextoDeEdadDeIngreso()
        {
            campoDeTextoDeEdadDeIngreso.Text = ObtenerAlumnoSeleccionado().Edad_De_Ingreso().ToString();
        }

        private void InsertarAntiguedadEnCampoDeTextoFormateado()
        {
            campoDeTextoDeAntiguedad.Text = ObtenerAlumnoSeleccionado().Antiguedad(ObtenerUnidadAntiguedad()).ToString();
        }

        private void ActualizarCampoDeTextoDeMateriasNoAprobadas()
        {
            campoDeTextoDeMateriasNoAprobadas.Text = ObtenerAlumnoSeleccionado().Materias_No_Aprobadas().ToString();
        }

        private void ActualizarEstadoDeBotones(bool hayFilasSeleccionadas)
        {
            botonModificarAlumno.Enabled = hayFilasSeleccionadas;
            botonEliminarAlumno.Enabled = hayFilasSeleccionadas;
        }

        private void ActualizarCampoDeTextoDeAntiguedad()
        {
            if (HayFilasSeleccionadas())
            {
                InsertarAntiguedadEnCampoDeTextoFormateado();
            }
            else
            {
                campoDeTextoDeAntiguedad.Text = string.Empty;
            }
        }

        private Alumno ObtenerAlumnoSeleccionado() => Alumnos[ObtenerFilaSeleccionada().Index];

        private UnidadAntiguedad ObtenerUnidadAntiguedad() => selectorDeUnidadesDeAntiguedad.SelectedIndex switch
        {
            0 => UnidadAntiguedad.ANOS,
            1 => UnidadAntiguedad.MESES,
            2 => UnidadAntiguedad.DIAS,
            _ => throw new ArgumentOutOfRangeException(),
        };

        private bool HayFilasSeleccionadas()
        {
            return grillaDeDatosDeAlumnos.SelectedRows.Count > 0;
        }

        private void BotonAgregarAlumno_Click(object sender, EventArgs e)
        {
            var formAgregarAlumno = new FormularioAgregarAlumno();
            formAgregarAlumno.ShowDialog();
            if (formAgregarAlumno.DialogResult == DialogResult.OK)
            {
                var nuevoAlumno = formAgregarAlumno.Alumno;
                Alumnos.Add(nuevoAlumno);
                grillaDeDatosDeAlumnos.Rows.Add(nuevoAlumno.Legajo, nuevoAlumno.Nombre, nuevoAlumno.Apellido, nuevoAlumno.Edad, nuevoAlumno.Activo);
            }
        }

        private void BotonEliminarAlumno_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = ObtenerFilaSeleccionada();
            EliminarAlumnoDeLista(filaSeleccionada);
            EliminarAlumnoDeGrilla(filaSeleccionada);
            ForzarRecoleccionDeBasura();
        }

        private void EliminarAlumnoDeLista(DataGridViewRow filaSeleccionada)
        {
            Alumnos.RemoveAt(filaSeleccionada.Index);
        }

        private DataGridViewRow ObtenerFilaSeleccionada() => grillaDeDatosDeAlumnos.SelectedRows[0];

        private void EliminarAlumnoDeGrilla(DataGridViewRow filaSeleccionada)
        {
            grillaDeDatosDeAlumnos.Rows.Remove(filaSeleccionada);
        }

        private static void ForzarRecoleccionDeBasura()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void SelectorDeUnidadesDeAntiguedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCampoDeTextoDeAntiguedad();
        }

        private void BotonModificarAlumno_Click(object sender, EventArgs e)
        {
            var alumnoSeleccionado = ObtenerAlumnoSeleccionado();
            var formModificarAlumno = new FormularioModificarAlumno(alumnoSeleccionado);

            if (formModificarAlumno.ShowDialog() == DialogResult.OK)
            {
                // Actualizar la lista en memoria
                ActualizarAlumnoEnLista(alumnoSeleccionado);

                // Actualizar la grilla con los datos modificados
                ActualizarFilaEnGrilla(alumnoSeleccionado);
            }
        }

        private void ActualizarAlumnoEnLista(Alumno alumnoModificado)
        {
            var index = Alumnos.FindIndex(a => a.Legajo == alumnoModificado.Legajo);
            if (index != -1)
            {
                Alumnos[index] = alumnoModificado;
            }
        }

        private void ActualizarFilaEnGrilla(Alumno alumno)
        {
            var row = grillaDeDatosDeAlumnos.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => (int)r.Cells["Legajo"].Value == alumno.Legajo);

            if (row != null)
            {
                row.Cells["Nombre"].Value = alumno.Nombre;
                row.Cells["Apellido"].Value = alumno.Apellido;
                row.Cells["Edad"].Value = alumno.Edad;
                row.Cells["Activo"].Value = alumno.Activo;
            }
        }

    }
}
