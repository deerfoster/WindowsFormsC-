namespace Crear_Registrar
{
    partial class registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombreBox = new TextBox();
            apellidoBox = new TextBox();
            nombreText = new Label();
            apellidoText = new Label();
            telefonoText = new Label();
            fechaNacimientoBox = new DateTimePicker();
            telefonoBox = new TextBox();
            fechaDeNacimientoText = new Label();
            generoBox = new ComboBox();
            generoText = new Label();
            direccionBox = new TextBox();
            direccionText = new Label();
            estadoBox = new ComboBox();
            estadoText = new Label();
            edadText = new Label();
            RegistroBoton = new Button();
            usernameBox = new TextBox();
            usernameText = new Label();
            meowlImageBox = new PictureBox();
            bienvenidaText = new Label();
            descripcionText = new Label();
            LimpiarButton = new Button();
            cancelarButton = new Button();
            edadBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)meowlImageBox).BeginInit();
            SuspendLayout();
            // 
            // nombreBox
            // 
            nombreBox.Font = new Font("Segoe UI", 12F);
            nombreBox.Location = new Point(65, 313);
            nombreBox.Multiline = true;
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(378, 36);
            nombreBox.TabIndex = 0;
            // 
            // apellidoBox
            // 
            apellidoBox.Font = new Font("Segoe UI", 12F);
            apellidoBox.Location = new Point(65, 413);
            apellidoBox.Multiline = true;
            apellidoBox.Name = "apellidoBox";
            apellidoBox.Size = new Size(378, 36);
            apellidoBox.TabIndex = 1;
            // 
            // nombreText
            // 
            nombreText.AutoSize = true;
            nombreText.Font = new Font("Segoe UI", 13F);
            nombreText.Location = new Point(65, 270);
            nombreText.Name = "nombreText";
            nombreText.Size = new Size(99, 30);
            nombreText.TabIndex = 3;
            nombreText.Text = "Nombre:";
            // 
            // apellidoText
            // 
            apellidoText.AutoSize = true;
            apellidoText.Font = new Font("Segoe UI", 13F);
            apellidoText.Location = new Point(66, 371);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(98, 30);
            apellidoText.TabIndex = 4;
            apellidoText.Text = "Apellido:";
            // 
            // telefonoText
            // 
            telefonoText.AutoSize = true;
            telefonoText.Font = new Font("Segoe UI", 13F);
            telefonoText.Location = new Point(489, 493);
            telefonoText.Name = "telefonoText";
            telefonoText.Size = new Size(102, 30);
            telefonoText.TabIndex = 5;
            telefonoText.Text = "Telefono:";
            // 
            // fechaNacimientoBox
            // 
            fechaNacimientoBox.CalendarFont = new Font("Segoe UI", 9F);
            fechaNacimientoBox.Font = new Font("Segoe UI", 12F);
            fechaNacimientoBox.Location = new Point(489, 206);
            fechaNacimientoBox.Name = "fechaNacimientoBox";
            fechaNacimientoBox.Size = new Size(378, 34);
            fechaNacimientoBox.TabIndex = 6;
            fechaNacimientoBox.Value = new DateTime(2026, 5, 31, 0, 47, 50, 0);
            fechaNacimientoBox.ValueChanged += fechaNacimientoBox_ValueChanged;
            // 
            // telefonoBox
            // 
            telefonoBox.Font = new Font("Segoe UI", 12F);
            telefonoBox.Location = new Point(489, 526);
            telefonoBox.Multiline = true;
            telefonoBox.Name = "telefonoBox";
            telefonoBox.Size = new Size(378, 36);
            telefonoBox.TabIndex = 7;
            // 
            // fechaDeNacimientoText
            // 
            fechaDeNacimientoText.AutoSize = true;
            fechaDeNacimientoText.Font = new Font("Segoe UI", 13F);
            fechaDeNacimientoText.Location = new Point(489, 162);
            fechaDeNacimientoText.Name = "fechaDeNacimientoText";
            fechaDeNacimientoText.Size = new Size(221, 30);
            fechaDeNacimientoText.TabIndex = 8;
            fechaDeNacimientoText.Text = "Fecha de Nacimiento:";
            // 
            // generoBox
            // 
            generoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            generoBox.Font = new Font("Segoe UI", 12F);
            generoBox.FormattingEnabled = true;
            generoBox.Items.AddRange(new object[] { "(Seleccionar)", "Femenino", "Masculino", "Otro" });
            generoBox.Location = new Point(707, 313);
            generoBox.Name = "generoBox";
            generoBox.Size = new Size(160, 36);
            generoBox.TabIndex = 10;
            generoBox.SelectedIndexChanged += generoBox_SelectedIndexChanged;
            // 
            // generoText
            // 
            generoText.AutoSize = true;
            generoText.Font = new Font("Segoe UI", 13F);
            generoText.Location = new Point(707, 270);
            generoText.Name = "generoText";
            generoText.Size = new Size(90, 30);
            generoText.TabIndex = 11;
            generoText.Text = "Genero:";
            // 
            // direccionBox
            // 
            direccionBox.Font = new Font("Segoe UI", 12F);
            direccionBox.Location = new Point(65, 526);
            direccionBox.Multiline = true;
            direccionBox.Name = "direccionBox";
            direccionBox.Size = new Size(378, 36);
            direccionBox.TabIndex = 13;
            // 
            // direccionText
            // 
            direccionText.AutoSize = true;
            direccionText.Font = new Font("Segoe UI", 13F);
            direccionText.Location = new Point(65, 484);
            direccionText.Name = "direccionText";
            direccionText.Size = new Size(108, 30);
            direccionText.TabIndex = 12;
            direccionText.Text = "Direccion:";
            // 
            // estadoBox
            // 
            estadoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoBox.Font = new Font("Segoe UI", 12F);
            estadoBox.FormattingEnabled = true;
            estadoBox.Items.AddRange(new object[] { "Amazonas", "Anzoátegui", "Apure", "Aragua", "Barinas", "Bolívar", "Carabobo", "Cojedes", "Delta Amacuro", "Falcón", "Guárico", "Lara", "Mérida", "Miranda", "Monagas", "Nueva Esparta", "Portuguesa", "Sucre", "Táchira", "Trujillo", "La Guaira", "Yaracuy", "Zulia", "Distrito Capital / Caracas ", "Dependencias Federales " });
            estadoBox.Location = new Point(489, 413);
            estadoBox.Name = "estadoBox";
            estadoBox.Size = new Size(378, 36);
            estadoBox.TabIndex = 14;
            estadoBox.SelectedIndexChanged += estadoBox_SelectedIndexChanged;
            // 
            // estadoText
            // 
            estadoText.AutoSize = true;
            estadoText.Font = new Font("Segoe UI", 13F);
            estadoText.Location = new Point(489, 371);
            estadoText.Name = "estadoText";
            estadoText.Size = new Size(82, 30);
            estadoText.TabIndex = 15;
            estadoText.Text = "Estado:";
            // 
            // edadText
            // 
            edadText.AutoSize = true;
            edadText.Font = new Font("Segoe UI", 13F);
            edadText.Location = new Point(489, 270);
            edadText.Name = "edadText";
            edadText.Size = new Size(61, 30);
            edadText.TabIndex = 17;
            edadText.Text = "Edad";
            // 
            // RegistroBoton
            // 
            RegistroBoton.BackColor = SystemColors.ActiveCaption;
            RegistroBoton.FlatAppearance.BorderColor = Color.DarkCyan;
            RegistroBoton.FlatStyle = FlatStyle.Flat;
            RegistroBoton.Font = new Font("Segoe UI", 10F);
            RegistroBoton.Location = new Point(505, 599);
            RegistroBoton.Name = "RegistroBoton";
            RegistroBoton.Size = new Size(101, 36);
            RegistroBoton.TabIndex = 18;
            RegistroBoton.Text = "Registrar";
            RegistroBoton.UseVisualStyleBackColor = false;
            RegistroBoton.Click += RegistroBoton_Click;
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Segoe UI", 12F);
            usernameBox.Location = new Point(65, 215);
            usernameBox.Multiline = true;
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(378, 36);
            usernameBox.TabIndex = 21;
            // 
            // usernameText
            // 
            usernameText.AutoSize = true;
            usernameText.Font = new Font("Segoe UI", 13F);
            usernameText.Location = new Point(65, 172);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(116, 30);
            usernameText.TabIndex = 22;
            usernameText.Text = "Username:";
            // 
            // meowlImageBox
            // 
            meowlImageBox.InitialImage = null;
            meowlImageBox.Location = new Point(92, 24);
            meowlImageBox.Name = "meowlImageBox";
            meowlImageBox.Size = new Size(125, 118);
            meowlImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            meowlImageBox.TabIndex = 23;
            meowlImageBox.TabStop = false;
            // 
            // bienvenidaText
            // 
            bienvenidaText.AutoSize = true;
            bienvenidaText.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bienvenidaText.Location = new Point(235, 51);
            bienvenidaText.Name = "bienvenidaText";
            bienvenidaText.Size = new Size(161, 31);
            bienvenidaText.TabIndex = 24;
            bienvenidaText.Text = "Bienvenido/a!";
            // 
            // descripcionText
            // 
            descripcionText.AutoSize = true;
            descripcionText.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descripcionText.Location = new Point(235, 94);
            descripcionText.Name = "descripcionText";
            descripcionText.Size = new Size(623, 23);
            descripcionText.TabIndex = 25;
            descripcionText.Text = "Para completar su registro complete correctamente cada campo a continuacion.";
            // 
            // LimpiarButton
            // 
            LimpiarButton.BackColor = SystemColors.ActiveCaption;
            LimpiarButton.FlatAppearance.BorderColor = Color.DarkCyan;
            LimpiarButton.FlatStyle = FlatStyle.Flat;
            LimpiarButton.Font = new Font("Segoe UI", 10F);
            LimpiarButton.Location = new Point(625, 599);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(101, 36);
            LimpiarButton.TabIndex = 26;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = false;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = SystemColors.ActiveCaption;
            cancelarButton.FlatAppearance.BorderColor = Color.DarkCyan;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Segoe UI", 10F);
            cancelarButton.Location = new Point(746, 599);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(101, 36);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // edadBox
            // 
            edadBox.Font = new Font("Segoe UI", 12F);
            edadBox.Location = new Point(489, 313);
            edadBox.Multiline = true;
            edadBox.Name = "edadBox";
            edadBox.ReadOnly = true;
            edadBox.Size = new Size(173, 36);
            edadBox.TabIndex = 16;
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(943, 680);
            Controls.Add(cancelarButton);
            Controls.Add(LimpiarButton);
            Controls.Add(descripcionText);
            Controls.Add(bienvenidaText);
            Controls.Add(meowlImageBox);
            Controls.Add(usernameText);
            Controls.Add(usernameBox);
            Controls.Add(RegistroBoton);
            Controls.Add(edadText);
            Controls.Add(edadBox);
            Controls.Add(estadoText);
            Controls.Add(estadoBox);
            Controls.Add(direccionBox);
            Controls.Add(direccionText);
            Controls.Add(generoText);
            Controls.Add(generoBox);
            Controls.Add(fechaDeNacimientoText);
            Controls.Add(telefonoBox);
            Controls.Add(fechaNacimientoBox);
            Controls.Add(telefonoText);
            Controls.Add(apellidoText);
            Controls.Add(nombreText);
            Controls.Add(apellidoBox);
            Controls.Add(nombreBox);
            Name = "registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)meowlImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreBox;
        private TextBox apellidoBox;
        private Label nombreText;
        private Label apellidoText;
        private Label telefonoText;
        private DateTimePicker fechaNacimientoBox;
        private TextBox telefonoBox;
        private Label fechaDeNacimientoText;
        private ComboBox generoBox;
        private Label generoText;
        private TextBox direccionBox;
        private Label direccionText;
        private ComboBox estadoBox;
        private Label estadoText;
        private Label edadText;
        private Button RegistroBoton;
        private TextBox usernameBox;
        private Label usernameText;
        private PictureBox meowlImageBox;
        private Label bienvenidaText;
        private Label descripcionText;
        private Button LimpiarButton;
        private Button cancelarButton;
        private TextBox edadBox;
    }
}
