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
    public partial class TelaUsuario : Form
    {
        Point mousePos;

        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            var socios = db.DadosUsuario();
            dataGridView1.DataSource = socios;
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

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicio inicio = new TelaInicio();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaEventos eventos = new TelaEventos();
            eventos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaExame exame = new TelaExame();
            exame.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaFatura telaFatura = new TelaFatura();
            telaFatura.Show();
            this.Hide();
        }

        private void TelaUsuario_Load_1(object sender, EventArgs e)
        {

        }
    }
}
