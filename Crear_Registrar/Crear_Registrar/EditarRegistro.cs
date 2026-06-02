using System;
using System.Linq;
using System.Windows.Forms;
using static Crear_Registrar.registro;

namespace Crear_Registrar
{
    public partial class EditarRegistro : Form
    {
        // Variable para guardar el índice del usuario que se está editando
        private int indiceUsuario;

        // Constructor ORIGINAL (sin parámetros) - lo dejamos igual
        public EditarRegistro()
        {
            InitializeComponent();
            CargarListaEnDataGridView();
            CargarUsuariosEnComboBox();
            ConfigurarEventoEdad();
        }

        // NUEVO CONSTRUCTOR: Recibe el usuario y su índice para editarlo directamente
        public EditarRegistro(Registro usuarioSeleccionado, int indice)
        {
            InitializeComponent();

            // Guardar el índice
            indiceUsuario = indice;

            // Cargar los datos del usuario en los campos
            CargarDatosEnCampos(usuarioSeleccionado);

            // Configurar el resto
            CargarListaEnDataGridView();
            CargarUsuariosEnComboBox();
            ConfigurarEventoEdad();

            // Sincronizar el comboBox con el usuario seleccionado
            comboBoxSeleccionarUsuario.SelectedItem = usuarioSeleccionado;
        }

        // Configurar el evento de cambio de fecha para calcular edad
        private void ConfigurarEventoEdad()
        {
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
        }

        // Cargar todos los usuarios en el DataGridView
        private void CargarListaEnDataGridView()
        {
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = MemoriaClase.Memoria.Instancia.listaRegistros.ToList();

            // Configurar columnas (opcional - para mejor visualización)
            if (dataGridViewUsuarios.Columns.Count > 0)
            {
                if (dataGridViewUsuarios.Columns.Contains("Username"))
                    dataGridViewUsuarios.Columns["Username"].HeaderText = "Usuario";
                if (dataGridViewUsuarios.Columns.Contains("Nombre"))
                    dataGridViewUsuarios.Columns["Nombre"].HeaderText = "Nombre";
                if (dataGridViewUsuarios.Columns.Contains("Apellido"))
                    dataGridViewUsuarios.Columns["Apellido"].HeaderText = "Apellido";
                if (dataGridViewUsuarios.Columns.Contains("Telefono"))
                    dataGridViewUsuarios.Columns["Telefono"].HeaderText = "Teléfono";
                if (dataGridViewUsuarios.Columns.Contains("Genero"))
                    dataGridViewUsuarios.Columns["Genero"].HeaderText = "Género";
                if (dataGridViewUsuarios.Columns.Contains("Estado"))
                    dataGridViewUsuarios.Columns["Estado"].HeaderText = "Estado Civil";
                if (dataGridViewUsuarios.Columns.Contains("Edad"))
                    dataGridViewUsuarios.Columns["Edad"].HeaderText = "Edad";
                if (dataGridViewUsuarios.Columns.Contains("Fecha"))
                    dataGridViewUsuarios.Columns["Fecha"].HeaderText = "Fecha Nac.";
            }
        }

        // Cargar los usernames en el ComboBox
        private void CargarUsuariosEnComboBox()
        {
            comboBoxSeleccionarUsuario.DataSource = null;
            comboBoxSeleccionarUsuario.DataSource = MemoriaClase.Memoria.Instancia.listaRegistros.ToList();
            comboBoxSeleccionarUsuario.DisplayMember = "Username";
            comboBoxSeleccionarUsuario.ValueMember = "Username";
        }

