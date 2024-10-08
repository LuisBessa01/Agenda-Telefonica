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
        static public MySqlConnection Criarconexaomysql()
        {
            //uma string com as info pra logar no bnco de dados
            string stringConexao = "Server=127.0.0.1;Database=db_agenda;User ID=root;Password=root;";
            //criando uma conexão
            MySqlConnection conexaomysql = new MySqlConnection(stringConexao);

            return conexaomysql;
        }
    }
}
