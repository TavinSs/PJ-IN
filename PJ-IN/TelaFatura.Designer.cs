namespace PJ_IN
{
    partial class TelaFatura
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
            panel1=new Panel();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            button1=new Button();
            button2=new Button();
            button4=new Button();
            pictureBox3=new PictureBox();
            panel2=new Panel();
            pictureBox4=new PictureBox();
            button3=new Button();
            dataGridView1=new DataGridView();
            button5=new Button();
            Evento=new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(107, 72, 142);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock=DockStyle.Top;
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(1486, 65);
            panel1.TabIndex=15;
            panel1.MouseDown+=panel1_MouseDown;
            panel1.MouseMove+=panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.icons8_minimizar_50__1_;
            pictureBox1.Location=new Point(1399, 16);
            pictureBox1.Margin=new Padding(3, 4, 3, 4);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(33, 41);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.icons8_excluir_50__1_;
            pictureBox2.Location=new Point(1439, 16);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(33, 41);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=0;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize=0;
            button1.FlatStyle=FlatStyle.Flat;
            button1.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor=Color.FromArgb(107, 72, 142);
            button1.Location=new Point(0, 281);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(311, 79);
            button1.TabIndex=0;
            button1.Text="Inicio";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize=0;
            button2.FlatStyle=FlatStyle.Flat;
            button2.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor=Color.FromArgb(107, 72, 142);
            button2.Location=new Point(0, 368);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Size=new Size(311, 79);
            button2.TabIndex=1;
            button2.Text="Eventos";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize=0;
            button4.FlatStyle=FlatStyle.Flat;
            button4.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor=Color.FromArgb(107, 72, 142);
            button4.Location=new Point(3, 455);
            button4.Margin=new Padding(3, 4, 3, 4);
            button4.Name="button4";
            button4.Size=new Size(307, 79);
            button4.TabIndex=3;
            button4.Text="Exames";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor=Color.Gainsboro;
            pictureBox3.Image=Properties.Resources.logo_removebg_preview;
            pictureBox3.Location=new Point(0, 0);
            pictureBox3.Margin=new Padding(3, 4, 3, 4);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(311, 252);
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex=17;
            pictureBox3.TabStop=false;
            // 
            // panel2
            // 
            panel2.BackColor=Color.Gainsboro;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock=DockStyle.Left;
            panel2.Location=new Point(0, 65);
            panel2.Margin=new Padding(3, 4, 3, 4);
            panel2.Name="panel2";
            panel2.Size=new Size(311, 888);
            panel2.TabIndex=16;
            // 
            // pictureBox4
            // 
            pictureBox4.Image=Properties.Resources.icons8_usuário_homem_com_círculo_48;
            pictureBox4.Location=new Point(229, 805);
            pictureBox4.Margin=new Padding(3, 4, 3, 4);
            pictureBox4.Name="pictureBox4";
            pictureBox4.Size=new Size(79, 79);
            pictureBox4.SizeMode=PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex=22;
            pictureBox4.TabStop=false;
            pictureBox4.Click+=pictureBox4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize=0;
            button3.FlatStyle=FlatStyle.Flat;
            button3.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor=Color.FromArgb(107, 72, 142);
            button3.Location=new Point(0, 805);
            button3.Margin=new Padding(3, 4, 3, 4);
            button3.Name="button3";
            button3.Size=new Size(222, 79);
            button3.TabIndex=21;
            button3.Text="Sair";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor=Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(451, 232);
            dataGridView1.Margin=new Padding(3, 4, 3, 4);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size(819, 488);
            dataGridView1.TabIndex=17;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick+=dataGridView1_CellDoubleClick;
            // 
            // button5
            // 
            button5.BackColor=Color.FromArgb(107, 72, 142);
            button5.FlatAppearance.BorderSize=0;
            button5.FlatStyle=FlatStyle.Flat;
            button5.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor=Color.White;
            button5.Location=new Point(750, 749);
            button5.Margin=new Padding(3, 4, 3, 4);
            button5.Name="button5";
            button5.Size=new Size(244, 62);
            button5.TabIndex=18;
            button5.Text="GERAR BOLETO";
            button5.UseVisualStyleBackColor=false;
            button5.Click+=button5_Click;
            // 
            // Evento
            // 
            Evento.AutoSize=true;
            Evento.Font=new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Evento.ForeColor=Color.FromArgb(107, 72, 142);
            Evento.Location=new Point(451, 178);
            Evento.Name="Evento";
            Evento.Size=new Size(121, 37);
            Evento.TabIndex=21;
            Evento.Text="Faturas";
            // 
            // TelaFatura
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1486, 953);
            Controls.Add(Evento);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Margin=new Padding(3, 4, 3, 4);
            Name="TelaFatura";
            StartPosition=FormStartPosition.CenterScreen;
            Text="TelaFatura";
            Load+=TelaFatura_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button5;
        private Label Evento;
    }
}