        // Evento: Al seleccionar un usuario del ComboBox
        private void comboBoxSeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeleccionarUsuario.SelectedItem != null)
            {
                var registro = (Registro)comboBoxSeleccionarUsuario.SelectedItem;
                CargarDatosEnCampos(registro);
                // Actualizar el índice también
                indiceUsuario = MemoriaClase.Memoria.Instancia.listaRegistros.IndexOf(registro);
            }
        }

        // Evento: Al hacer clic en una fila del DataGridView
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var registro = (Registro)dataGridViewUsuarios.Rows[e.RowIndex].DataBoundItem;
                CargarDatosEnCampos(registro);

                // Sincronizar ComboBox
                comboBoxSeleccionarUsuario.SelectedItem = registro;
                indiceUsuario = e.RowIndex;
            }
        }

        // Cargar datos del registro seleccionado en los campos
        private void CargarDatosEnCampos(Registro registro)
        {
            textUsername.Text = registro.Username;
            textNombre.Text = registro.Nombre;
            textApellido.Text = registro.Apellido;
            textDireccion.Text = registro.Direccion;
            maskedTextTelefono.Text = registro.Telefono;
            comboBoxGenero.SelectedItem = registro.Genero;

            // Convertir fecha de string a DateTime
            DateTime fechaNac;
            if (DateTime.TryParse(registro.Fecha, out fechaNac))
            {
                dtpFechaNacimiento.Value = fechaNac;
            }

            comboBoxEstado.SelectedItem = registro.Estado;
            textBoxEdad.Text = registro.Edad.ToString();
        }

        // Calcular edad al cambiar la fecha
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaNacimiento.Value;

            if (fechaSeleccionada > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual.", "Validación");
                textBoxEdad.Clear();
                return;
            }

            DateTime a_Nacimiento = dtpFechaNacimiento.Value;
            DateTime a_Actual = DateTime.Now;

            int calculo_Edad = (a_Actual.Year - a_Nacimiento.Year);

            if (a_Actual.Month < a_Nacimiento.Month)
            {
                calculo_Edad--;
            }
            else if (a_Actual.Month == a_Nacimiento.Month && a_Actual.Day < a_Nacimiento.Day)
            {
                calculo_Edad--;
            }

            textBoxEdad.Text = calculo_Edad.ToString();
        }
        // Validar datos (similar al registro)
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio", "Validación");
                return false;
            }
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación");
                return false;
            }
            if (string.IsNullOrEmpty(textApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio", "Validación");
                return false;
            }
            if (string.IsNullOrEmpty(textDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria", "Validación");
                return false;
            }
            if (string.IsNullOrEmpty(maskedTextTelefono.Text) || maskedTextTelefono.Text.Length < 13)
            {
                MessageBox.Show("Número de teléfono inválido (debe tener formato +58-XXX-XXXXXXX)", "Validación");
                return false;
            }
            if (comboBoxGenero.SelectedItem == null || comboBoxGenero.Text == "(Seleccionar)")
            {
                MessageBox.Show("Debe seleccionar un género", "Validación");
                return false;
            }
            if (string.IsNullOrEmpty(textBoxEdad.Text))
            {
                MessageBox.Show("Debe seleccionar una fecha de nacimiento válida", "Validación");
                return false;
            }
            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado civil", "Validación");
                return false;
            }

            return true;
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textApellido.Clear();
            textDireccion.Clear();
            maskedTextTelefono.Text = "";
            comboBoxGenero.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            comboBoxEstado.SelectedIndex = 0;
            textBoxEdad.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            // Buscar el registro original en la lista
            var registroOriginal = MemoriaClase.Memoria.Instancia.listaRegistros
                .FirstOrDefault(r => r.Username == textUsername.Text);

            if (registroOriginal != null)
            {
                // Actualizar propiedades
                registroOriginal.Nombre = textNombre.Text;
                registroOriginal.Apellido = textApellido.Text;
                registroOriginal.Direccion = textDireccion.Text;
                registroOriginal.Telefono = maskedTextTelefono.Text;
                registroOriginal.Genero = comboBoxGenero.Text;
                registroOriginal.Fecha = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
                registroOriginal.Estado = comboBoxEstado.Text;
                registroOriginal.Edad = int.Parse(textBoxEdad.Text);

                // Refrescar las vistas
                CargarListaEnDataGridView();
                CargarUsuariosEnComboBox();

                MessageBox.Show("Registro actualizado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el registro a actualizar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {

            if (comboBoxSeleccionarUsuario.SelectedItem != null)
            {
                var registro = (Registro)comboBoxSeleccionarUsuario.SelectedItem;
                CargarDatosEnCampos(registro);
            }
            else
            {
                MessageBox.Show("Seleccione un usuario primero.", "Aviso");
            }
        }
    }
}