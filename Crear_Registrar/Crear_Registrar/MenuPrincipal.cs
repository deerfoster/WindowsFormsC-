using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Crear_Registrar.registro;

namespace Crear_Registrar
{
    public partial class MenuPrincipal : Form
    {
        private MemoriaClase.Memoria datos = MemoriaClase.Memoria.Instancia;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.Text = "Menú Principal - Sistema de Gestión";
            this.Size = new Size(850, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.PaleTurquoise; ;

            // Configurar todo automáticamente (sin nombres)
            ConfigurarTodo();
        }

        private void ConfigurarTodo()
        {
            try
            {
                // Buscar el DataGridView
                DataGridView dgv = null;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is DataGridView)
                    {
                        dgv = (DataGridView)ctrl;
                        break;
                    }
                }

                if (dgv != null)
                {
                    // Configuración básica
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.MultiSelect = false;
                    dgv.ReadOnly = true;

                    // Cargar datos
                    dgv.DataSource = null;
                    dgv.DataSource = datos.listaRegistros;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Limpiar selección al cargar
                    dgv.ClearSelection();

                    // Evento seguro para selección (sin errores)
                    dgv.CellClick += (s, ev) =>
                    {
                        if (ev.RowIndex >= 0 && ev.RowIndex < datos.listaRegistros.Count)
                        {
                            // Selección exitosa
                            System.Diagnostics.Debug.WriteLine($"Fila {ev.RowIndex} seleccionada");
                        }
                    };
                }

                // Configurar StatusStrip
                StatusStrip strip = null;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is StatusStrip)
                    {
                        strip = (StatusStrip)ctrl;
                        break;
                    }
                }

                if (strip != null)
                {
                    foreach (ToolStripItem item in strip.Items)
                    {
                        if (item is ToolStripStatusLabel label)
                        {
                            label.Text = $"Total usuarios registrados: {datos.listaRegistros.Count}";
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDatos()
        {
            ConfigurarTodo();
        }

        // ===== EVENTOS DE BOTONES =====

        private void btnRegistrar_Click(object sender, EventArgs e)  // Registrar
        {
            registro formRegistro = new registro();
            formRegistro.ShowDialog();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar el DataGridView
                DataGridView dgv = null;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is DataGridView)
                    {
                        dgv = (DataGridView)ctrl;
                        break;
                    }
                }

                if (dgv == null)
                {
                    MessageBox.Show("No se encontró la tabla");
                    return;
                }

                // === MÉTODO ALTERNATIVO: Buscar por fila seleccionada ===
                int indiceSeleccionado = -1;

                // Opción 1: Revisar CurrentRow
                if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
                {
                    indiceSeleccionado = dgv.CurrentRow.Index;
                }

                // Opción 2: Revisar SelectedRows
                if (indiceSeleccionado == -1 && dgv.SelectedRows.Count > 0)
                {
                    indiceSeleccionado = dgv.SelectedRows[0].Index;
                }

                // Opción 3: Revisar SelectedCells
                if (indiceSeleccionado == -1 && dgv.SelectedCells.Count > 0)
                {
                    indiceSeleccionado = dgv.SelectedCells[0].RowIndex;
                }

                // Si no hay selección, mostrar mensaje
                if (indiceSeleccionado == -1)
                {
                    MessageBox.Show("Para editar, primero haz CLIC en el número gris de la izquierda de la fila que quieras editar.\n\nLuego presiona el botón Editar.",
                                    "Cómo seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Verificar que el índice sea válido
                if (indiceSeleccionado >= datos.listaRegistros.Count)
                {
                    MessageBox.Show("Error: Usuario no encontrado");
                    return;
                }

                // Obtener el usuario
                Registro usuario = datos.listaRegistros[indiceSeleccionado];

                // Confirmar selección
                DialogResult confirmar = MessageBox.Show($"Editar a: {usuario.Nombre} {usuario.Apellido}?\nUsuario: {usuario.Username}",
                                                           "Confirmar edición",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    // Abrir formulario de edición
                    EditarRegistro formEditar = new EditarRegistro(usuario, indiceSeleccionado);
                    formEditar.ShowDialog();
                    ActualizarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\n{ex.StackTrace}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVertodos_Click(object sender, EventArgs e)  // Ver todos
        {
            ActualizarDatos();
            MessageBox.Show("Datos actualizados", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReportes_Click(object sender, EventArgs e)  // Reportes
        {
            FormReportes formReportes = new FormReportes();
            formReportes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)  // Salir
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de salir?",
                                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Application.Exit();
        }
    }
}