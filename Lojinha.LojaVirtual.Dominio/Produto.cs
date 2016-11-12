using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.LojaVirtual.Dominio
{
    public class Produto
    {
        public int Produtoid { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }
        public string categoria { get; set; }
    }
}
