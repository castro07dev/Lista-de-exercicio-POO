using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicio_POO.Utils
{
    internal class funcUtils
    {
        // metodo statico para retornar icone
        public static MessageBoxIcon ObterIcone(string message)
        {
            if (message.ToLower().Contains("erro"))
            {
                return MenssageBoxIcon.Error;
            }
            else
            {
                return MessageBoxIcon.Information;
            }

        }
    }
}
