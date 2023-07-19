namespace PJ_IN
{
    public partial class Form1 : Form
    {
        Point mousePos;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
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
                // Calcula a diferença entre a posição atual do mouse e a posição anterior do mouse
                int deltaX = e.X - mousePos.X;
                int deltaY = e.Y - mousePos.Y;

                // Atualiza a posição da janela
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}