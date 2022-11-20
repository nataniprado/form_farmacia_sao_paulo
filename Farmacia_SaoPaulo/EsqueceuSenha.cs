using System;
using System.Windows.Forms;

namespace Farmacia_SaoPaulo
{
    public partial class EsqueceuSenha : Form
    {
        private bool podeFechar = false;

        public bool getPodeFechar()
        {
            return podeFechar;
        }

        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void EsqueceuSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovaSenha novaSenha = new NovaSenha();
            this.Hide();
            novaSenha.ShowDialog();
            this.Show();
            if (novaSenha.getPodeFechar())
            {
                this.podeFechar = true;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}