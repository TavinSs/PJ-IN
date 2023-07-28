namespace PJ_IN
{
    partial class TelaLogin
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
            button1=new Button();
            label1=new Label();
            pictureBox1=new PictureBox();
            panel1=new Panel();
            pictureBox2=new PictureBox();
            textBox1=new TextBox();
            textBox2=new TextBox();
            label2=new Label();
            linkLabel1=new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor=Color.FromArgb(107, 72, 142);
            button1.Cursor=Cursors.Hand;
            button1.FlatAppearance.BorderSize=0;
            button1.FlatAppearance.MouseDownBackColor=Color.FromArgb(107, 72, 142);
            button1.FlatAppearance.MouseOverBackColor=Color.FromArgb(86, 54, 118);
            button1.FlatStyle=FlatStyle.Flat;
            button1.Font=new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=Color.Silver;
            button1.Location=new Point(602, 456);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(163, 75);
            button1.TabIndex=14;
            button1.Text="Entrar";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=Color.FromArgb(107, 72, 142);
            label1.Location=new Point(538, 217);
            label1.Name="label1";
            label1.Size=new Size(123, 37);
            label1.TabIndex=13;
            label1.Text="Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=SystemColors.Control;
            pictureBox1.Image=Properties.Resources.My_project_1;
            pictureBox1.Location=new Point(-32, 88);
            pictureBox1.Margin=new Padding(3, 4, 3, 4);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(492, 511);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=16;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(107, 72, 142);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock=DockStyle.Top;
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(934, 65);
            panel1.TabIndex=12;
            panel1.MouseDown+=panel1_MouseDown;
            panel1.MouseMove+=panel1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.icons8_excluir_50__1_;
            pictureBox2.Location=new Point(887, 16);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(33, 41);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=0;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.AllowDrop=true;
            textBox1.BackColor=Color.Gainsboro;
            textBox1.BorderStyle=BorderStyle.None;
            textBox1.Font=new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor=Color.FromArgb(107, 72, 142);
            textBox1.Location=new Point(535, 261);
            textBox1.Margin=new Padding(3, 4, 3, 4);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(318, 33);
            textBox1.TabIndex=17;
            textBox1.Text="Usuário";
            textBox1.Enter+=textBox1_Enter;
            textBox1.Leave+=textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.AllowDrop=true;
            textBox2.BackColor=Color.Gainsboro;
            textBox2.BorderStyle=BorderStyle.None;
            textBox2.Font=new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor=Color.FromArgb(107, 72, 142);
            textBox2.Location=new Point(535, 364);
            textBox2.Margin=new Padding(3, 4, 3, 4);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(318, 33);
            textBox2.TabIndex=19;
            textBox2.Text="Senha";
            textBox2.Enter+=textBox2_Enter;
            textBox2.Leave+=textBox2_Leave;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor=Color.FromArgb(107, 72, 142);
            label2.Location=new Point(535, 320);
            label2.Name="label2";
            label2.Size=new Size(107, 37);
            label2.TabIndex=18;
            label2.Text="Senha";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor=Color.FromArgb(107, 72, 162);
            linkLabel1.AutoSize=true;
            linkLabel1.LinkColor=Color.FromArgb(107, 72, 142);
            linkLabel1.Location=new Point(538, 403);
            linkLabel1.Name="linkLabel1";
            linkLabel1.Size=new Size(113, 20);
            linkLabel1.TabIndex=20;
            linkLabel1.TabStop=true;
            linkLabel1.Text="Redefinir Senha";
            linkLabel1.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(934, 657);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Margin=new Padding(3, 4, 3, 4);
            Name="TelaLogin";
            StartPosition=FormStartPosition.CenterScreen;
            Text="TelaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}