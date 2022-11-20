using System;
using System.Windows.Forms;

namespace Farmacia_SaoPaulo
{
    public partial class AlteradoSucesso : Form
    {
        private bool podeFechar = false;
        
        public AlteradoSucesso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.podeFechar = true;
            this.Close();
            
        }

        public bool getPodeFechar()
        {
            return this.podeFechar;
        }
    }
}