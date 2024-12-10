using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumus.dto
{
    public class PedidoFornecedorDto
    {
        public int Id { get; set; } // ID do pedido
        public decimal ValorTotal { get; set; } // Valor total do pedido
        public List<FornecedorDto> Fornecedores { get; set; } // Lista de fornecedores com seus produtos

    }
}
