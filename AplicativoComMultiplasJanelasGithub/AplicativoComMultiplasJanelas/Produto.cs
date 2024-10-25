using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoComMultiplasJanelas
{
    internal class Produto
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        
        [DisplayName("Produto")]
        public string Nome { get; set; }
        
        [DisplayName("Nome do Fabricante")]
        public string Fabricante { get; set; }
        
        [DisplayName("Preço de Compra")]
        public decimal PrecoCompra { get; set; }
        
        [DisplayName("Preço de Venda")]
        public decimal PrecoVenda { get; set; }
    }
}
