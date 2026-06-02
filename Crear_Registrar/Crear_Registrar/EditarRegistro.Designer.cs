namespace Crear_Registrar
{
    partial class EditarRegistro
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

        private ComboBox GetComboBoxSeleccionarUsuario1()
        {
            return comboBoxSeleccionarUsuario;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBoxSeleccionarUsuario = new ComboBox();
            groupBox2 = new GroupBox();
            labelUsername = new Label();
            textUsername = new TextBox();
            labelNombre = new Label();
            textNombre = new TextBox();
            labelApellido = new Label();
            textApellido = new TextBox();
            labelDireccion = new Label();
            textDireccion = new TextBox();
            labelTelefono = new Label();
            maskedTextTelefono = new MaskedTextBox();
            labelGenero = new Label();
            comboBoxGenero = new ComboBox();
            labelFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            labelEdad = new Label();
            textBoxEdad = new TextBox();
            labelEstado = new Label();
            comboBoxEstado = new ComboBox();
            dataGridViewUsuarios = new DataGridView();
            buttonCargar = new Button();
            buttonActualizar = new Button();
            buttonLimpiar = new Button();
            buttonCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxSeleccionarUsuario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Usuario";
            // 
            // comboBoxSeleccionarUsuario
            // 
            comboBoxSeleccionarUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeleccionarUsuario.FormattingEnabled = true;
            comboBoxSeleccionarUsuario.Location = new Point(20, 35);
            comboBoxSeleccionarUsuario.Name = "comboBoxSeleccionarUsuario";
            comboBoxSeleccionarUsuario.Size = new Size(200, 40);
            comboBoxSeleccionarUsuario.TabIndex = 0;
            comboBoxSeleccionarUsuario.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(270, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Registro";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(714, 51);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(126, 32);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            // 
            // textUsername
            // 
            textUsername.BackColor = SystemColors.GrayText;
            textUsername.Location = new Point(714, 111);
            textUsername.Name = "textUsername";
            textUsername.ReadOnly = true;
            textUsername.Size = new Size(200, 39);
            textUsername.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(714, 168);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(107, 32);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(714, 225);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(200, 39);
            textNombre.TabIndex = 4;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(714, 297);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(107, 32);
            labelApellido.TabIndex = 0;
            labelApellido.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(714, 351);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(200, 39);
            textApellido.TabIndex = 5;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(714, 425);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(119, 32);
            labelDireccion.TabIndex = 6;
            labelDireccion.Text = "Direccion:";
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(714, 489);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(200, 39);
            textDireccion.TabIndex = 7;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(714, 565);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(112, 32);
            labelTelefono.TabIndex = 8;
            labelTelefono.Text = "Telefono:";
            // 
            // maskedTextTelefono
            // 
            maskedTextTelefono.Location = new Point(714, 626);
            maskedTextTelefono.Mask = "+58-000-000000";
            maskedTextTelefono.Name = "maskedTextTelefono";
            maskedTextTelefono.Size = new Size(200, 39);
            maskedTextTelefono.TabIndex = 9;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(1001, 51);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(97, 32);
            labelGenero.TabIndex = 10;
            labelGenero.Text = "Genero:";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "(Seleccionar)", "Femenino", "Masculino", "Otro" });
            comboBoxGenero.Location = new Point(1010, 111);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(242, 40);
            comboBoxGenero.TabIndex = 11;
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(1010, 181);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(245, 32);
            labelFechaNacimiento.TabIndex = 12;
            labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(1010, 251);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(208, 39);
            dtpFechaNacimiento.TabIndex = 13;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(1020, 318);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(71, 32);
            labelEdad.TabIndex = 14;
            labelEdad.Text = "Edad:";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(1020, 386);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.ReadOnly = true;
            textBoxEdad.Size = new Size(200, 39);
            textBoxEdad.TabIndex = 15;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(1013, 459);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(89, 32);
            labelEstado.TabIndex = 16;
            labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Amazonas", "Anzoátegui", "Apure", "Aragua", "Barinas", "Bolívar", "Carabobo", "Cojedes", "Delta Amacuro", "Falcón", "Guárico", "Lara", "Mérida", "Miranda", "Monagas", "Nueva Esparta", "Portuguesa", "Sucre", "Táchira", "Trujillo", "La Guaira", "Yaracuy", "Zulia", "Distrito Capital / Caracas ", "Dependencias Federales " });
            comboBoxEstado.Location = new Point(1013, 531);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(242, 40);
            comboBoxEstado.TabIndex = 17;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(47, 598);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 82;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(480, 302);
            dataGridViewUsuarios.TabIndex = 18;
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(18, 93);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(100, 40);
            buttonCargar.TabIndex = 0;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(784, 726);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(150, 46);
            buttonActualizar.TabIndex = 19;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(1020, 726);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(150, 46);
            buttonLimpiar.TabIndex = 20;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(1176, 735);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(150, 46);
            buttonCancelar.TabIndex = 21;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // EditarRegistro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 912);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonCargar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonActualizar);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelEstado);
            Controls.Add(textBoxEdad);
            Controls.Add(labelEdad);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(comboBoxGenero);
            Controls.Add(labelGenero);
            Controls.Add(maskedTextTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(textDireccion);
            Controls.Add(labelDireccion);
            Controls.Add(textApellido);
            Controls.Add(labelApellido);
            Controls.Add(textNombre);
            Controls.Add(labelNombre);
            Controls.Add(textUsername);
            Controls.Add(labelUsername);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EditarRegistro";
            Text = "Editor";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxSeleccionarUsuario;
        private GroupBox groupBox2;
        private Label labelUsername;
        private TextBox textUsername;
        private Label labelNombre;
        private TextBox textNombre;
        private Label labelApellido;
        private TextBox textApellido;
        private Label labelDireccion;
        private TextBox textDireccion;
        private Label labelTelefono;
        private MaskedTextBox maskedTextTelefono;
        private Label labelGenero;
        private ComboBox comboBoxGenero;
        private Label labelFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label labelEdad;
        private TextBox textBoxEdad;
        private DataGridView dataGridViewUsuarios;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private Button buttonCargar;
        private Button buttonActualizar;
        private Button buttonLimpiar;
        private Button buttonCancelar;
    }
}