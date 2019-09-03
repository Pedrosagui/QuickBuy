

using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
  public  class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido de Venda deve conter um item");
            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Cep não deve ser Nulo");
        }
    }
}
