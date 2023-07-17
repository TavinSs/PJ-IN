﻿using System;
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
    public partial class RedfinirSenha : Form
    {
        Point mousePos;

        public RedfinirSenha()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        }
    }
}
