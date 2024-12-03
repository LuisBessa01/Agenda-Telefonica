using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Data
{
    static internal class conexaoDB
    {
        //Essa conexão entra com o user root
        //Usar em cadastros de usuario e outros momentos antes do usuario logar
        static public MySqlConnection Criarconexaomysql()
        {
            //uma string com as infos pra logar no banco de dados
            string stringConexao = "Server=127.0.0.1;Database=db_agenda;User ID=root;Password=root;";
            //criando uma conexão
            MySqlConnection conexaomysql = new MySqlConnection(stringConexao);

            return conexaomysql;
        }

        //Essa conexão entra com o usuario logado no aplicativo
        //Usar em todas as ações realizadas por um usuario em sua conta
        static public MySqlConnection Criarconexaomysql(string usuario, string senha)
        {
            //uma string com as info pra logar no bnco de dados
            string stringConexao = $"Server=127.0.0.1;Database=db_agenda;User ID={usuario};Password={senha};";
            //criando uma conexão
            MySqlConnection conexaomysql = new MySqlConnection(stringConexao);

            return conexaomysql;
        }
    }
}
