using Agenda_Telefonica.Data;
using Agenda_Telefonica.GlobalVar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class CategoryController
    {
        public bool AddCategory(string nomeCategoria)
        {
            MySqlConnection conexao = null;
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                // insere os dados na tabela de categoria
                string sql = "INSERT INTO tb_categorias (nome_categoria) VALUES (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // subsitui os @ pelos parametros da função
                comando.Parameters.AddWithValue("@categoria", nomeCategoria);

                // executa o comando e retorna quantas linhas do db foi afetada
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
                MessageBox.Show($"Erro ao criar categoria:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                // codigo a ser inserido no mysql para exibir todos os dados da tabela
                string sql = @$"SELECT ID_categoria AS 'Código', nome_categoria AS 'Categorias' FROM tb_categorias 
                                WHERE usuario LIKE '{SessionAgenda.usuario}@%';";

                conexao.Open();

                // diferente do command este trabalha com a tabela inteira, sem ver seus dados
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                // cria uma tabela vazia
                DataTable tabela = new DataTable();

                // preenche
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

        public bool DelCategoria(int idCategoria)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = "DELETE FROM tb_categorias WHERE ID_categoria = @idCategoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@idCategoria", idCategoria);

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
                MessageBox.Show($"Erro ao deletar a categoria:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool UpdateCategoria(int idCategoria, string nomeCategoria)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = @$"UPDATE tb_categorias
                                SET nome_categoria = @nomeCategoria
                                WHERE ID_categoria = @idCategoria;";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand (sql, conexao);

                comando.Parameters.AddWithValue("idCategoria", idCategoria);
                comando.Parameters.AddWithValue("@nomeCategoria", nomeCategoria);

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
                MessageBox.Show($"Erro ao atualizar a categoria:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }
    
    }
}
