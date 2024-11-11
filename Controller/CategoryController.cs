using Agenda_Telefonica.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class CategoryController
    {
        public bool AddCategory(string nomeCategoria)
        {
            try
            {
                // cria uma variavel que conecta na classe.função do arquivo conexaoDB
                MySqlConnection conexao = conexaoDB.Criarconexaomysql();

                // insere os dados na tabela de categoria
                string sql = "INSERT INTO tb_categorias (nome_categoria) VALUES (@nome);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nomeCategoria);

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
    }
}
