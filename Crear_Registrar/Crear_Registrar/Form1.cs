using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Crear_Registrar
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();

            generoBox.SelectedIndex = 0;
            estadoBox.SelectedIndex = 0;
            telefonoBox.Text = "+58";
        }
        public class Registro
        {
            private string username;
            private string nombre;
            private string apellido;
            private string direccion;
            private string telefono;
            private string genero;
            private string fechaNacimiento;
            private string estado;
            private int edad;
            public string Username
            {
                get { return username; }
                set { username = value; }
            }
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public string Apellido
            {
                get { return apellido; }
                set { apellido = value; }
            }
            public string Direccion
            {
                get { return direccion; }
                set { direccion = value; }
            }
            public string Telefono
            {
                get { return telefono; }
                set { telefono = value; }
            }
            public string Genero
            {
                get { return genero; }
                set { genero = value; }
            }
            public string Fecha
            {
                get { return fechaNacimiento; }
                set { fechaNacimiento = value; }
            }
            public string Estado
            {
                get { return estado; }
                set { estado = value; }
            }
            public int Edad
            {
                get { return edad; }
                set { edad = value; }
            }

            public Registro(string username, string nombre, string apellido, string direccion, string telefono, string genero, string fecha, string estado, int edad)
            {
                Username = username;
                Nombre = nombre;
                Apellido = apellido;
                Direccion = direccion;
                Telefono = telefono;
                Genero = genero;
                Fecha = fecha;
                Estado = estado;
                Edad = edad;
            }
        }
        private void generoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (generoBox.Text == "(Seleccionar)")
            {
                meowlImageBox.Image = Properties.Resources.meowl;
            }
            if (generoBox.Text == "Femenino")
            {
                meowlImageBox.Image = Properties.Resources.femeninoIcon;
            }
            if (generoBox.Text == "Masculino")
            {
                meowlImageBox.Image = Properties.Resources.masculinoIcon;
            }
            if (generoBox.Text == "Otro")
            {
                meowlImageBox.Image = Properties.Resources.noEspecificadoIcon;
            }

        }
        private void estadoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RegistroBoton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            if (string.IsNullOrEmpty(nombreBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            if (string.IsNullOrEmpty(apellidoBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            if (string.IsNullOrEmpty(direccionBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            if (string.IsNullOrEmpty(telefonoBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            if (telefonoBox.Text.Length != 13)
            {
                MessageBox.Show("Numero de telefono invalido");
                return;
            }
            if (generoBox.Text == "(Seleccionar)")
            {
                MessageBox.Show("Debe seleccionar un genero");
                return;
            }
            if (string.IsNullOrEmpty(edadBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            string fecha = fechaNacimientoBox.Value.ToString("dd/MM/yyyy");

            Registro nuevoUsuario = new Registro(
                usernameBox.Text,
                nombreBox.Text,
                apellidoBox.Text,
                direccionBox.Text,
                telefonoBox.Text,
                generoBox.Text,
                fecha,
                estadoBox.Text,
                int.Parse(edadBox.Text)
                );

            MemoriaClase.Memoria.Instancia.listaRegistros.Add(nuevoUsuario);
            MessageBox.Show("Te has registrado con exito.");
            LimpiarCamposFinalesRegistro();
        }
        private void LimpiarCamposFinalesRegistro()
        {
            usernameBox.Clear();
            nombreBox.Clear();
            apellidoBox.Clear();
            direccionBox.Clear();
            telefonoBox.Text = "+58";
            edadBox.Clear();
            generoBox.SelectedIndex = 0;
            estadoBox.SelectedIndex = 0;
        }
        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            nombreBox.Clear();
            apellidoBox.Clear();
            direccionBox.Clear();
            telefonoBox.Text = "+58";
            edadBox.Clear();
            generoBox.SelectedIndex = 0;
            estadoBox.SelectedIndex = 0;
        }
        private void fechaNacimientoBox_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = fechaNacimientoBox.Value;

            if (fechaSeleccionada > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual.");
                edadBox.Clear();
                return;
            }

            DateTime a_Nacimiento = fechaNacimientoBox.Value;
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

            edadBox.Text = calculo_Edad.ToString();
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
