using System;
using System.Windows.Forms;
using Farmacia_SaoPaulo.Classes;
using Farmacia_SaoPaulo.Dao;

namespace Farmacia_SaoPaulo
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.setNome(nomeUsuariotextbox.Text);
            usuario.setSobrenome(sobrenomeTextbox.Text);
            usuario.setEmail(emailTextbox.Text);
            usuario.setCpf(cpfTextbox.Text);
            usuario.setTelefone(telefoneTextbox.Text);
            usuario.setSenha(cadastroSenhaTextbox.Text);
            usuario.setReceberEmail(receberEmailCheckBox1.Checked);
            usuario.setParticiparPrograma(ParticiparProgramacheckBox2.Checked);
            
            
            
            UsuarioDao dao = new UsuarioDao();
            dao.criaUsuario(usuario);
            
            CriadoSucesso criadoSucesso = new CriadoSucesso();
            this.Hide();
            criadoSucesso.ShowDialog();
            this.Close();
        }
    }
}