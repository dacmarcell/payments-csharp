using System.Globalization;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;

namespace Payments{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World");
            var creditPayment = new PaymentWithCreditCard();
            creditPayment.Pay(10);
        }
    }

    public interface IPayment {
        DateTime Due { get; set; }
        void Pay(double value);
    }

    public abstract class Payment : IPayment{
        public DateTime Due {get; set;}
        public virtual void Pay(double value){}
    }

    public class PaymentWithCreditCard : Payment{
        public override void Pay(double value){
            base.Pay(value);
        }
    }
    public class PaymentWithGooglePay : Payment{
        public override void Pay(double value){
            base.Pay(value);
        }
    }
    public class PaymentWithApplePay : Payment{
        public override void Pay(double value){
            base.Pay(value);
        }
    }
}