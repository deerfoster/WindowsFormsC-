using System;
using System.Linq;
using System.Windows.Forms;

namespace Crear_Registrar
{
    public partial class FormReportes : Form
    {
        private MemoriaClase.Memoria datos = MemoriaClase.Memoria.Instancia;

        public FormReportes()
        {
            InitializeComponent();

            this.Text = "Reportes y Detalles - Sistema de Gestión";
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarListaUsuarios();
            ActualizarEstadisticas();
        }

        private void CargarListaUsuarios()
        {
            listBox1.Items.Clear();
            foreach (var usuario in datos.listaRegistros)
            {
                listBox1.Items.Add($"{usuario.Nombre} {usuario.Apellido} - {usuario.Username}");
            }
        }

        private void ActualizarEstadisticas()
        {
            var usuarios = datos.listaRegistros;
            int total = usuarios.Count;
            int hombres = usuarios.Count(u => u.Genero == "Masculino");
            int mujeres = usuarios.Count(u => u.Genero == "Femenino");
            int otros = total - hombres - mujeres;
            double edadProm = total > 0 ? usuarios.Average(u => u.Edad) : 0;

            // Usa los mismos labels que en button1_Click
            label2.Text = $"Total usuarios: {total}";
            label3.Text = $"Hombres: {hombres}";
            label4.Text = $"Mujeres: {mujeres}";
            label5.Text = $"Otros: {otros}";
            label6.Text = $"Edad promedio: {edadProm:F1} años";
        }

        private void MostrarDetalles(int indice)
        {
            if (indice >= 0 && indice < datos.listaRegistros.Count)
            {
                var u = datos.listaRegistros[indice];

                // Buscar los labels dentro del GroupBox2
                foreach (Control ctrl in groupBox2.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        if (lbl.Text.Contains("Nombre"))
                            lbl.Text = $"Nombre: {u.Nombre}";
                        else if (lbl.Text.Contains("Apellido"))
                            lbl.Text = $"Apellido: {u.Apellido}";
                        else if (lbl.Text.Contains("Usuario"))
                            lbl.Text = $"Usuario: {u.Username}";
                        else if (lbl.Text.Contains("Edad"))
                            lbl.Text = $"Edad: {u.Edad} años";
                        else if (lbl.Text.Contains("Género") || lbl.Text.Contains("Genero"))
                            lbl.Text = $"Género: {u.Genero}";
                        else if (lbl.Text.Contains("Estado"))
                            lbl.Text = $"Estado: {u.Estado}";
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDetalles(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Recargar la lista de usuarios
                CargarListaUsuarios();

                // Actualizar estadísticas (usa el mismo método)
                ActualizarEstadisticas();

                // Actualizar detalles si hay algo seleccionado
                if (listBox1.SelectedIndex >= 0)
                {
                    MostrarDetalles(listBox1.SelectedIndex);
                }

                MessageBox.Show("Datos actualizados", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}