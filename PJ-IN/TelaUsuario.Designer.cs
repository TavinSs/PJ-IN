namespace PJ_IN
{
    partial class TelaUsuario
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 72, 142);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 49);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_minimizar_50__1_;
            pictureBox1.Location = new Point(1224, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_excluir_50__1_;
            pictureBox2.Location = new Point(1259, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 666);
            panel2.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_usuário_homem_com_círculo_48;
            pictureBox4.Location = new Point(197, 604);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.Image = Properties.Resources.logo_removebg_preview;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(272, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(107, 72, 142);
            button4.Location = new Point(3, 341);
            button4.Name = "button4";
            button4.Size = new Size(269, 59);
            button4.TabIndex = 3;
            button4.Text = "Exames";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(107, 72, 142);
            button3.Location = new Point(0, 604);
            button3.Name = "button3";
            button3.Size = new Size(180, 59);
            button3.TabIndex = 2;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(107, 72, 142);
            button2.Location = new Point(0, 276);
            button2.Name = "button2";
            button2.Size = new Size(272, 59);
            button2.TabIndex = 1;
            button2.Text = "Eventos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(107, 72, 142);
            button1.Location = new Point(0, 211);
            button1.Name = "button1";
            button1.Size = new Size(272, 59);
            button1.TabIndex = 0;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(412, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(676, 315);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 715);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaUsuario";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}