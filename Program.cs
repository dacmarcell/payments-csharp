using System.Globalization;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;

namespace Payments{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World");
            var pessoa = new Pessoa();
            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();
        }
    }

    public class Pessoa {
        public string Nome { get; set; }
    }

    public class PessoaFisica: Pessoa {
        public string CPF { get; set; }
    }

    public class PessoaJuridica: Pessoa {
        public string CNPJ { get; set; }
    }
}