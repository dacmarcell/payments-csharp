using System.Globalization;
using Microsoft.VisualBasic;

namespace Payments{
    class Program{
        static void Main(string[] args){
            using(var payment = new Payment()){
                Console.WriteLine("Processando o Pagamento...");
            }
            Console.WriteLine("Hello World");
        }
    }
    public class Payment: IDisposable
    {
        public Payment(){
            Console.WriteLine("Iniciando o pagamento.");
        }
        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento.");
        }

    }
}