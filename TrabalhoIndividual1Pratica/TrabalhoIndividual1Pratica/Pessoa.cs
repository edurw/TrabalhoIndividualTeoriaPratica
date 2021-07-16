using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIndividual1Pratica
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Pessoa(string nome, DateTime dataNascimento, string endereco)
        {
            nome = Nome;
            dataNascimento = DataNascimento;
            endereco = Endereco;
        }
        public Pessoa()
        {
            
        }
    }
}
