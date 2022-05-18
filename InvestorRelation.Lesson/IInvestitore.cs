using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorRelation.Lesson
{
    public interface IInvestitore
    {
       void Update(Azione stock); 
       
    } 
    public class Investor : IInvestitore
    {
         string name { get; set; }
        int TotalInvstment = 0;
        public void Update(Azione stock)
        {
           Console.WriteLine($"Ciao {this.name} . Il prezzo dell'azione {stock.Name} adesso è : {stock.Price}" );
        }

        public Investor(string Name)
        {
            name=Name;  
        }
    }
}
