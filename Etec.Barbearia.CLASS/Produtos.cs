using System;
using System.Collections.Generic;
using System.Text;

namespace Etec.Barbearia.CLASS
{
    public class Produtos
    {
        public int codproduto { get; }
        public int codfornecedor { get; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }
        public int qtd { get; set; }
        public int lote { get; set; }


    }
}
