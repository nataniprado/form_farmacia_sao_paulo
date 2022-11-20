using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Farmacia_SaoPaulo.Classes;
using Npgsql;

namespace Farmacia_SaoPaulo.Dao
{
    public class UsuarioDao
    {

        public void criaUsuario(Usuario usuario)
        {
            var connection = DatabaseConnector.getConnection();
            connection.Open();
            var sql =
                $"INSERT INTO usuario (nome,sobrenome,email,telefone,senha,cpf,receberEmail,participarPrograma) values ('{usuario.getNome()}','{usuario.getSobrenome()}','{usuario.getEmail()}','{usuario.getTelefone()}','{usuario.getSenha()}','{usuario.getCpf()}','{(object)usuario.getReceberEmail()}','{(object)usuario.getParticiparPrograma()}')";
            var cmd = new NpgsqlCommand(sql, connection);
            try
            {
                cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Usuario> getUsuarios()
        {
            var connection = DatabaseConnector.getConnection();
            connection.Open();

            string sql = "SELECT id, nome, sobrenome, cpf, telefone, email, receberemail, participarprograma FROM usuario";
            var cmd = new NpgsqlCommand(sql, connection);
            
            NpgsqlDataReader resultado = cmd.ExecuteReader();
            
            List<Usuario> usuarios = new List<Usuario>();
            
            while (resultado.Read())
            {
                Usuario usuario = new Usuario();
                
                usuario.setId(resultado.GetInt32(0));
                usuario.setNome(resultado.GetString(1));
                usuario.setSobrenome(resultado.GetString(2));
                usuario.setCpf(resultado.GetString(3));
                usuario.setTelefone(resultado.GetString(4));
                usuario.setEmail(resultado.GetString(5));
                usuario.setReceberEmail(resultado.GetBoolean(6));
                usuario.setParticiparPrograma(resultado.GetBoolean(7));
                
                usuarios.Add(usuario);
            }
            
            connection.Close();
            return usuarios;
        }
    }
}