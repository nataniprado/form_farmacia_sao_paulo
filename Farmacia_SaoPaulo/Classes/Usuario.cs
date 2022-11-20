using System;

namespace Farmacia_SaoPaulo.Classes
{
    public class Usuario
    {
        private string nome;
        private string sobrenome;
        private string email;
        private string cpf;
        private string telefone;
        private string senha;
        private bool receberEmail;
        private bool participarPrograma;
        private int id;
        

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }
        
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
        }
        
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setSenha( string senha)
        {
            this.senha = senha;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setReceberEmail(bool receberEmail)
        {
            this.receberEmail = receberEmail;
        }

        public bool getReceberEmail()
        {
            return receberEmail;
        }

        public void setParticiparPrograma(bool participarPrograma)
        {
            this.participarPrograma = participarPrograma;
        }

        public Boolean getParticiparPrograma()
        {
            return participarPrograma;
        }
        
        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }
    }
}