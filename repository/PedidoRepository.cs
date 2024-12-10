using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumus.database;
using Lumus.dto;

namespace Lumus.repository
{
    public class PedidoRepository
    {
        private readonly Database _database;
        public PedidoRepository()
        {
            _database = new Database();
        }
        
        public List<PedidoFornecedorDto> ObterPedidosComFornecedoresEProdutos()
        {
            string query = @"
            SELECT 
                p.id AS pedido_id,
                p.valor_total,
                f.id AS fornecedor_id,
                f.nome AS fornecedor_nome,
                prod.id AS produto_id,
                prod.nome AS produto_nome,
                ip.quantidade,
                ip.preco
            FROM 
                pdd_fornecedor p
            JOIN 
                item_pedido ip ON p.id = ip.pedido_id
            JOIN 
                produto prod ON ip.produto_id = prod.id
            JOIN 
                fornecedor f ON prod.fornecedor_id = f.id
            ORDER BY 
                p.id, f.id, prod.id";
        }


    }
}
