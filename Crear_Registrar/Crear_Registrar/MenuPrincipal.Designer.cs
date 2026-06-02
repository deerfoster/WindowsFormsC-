namespace Crear_Registrar
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE GESTIÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AccessibleName = "btnRegistrar";
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 80);
            button1.Name = "button1";
            button1.Size = new Size(250, 45);
            button1.TabIndex = 1;
            button1.Text = "📝 Registrar nuevo usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRegistrar_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnEditar";
            button2.BackColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(50, 140);
            button2.Name = "button2";
            button2.Size = new Size(250, 45);
            button2.TabIndex = 2;
            button2.Text = "✏️ Editar usuario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnEditar_Click;
            // 
            // button3
            // 
            button3.AccessibleName = "btnVerTodos";
            button3.BackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(50, 200);
            button3.Name = "button3";
            button3.Size = new Size(250, 45);
            button3.TabIndex = 3;
            button3.Text = "👁️ Ver todos los usuarios";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnVertodos_Click;
            // 
            // button4
            // 
            button4.AccessibleName = "btnReportes";
            button4.BackColor = Color.Violet;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(50, 260);
            button4.Name = "button4";
            button4.Size = new Size(250, 45);
            button4.TabIndex = 4;
            button4.Text = "📊 Reportes";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnReportes_Click;
            // 
            // button5
            // 
            button5.AccessibleName = "btnSalir";
            button5.BackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(50, 320);
            button5.Name = "button5";
            button5.Size = new Size(250, 45);
            button5.TabIndex = 5;
            button5.Text = "🚪 Salir del sistema";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "dgvUsuarios";
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(400, 80);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(400, 300);
            dataGridView1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.AccessibleName = "statusStrip1";
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AccessibleName = "statusMensaje";
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 20);
            toolStripStatusLabel1.Text = "Listo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(700, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(563, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(435, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}