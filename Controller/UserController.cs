using Agenda_Telefonica.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class UserController
    {
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                MySqlConnection conexao = conexaoDB.Criarconexaomysql();

                //inserir dados na tabela do sql
                string sql = "INSERT INTO tb_usuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                int quantidadeAfetada = comando.ExecuteNonQuery();

                conexao.Close();

                if (quantidadeAfetada > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }

        }

        public bool LoginUser(string usuario, string senha)
        {
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                MySqlConnection conexao = conexaoDB.Criarconexaomysql();

                string sql = "SELECT * FROM tb_usuarios WHERE usuario = @usuario AND BINARY SENHA = @senha;";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
