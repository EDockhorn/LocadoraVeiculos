using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dll_Uteis
{
    public class ValidaDocumentos
    {
        public bool ValideCPF(string cpf)
            {
            string padraoCPF = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$";

            // System.Text.RegularExpressions.Regex
            Regex expressaoRegularDeCPF = new Regex(padraoCPF);

            return expressaoRegularDeCPF.IsMatch(cpf);
            }
    }
}
