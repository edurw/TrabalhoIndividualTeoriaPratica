using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIndividual1Pratica
{
    class Endereco
    {
        public string Rua { get; set; }
        public int NumeroResidencia { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public Endereco(string rua, int numeroResidencia, string complemento, string bairro, string cidade)
        {
            rua = Rua;
            numeroResidencia = NumeroResidencia;
            complemento = Complemento;
            bairro = Bairro;
            cidade = Cidade;
        }
        public Endereco()
        {

        }
    }
}
