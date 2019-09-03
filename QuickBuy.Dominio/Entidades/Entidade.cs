
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }
        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValidado
        {
            get { return !MensagemValidacao.Any(); }
                
        }
    }
}
