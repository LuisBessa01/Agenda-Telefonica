using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.GlobalVar
{
    // Classe public (todos terem acesso) e static (todos usarem os mesmos valores, NÃO INSTANCIA)
    static public class SessionAgenda
    {
        static private string _usuario = null;
        static private string _senha = null;
        static private string _nome = null;

        static public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        static public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        static public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
