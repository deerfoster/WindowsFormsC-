using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
                // === Configurar DataGridView automáticamente ===
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
                    dgv.DataSource = null;
                    dgv.DataSource = datos.listaRegistros;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // === Configurar StatusStrip automáticamente ===
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
                MessageBox.Show($"Error: {ex.Message}");
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

        private void btnEditar_Click(object sender, EventArgs e)  // Editar
        {
            MessageBox.Show("Funcionalidad de edición - La hará otro compañero",
                            "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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