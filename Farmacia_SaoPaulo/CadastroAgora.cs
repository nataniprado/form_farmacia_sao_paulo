using System;
using System.Windows.Forms;

namespace Farmacia_SaoPaulo
{
    public partial class CadastroAgora : Form
    {
        public CadastroAgora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            this.Hide();
            telaCadastro.ShowDialog();
            this.Close();
        }
    }
}