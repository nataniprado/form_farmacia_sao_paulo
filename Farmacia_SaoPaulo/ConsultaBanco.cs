using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Farmacia_SaoPaulo.Classes;
using Farmacia_SaoPaulo.Dao;

namespace Farmacia_SaoPaulo
{
    public partial class ConsultaBanco : Form
    {
        public ConsultaBanco()
        {
            InitializeComponent();
            populateListView();
        }

        private void populateListView()
        {
            List<Usuario> usuarios = new List<Usuario>();
            UsuarioDao usuarioDao = new UsuarioDao();
            usuarios = usuarioDao.getUsuarios().ToList();
            foreach (var usuario in usuarios)
            {
                ListViewItem lv1 = new ListViewItem(usuario.getId().ToString());
                lv1.SubItems.Add(usuario.getNome());
                lv1.SubItems.Add(usuario.getSobrenome());
                lv1.SubItems.Add(usuario.getCpf());
                lv1.SubItems.Add(usuario.getEmail());
                lv1.SubItems.Add(usuario.getTelefone());
                lv1.SubItems.Add(usuario.getReceberEmail().ToString());
                lv1.SubItems.Add(usuario.getParticiparPrograma().ToString());
                listView1.Items.Add(lv1);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}