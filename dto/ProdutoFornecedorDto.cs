using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumus.dto
{
    public class ProdutoFornecedorDto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco {  get; set; }
    }
}
