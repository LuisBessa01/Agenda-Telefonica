using Agenda_Telefonica.Data;
using Agenda_Telefonica.GlobalVar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class UserController
    {
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conexao = null;
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                conexao = conexaoDB.Criarconexaomysql();

                //inserir dados na tabela do sql
                string sql = @$"INSERT INTO tb_usuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                int quantidadeAfetada = comando.ExecuteNonQuery();



                if (quantidadeAfetada > 0)
                {
                    this.CreateUser(usuario, senha);
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
            finally
            {
                conexao.Close();
            }

        }

        private bool CreateUser (string usuario, string senha)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql();

                string mysqlUser = $@"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                    GRANT ALL PRIVILEGES ON db_agenda.* TO '{usuario}'@'%';
                    FLUSH PRIVILEGES;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(mysqlUser, conexao);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }

        public bool LoginUser(string usuario, string senha)
        {
            MySqlConnection conexao = null;
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                conexao = conexaoDB.Criarconexaomysql();

                string sql = "SELECT usuario, senha, nome, telefone FROM tb_usuarios WHERE usuario = @usuario AND BINARY SENHA = @senha;";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    SessionAgenda.usuario = resultado.GetString("usuario");
                    SessionAgenda.senha = resultado.GetString("senha");
                    SessionAgenda.nome = resultado.GetString("nome");   
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetUsers()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql();

                string sql = "SELECT  usuario AS 'Usuário', nome AS 'Nome', telefone AS 'Telefone' FROM tb_usuarios;";

                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"erro ao recuperar categorias: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool DelUser(string usuario)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = conexaoDB.Criarconexaomysql();

                string sql = "DELETE FROM tb_usuarios WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

                int quantidadeAfetada = comando.ExecuteNonQuery();

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
                MessageBox.Show($"Erro ao deletar o usuario: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ModSenha (string usuario, string novaSenha)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql();

                string sql = "UPDATE tb_usuarios SET senha= '@novaSenha' WHERE usuario = '@usuario';";
                
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@novaSenha", novaSenha);

                int quantidadeAfetada = comando.ExecuteNonQuery();

                if (quantidadeAfetada > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch ( Exception erro )
            {
                MessageBox.Show($"erro ao alterar senha:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
