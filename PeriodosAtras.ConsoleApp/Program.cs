using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            Console.WriteLine("Digite a data:");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
            menu.VerificarData(data);

            Console.ReadLine();
        }
    }
}
