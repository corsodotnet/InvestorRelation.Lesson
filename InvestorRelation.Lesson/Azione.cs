using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorRelation.Lesson
{
    public class Azione
    {   string name; 
        double price;

        public List<IInvestitore> InvestitorList = new List<IInvestitore>();

        public Azione(string Name, double Price)        
        {
             this.price = Price;    
             this.name = Name;  
        } 
        public void Subscribe(IInvestitore investor)
        {
            InvestitorList.Add(investor);
        }
        public void Notifica()
        {
            foreach (IInvestitore investor in InvestitorList)
            {
                investor.Update(this);
              //  investor.event += Managesubcripton;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if(price != value)
                {
                    price = value;
                    Notifica(); // sempre la stessa funzione! 
                }
            }
        }
        public string Name
        {
            get { return name; }
        }
    }
}
