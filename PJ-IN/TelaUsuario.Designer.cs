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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1=new Panel();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            panel2=new Panel();
            button5=new Button();
            pictureBox3=new PictureBox();
            button4=new Button();
            button3=new Button();
            button2=new Button();
            button1=new Button();
            dataGridView1=new DataGridView();
            dataGridView2=new DataGridView();
            Evento=new Label();
            label1=new Label();
            button6=new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel1.TabIndex=14;
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
            // panel2
            // 
            panel2.BackColor=Color.Gainsboro;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock=DockStyle.Left;
            panel2.Location=new Point(0, 65);
            panel2.Margin=new Padding(3, 4, 3, 4);
            panel2.Name="panel2";
            panel2.Size=new Size(311, 888);
            panel2.TabIndex=17;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize=0;
            button5.FlatStyle=FlatStyle.Flat;
            button5.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor=Color.FromArgb(107, 72, 142);
            button5.Location=new Point(0, 541);
            button5.Margin=new Padding(3, 4, 3, 4);
            button5.Name="button5";
            button5.Size=new Size(307, 79);
            button5.TabIndex=18;
            button5.Text="Faturas";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=button5_Click;
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
            // button3
            // 
            button3.FlatAppearance.BorderSize=0;
            button3.FlatStyle=FlatStyle.Flat;
            button3.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor=Color.FromArgb(107, 72, 142);
            button3.Location=new Point(0, 805);
            button3.Margin=new Padding(3, 4, 3, 4);
            button3.Name="button3";
            button3.Size=new Size(307, 79);
            button3.TabIndex=2;
            button3.Text="Sair";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor=Color.Gainsboro;
            dataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor=Color.FromArgb(107, 72, 122);
            dataGridViewCellStyle1.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor=Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor=Color.FromArgb(107, 72, 142);
            dataGridViewCellStyle1.SelectionForeColor=Color.Silver;
            dataGridViewCellStyle1.WrapMode=DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles=false;
            dataGridView1.GridColor=SystemColors.Control;
            dataGridView1.Location=new Point(435, 188);
            dataGridView1.Margin=new Padding(3, 4, 3, 4);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size(937, 169);
            dataGridView1.TabIndex=18;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor=Color.Gainsboro;
            dataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor=Color.FromArgb(107, 72, 122);
            dataGridViewCellStyle2.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor=Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor=Color.FromArgb(107, 72, 142);
            dataGridViewCellStyle2.SelectionForeColor=Color.Silver;
            dataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles=false;
            dataGridView2.GridColor=SystemColors.Control;
            dataGridView2.Location=new Point(435, 464);
            dataGridView2.Margin=new Padding(3, 4, 3, 4);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.RowTemplate.Height=25;
            dataGridView2.Size=new Size(937, 169);
            dataGridView2.TabIndex=19;
            // 
            // Evento
            // 
            Evento.AutoSize=true;
            Evento.Font=new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Evento.ForeColor=Color.FromArgb(107, 72, 142);
            Evento.Location=new Point(435, 125);
            Evento.Name="Evento";
            Evento.Size=new Size(281, 37);
            Evento.TabIndex=20;
            Evento.Text="DADOS DO SOCIO";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.FromArgb(107, 72, 142);
            label1.Location=new Point(435, 405);
            label1.Name="label1";
            label1.Size=new Size(364, 37);
            label1.TabIndex=21;
            label1.Text="DADOS DO DEPENDENTE";
            // 
            // button6
            // 
            button6.BackColor=Color.FromArgb(107, 72, 142);
            button6.FlatAppearance.BorderSize=0;
            button6.FlatStyle=FlatStyle.Flat;
            button6.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor=Color.White;
            button6.Location=new Point(435, 661);
            button6.Margin=new Padding(3, 4, 3, 4);
            button6.Name="button6";
            button6.Size=new Size(307, 79);
            button6.TabIndex=19;
            button6.Text="Modificar Dependentes";
            button6.UseVisualStyleBackColor=false;
            button6.Click+=button6_Click;
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1486, 953);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(Evento);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Margin=new Padding(3, 4, 3, 4);
            Name="TelaUsuario";
            StartPosition=FormStartPosition.CenterScreen;
            Text="TelaUsuario";
            Load+=TelaUsuario_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button5;
        private DataGridViewTextBoxColumn Nome;
        private DataGridView dataGridView2;
        private Label Evento;
        private Label label1;
        private Button button6;
    }
}