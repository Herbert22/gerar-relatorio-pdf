using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeradorRelatoriosPDF
{
    [Serializable]
    class Profissao
    {
        public int IdProfissao { get; set; }

        public string Nome { get; set; }
    }
}
