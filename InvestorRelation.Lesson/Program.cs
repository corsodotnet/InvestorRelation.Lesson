using System;

namespace InvestorRelation.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Azione tesla = new Azione("TESLA",70.00);
            tesla.Subscribe(new Investor("Bruno"));
            tesla.Subscribe(new Investor("Juri"));
            tesla.Price = 30.00;

            Console.ReadKey(); 
        }
    }
}
