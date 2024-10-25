using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoComMultiplasJanelas
{
    public class Fornecedor
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }
        [DisplayName("Nome da Empresa")]
        public string NomeEmpresa { get; set; }
        [DisplayName("Nome do Contato")]
        public string NomeContato { get; set; }
        [DisplayName("Número de Telefone")]
        public string Telefone { get; set; }
        [DisplayName("Endereço de E-mail")]
        public string Email { get; set; }
        [DisplayName("Endereço Físico")]
        public string Endereco { get; set; }
    }
}
