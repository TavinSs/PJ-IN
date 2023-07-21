using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_IN
{
    public partial class RedefinirSenha : Form
    {
        Point mousePos;

        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                // Calcula a diferença entre a posição atual do mouse e a posição anterior do mouse
                int deltaX = e.X - mousePos.X;
                int deltaY = e.Y - mousePos.Y;

                // Atualiza a posição da janela
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            string usuario = textBox1.Text;

            var usuarioExiste = db.BuscaUser(usuario);
            db.Desconectar();

            if (!usuarioExiste)
            {
                MessageBox.Show("Usuário não encontrado.");
            }
            else
            {
                string novaSenha = textBox2.Text;
                string confirmarSenha = textBox3.Text;

                if (string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
                {
                    MessageBox.Show("Digite a nova senha e confirme-a.");
                    TelaBemVindo bemVindo = new TelaBemVindo();
                    bemVindo.ExibirMensagem("Digite a nova senha e confirme-a.");
                    bemVindo.ShowDialog();
                }
                else if (novaSenha != confirmarSenha)
                {
                    TelaBemVindo bemVindo = new TelaBemVindo();
                    bemVindo.ExibirMensagem("A nova senha e a confirmação \nnão coincidem.");
                    bemVindo.ShowDialog();
                }
                else if (novaSenha.Length < 3) 
                {
                    TelaBemVindo bemVindo = new TelaBemVindo();                  
                    bemVindo.ExibirMensagem("A nova senha deve ter \npelo menos 3 caracteres.");
                    bemVindo.ShowDialog();
                }
                else
                {
                    db.Conectar();
                    string sqlUsuario = $"UPDATE LoginUsuario SET Senha = @Senha WHERE Usuario = @Usuario";
                    SqlCommand comandoUsuario = new SqlCommand(sqlUsuario, db.conn);

                    // Use parâmetros para evitar ataques de injeção de SQL.
                    comandoUsuario.Parameters.AddWithValue("@Senha", novaSenha);
                    comandoUsuario.Parameters.AddWithValue("@Usuario", usuario);
                    comandoUsuario.ExecuteNonQuery();

                    TelaBemVindo bemVindo = new TelaBemVindo();
                    bemVindo.ExMensagem("Senha Redefinida.");
                    bemVindo.ShowDialog();

                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();
                    this.Hide();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
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
            if (textBox2.Text == "Nova Senha")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.FromArgb(107, 72, 142);

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nova Senha";
                textBox2.ForeColor = Color.FromArgb(107, 72, 142);
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Repetir Senha")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.FromArgb(107, 72, 142);

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Repetir Senha";
                textBox3.ForeColor = Color.FromArgb(107, 72, 142);
            }
        }
    }
}
