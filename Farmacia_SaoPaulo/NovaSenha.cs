using System;
using System.Windows.Forms;

namespace Farmacia_SaoPaulo
{
    public partial class NovaSenha : Form
    {
        private bool podeFechar = false;
        public bool getPodeFechar()
        {
            return podeFechar;
        }
        
        public NovaSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlteradoSucesso alteradoSucesso = new AlteradoSucesso();
            this.Hide();
            alteradoSucesso.ShowDialog();
            if (alteradoSucesso.getPodeFechar())
            {
                this.podeFechar = true;
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        
    }
}