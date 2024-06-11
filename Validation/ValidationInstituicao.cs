using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Validation
{
    public static class ValidationInstituicao
    {

        public static bool Valid(string nome, string sigla, string site, string endereco)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(site) ||
                string.IsNullOrWhiteSpace(sigla))
            {
                return false;
            }
            return true;
        }
    }
}
