using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_IN
{
    public partial class TelaCadastro : Form
    {
        Point mousePos;
        public TelaCadastro()
        {
            InitializeComponent();
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

        private void panel2_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar o site no momento! \nTente novamente: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=Hy8kmNEo1i8";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar o site no momento! \nTente novamente: " + ex.Message);
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=1buCERP_zOo";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar o site no momento! \nTente novamente: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 tela1 = new Form1();
            tela1.Show();
            this.Hide();
        }
    }
}
