using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIndividual1Pratica
{
    class PessoaJuridica : Pessoa
    {
        public string IE { get; set; }
        public string CNPJ { get; set; }

        public PessoaJuridica(string ie, string cnpj)
        {
            ie = IE;
            cnpj = CNPJ;
        }
        public PessoaJuridica()
        {

        }
    }
}
