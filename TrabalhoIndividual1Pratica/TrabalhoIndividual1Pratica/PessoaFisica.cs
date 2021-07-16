using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIndividual1Pratica
{
    class PessoaFisica : Pessoa
    {
        public string RG { get; set; }
        public string CPF { get; set; }

        public PessoaFisica(string rg, string cpf)
        {
            rg = RG;
            cpf = CPF;
        }
        public PessoaFisica()
        {

        }
    }
}
