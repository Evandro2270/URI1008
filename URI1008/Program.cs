using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                int numero, horas;
                double ValorHora, salario;

                numero = int.Parse(Console.ReadLine());
                horas = int.Parse(Console.ReadLine());
                ValorHora = double.Parse(Console.ReadLine(), CI);

                salario = ValorHora * horas;

                Console.WriteLine();
                Console.WriteLine("NUMBER = " + numero);
                Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CI));

            }
        }
    }
}