using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosPDF
{
    [Serializable]
    class Pessoa
    {
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public double Salario { get; set; }

        public Profissao Profissao { get; set; }

        public bool Empregado { get; set; }
    }
}
