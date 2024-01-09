using System;
using System.Runtime.CompilerServices;

namespace Payments{
    class Program{
        static void Main(string[] args){
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";

            var pagamento = new Pagamento();
            pagamento.ToString();

        }
    }

    class Pagamento {
        public DateTime Vencimento;

        public virtual void Pagar(){}

        public override string ToString()
        {
            return Vencimento.ToString("dd/mm/yyyy");
        }
    }

    class PagamentoBoleto: Pagamento {
        public string NumeroBoleto;

        public override void Pagar()
        {
            // Regra do Boleto
        }
    }

    class PagamentoCartaoDeCredito: Pagamento {
        public string Numero;

        public override void Pagar()
        {
            // Regra do Cartão de Crédito
        }
    }
}