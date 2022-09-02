using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPaises1
{
    public partial class CadastroJogadores : Form
    {
        public CadastroJogadores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            home form = new home();
            form.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
