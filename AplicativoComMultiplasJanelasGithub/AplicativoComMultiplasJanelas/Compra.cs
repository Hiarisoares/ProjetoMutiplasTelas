using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoComMultiplasJanelas
{
    public class Compra
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Id do Produto")]
        public int IdProduto { get; set; }
        [DisplayName("Id do Fornecedor")]
        public int IdFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")]
        public int Quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")]
        public decimal Desconto { get; set; }
        [DisplayName("Data da compra")]
        public DateTime DataCompra { get; set; }
    }
}
