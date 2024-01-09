using System.Globalization;
using Microsoft.VisualBasic;

namespace Payments{
    class Program{
        static void Main(string[] args){
            var payment = new PayWithCard();
            payment.Pay("10");
        }
    }
    public class Payment {
        public DateTime PaymentDate { get;set; }
        public Payment(){
            Console.WriteLine("Iniciando o Pagamento");
            PaymentDate = DateTime.Now;
        }
        public virtual void Pay(string numero){
            Console.WriteLine("Pagar");
        }
        
    }

    public class PayWithCard : Payment{
        public PayWithCard(){}
        public override void Pay(string numero){
            Console.WriteLine("Pagar cartão");
        }
    }

    public class Address{
        string ZipCode;
    }
}