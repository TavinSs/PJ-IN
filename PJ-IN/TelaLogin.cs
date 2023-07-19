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
            Conexao db = new Conexao();
            db.Conectar();

            UsuarioBanco usuario = new UsuarioBanco();
            usuario.Usuario = textBox1.Text;
            usuario.Senha = textBox2.Text;



            var retorno = db.BuscarUsuario(usuario.Usuario, usuario.Senha);

            if (!retorno)
            {
                MessageBox.Show("Senha incorreta!  \nTente Novamente");
            }
            if (retorno)
            {
                MessageBox.Show("Bem-Vindo");

                TelaInicio inicio = new TelaInicio();
                inicio.Show();
                this.Hide();
            }

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
    }
}
