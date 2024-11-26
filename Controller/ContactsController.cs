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
        public bool AddContact(string nome, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = @$"INSERT INTO tb_contatos (nome_contato, telefone_contato, categoria)
	                                VALUES (
		                                @nome,
                                        @telefone,
                                        @categoria
                                        );";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

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

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao criar contato:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }

        public DataTable GetContacts()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.Criarconexaomysql(SessionAgenda.usuario, SessionAgenda.senha);

                string sql = @$"  SELECT ID_contato AS 'Código', nome_contato AS 'Nome', telefone_contato AS 'Telefone', categoria AS 'Categoria' FROM tb_contatos
                                    WHERE usuario like '{SessionAgenda.usuario}%';";
            }
        }
    }
}
