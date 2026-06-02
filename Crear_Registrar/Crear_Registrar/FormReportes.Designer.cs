namespace Crear_Registrar
{
    partial class FormReportes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 38);
            label1.TabIndex = 0;
            label1.Text = "REPORTES Y DETALLES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(30, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 200);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "📈 Estadísticas Generales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 161);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 4;
            label6.Text = "Edad Promedio: 0 años";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 131);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 3;
            label5.Text = "Otros: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 102);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "Mujeres: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 72);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Hombres: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 38);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 0;
            label2.Text = "Total de usuarios: 0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(450, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 350);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "👤 Detalles del Usuario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 278);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 5;
            label12.Text = "Estado: ---";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 180);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 4;
            label11.Text = "Edad: ---";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 131);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 3;
            label10.Text = "Usuario: ---";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 229);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 2;
            label9.Text = "Genero: ---";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 85);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 1;
            label8.Text = "Apellido: ---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 38);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 0;
            label7.Text = "Nombre: ---";
            // 
            // listBox1
            // 
            listBox1.AccessibleName = "";
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Seleccion" });
            listBox1.Location = new Point(20, 300);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 124);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.AccessibleName = "btnActualizar";
            button1.BackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 440);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 3;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnCerrar";
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(160, 440);
            button2.Name = "button2";
            button2.Size = new Size(130, 35);
            button2.TabIndex = 4;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 502);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormReportes";
            Text = "FormReportes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}