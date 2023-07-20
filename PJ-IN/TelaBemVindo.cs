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
    
    public partial class TelaBemVindo : Form
    {
        Point mousePos;
        public TelaBemVindo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ExibirMensagem(string mensagem)
        {
            label1.Text = mensagem;
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
