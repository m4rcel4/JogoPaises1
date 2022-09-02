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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogadores2 form=new jogadores2();
            form.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jogadores3 form=new Jogadores3();
            form.Show();
        }
    }
}
