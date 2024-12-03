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
        //Adiciona um usuário no banco de dados e retorna se funcionou
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conexao = null;
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                conexao = conexaoDB.Criarconexaomysql();

                // Linha de comando que será executada no sql
                string sql = @$"INSERT INTO tb_usuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // subsitui os @ pelos parametros do método
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

            //Caso ocorra um erro o catch será executado
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será 
            finally
            {
                conexao.Close();
            }

        }


        //Cria um usuário na tabela mysql.user e retorna se funcionou
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

            //Caso ocorra um erro o catch será executado
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }

        }

        //Realiza o login do usuário, passando seu usuário senha e nome para as variaveis da classe SessionAgenda
        //retorna se funcionou
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

                // subsitui os @ pelos parametros do método
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

            //Caso ocorra um erro o catch será executado
            catch
            {
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }
        }

        //Pega os usuarios do banco de dados as retorna no formato de dataTable
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

            //Caso ocorra um erro o catch será executado
            catch (Exception erro)
            {
                MessageBox.Show($"erro ao recuperar categorias: {erro.Message}");

                return new DataTable();
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }
        }

        //Deleta um usuario do banco de dados e retorna se funcionou
        public bool DelUser(string usuario)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = conexaoDB.Criarconexaomysql();

                string sql = "DELETE FROM tb_usuarios WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // subsitui os @ pelos parametros do método
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

            //Caso ocorra um erro o catch será executado
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao deletar o usuario: {erro.Message}");
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }
        }

        //Atualiza a senha de um usuário do banco de dados e retorna se funcionou
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

            //Caso ocorra um erro o catch será executado
            catch ( Exception erro )
            {
                MessageBox.Show($"erro ao alterar senha:{erro.Message}");
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }
        }
    }
}
