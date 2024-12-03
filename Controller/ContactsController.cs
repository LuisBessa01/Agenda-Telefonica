using Agenda_Telefonica.Data;
using Agenda_Telefonica.GlobalVar;
using Agenda_Telefonica.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class ContactsController
    {
        //Adiciona um contato no banco de dados e retorna se funcionou

        public bool AddContact(string nome, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                // Linha de comando que será executada no sql
                string sql = @$"INSERT INTO tb_contatos (nome_contato, telefone_contato, categoria)
	                                VALUES (
		                                @nome,
                                        @telefone,
                                        @categoria
                                        );";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // subsitui os @ pelos parametros do método
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

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
                MessageBox.Show($"Erro ao criar contato:{erro.Message}");
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }

        }

        //Pega os contatos do banco de dados as retorna no formato de dataTable
        public DataTable GetContacts()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = @$"  SELECT ID_contato AS 'Código', nome_contato AS 'Nome', telefone_contato AS 'Telefone', categoria AS 'Categoria' FROM tb_contatos
                                    WHERE usuario like '{SessionAgenda.usuario}@%';";

                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }

            //Caso ocorra um erro o catch será executado
            catch (Exception erro)
            {
                MessageBox.Show($"erro ao recuperar contatos: {erro.Message}");

                return new DataTable();
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }
        }

        //Deleta um contato do banco de dados e retorna se funcionou
        public bool DelContact(int IdContato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = @$"DELETE FROM tb_contatos 
	                                WHERE ID_contato = @IdContato;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // subsitui os @ pelos parametros do método
                comando.Parameters.AddWithValue("@IdContato", IdContato);

                int quantidadeAfetada = comando.ExecuteNonQuery();

                if ( quantidadeAfetada > 0)
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
                MessageBox.Show($"Erro ao deletar o contato:{erro.Message}");
                return false;
            }

            //Independente se ocorreu um erro ou nãl o finally será executado
            finally
            {
                conexao.Close();
            }
        }

        //Atualiza as informações de um contato do banco de dados e retorna se funcionou
        public bool UpdateContact(int idContato, string nomeContato, string telefoneContato, string categoriaContato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = @$"UPDATE tb_contatos
                                SET nome_contato = @nomeContato,
                                    telefone_contato = @telefoneContato,
                                    categoria = @categoriaContato
                                WHERE ID_contato = @idContato;";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // subsitui os @ pelos parametros do método
                comando.Parameters.AddWithValue("@idContato", idContato);
                comando.Parameters.AddWithValue("@nomeContato", nomeContato);
                comando.Parameters.AddWithValue("@telefoneContato", telefoneContato);
                comando.Parameters.AddWithValue("@categoriaContato", categoriaContato);

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
                MessageBox.Show($"Erro ao atualizar o contato:{erro.Message}");
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
