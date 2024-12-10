using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumus.dto
{
    public class FornecedorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<ProdutoFornecedorDto> Produtos {get; set;}
    }

}
