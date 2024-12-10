using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumus.model
{
    public class PedidoProdutoFornecedor
    {
        public string IdProduto { get; set; }
        public string IdPedido { get; set; }
        public string ValorProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
