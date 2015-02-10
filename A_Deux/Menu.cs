using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Deux
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Show();
            this.Hide();
        }

        private void statesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado state = new Estado();
            state.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd.ObtenerConexion();
            MessageBox.Show("Conectado");
        }
    }
}
