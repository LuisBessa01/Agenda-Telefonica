using Agenda_Telefonica.Data;
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
                conexao = conexaoDB.Criarconexaomysql();

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
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
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
                conexao = conexaoDB.Criarconexaomysql();

                // codigo a ser inserido no mysql para exibir todos os dados da tabela
                string sql = "SELECT ID_categoria AS 'Código', nome_categoria AS 'Categorias' FROM tb_categorias;";

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

    }
}
