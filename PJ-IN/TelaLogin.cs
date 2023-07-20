using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_IN
{
    public partial class TelaLogin : Form
    {
        Point mousePos;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            Conexao db = new Conexao();
            db.Conectar();

            if (db.BuscarUsuario(username, password))
            {
                if (db.EhAdm(username))
                {
                    TelaBemVindo bemVindo = new TelaBemVindo();
                    bemVindo.ExibirMensagem("Bem-vindo, administrador!");
                    bemVindo.ShowDialog();

                    TelaInicio inicio = new TelaInicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    TelaBemVindo bemVindo = new TelaBemVindo();
                    bemVindo.ExibirMensagem("Bem-vindo!");
                    bemVindo.ShowDialog();

                    TelaInicio inicio = new TelaInicio();
                    inicio.Show();
                    this.Hide();
                }

                this.Hide();
            }
            else
            {
                TelaErro erro = new TelaErro();
                erro.Show();
            }

            db.Desconectar();
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuário")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.FromArgb(107, 72, 142);

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuário";
                textBox1.ForeColor = Color.FromArgb(107, 72, 142);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.FromArgb(107, 72, 142);
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Senha";
                textBox2.ForeColor = Color.FromArgb(107, 72, 142);
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RedefinirSenha redefinirSenha = new RedefinirSenha();
            redefinirSenha.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePos = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mousePos.X;
                int deltaY = e.Y - mousePos.Y;

                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }
    }
}
