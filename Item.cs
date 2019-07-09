using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp2.Properties
{
    public enum Category { Spending,Income}
    public class Item
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public Category category;
        public Money Amount;
        public DateTime OccueredTime;

        //public Item(double  amount, Category category) : this("None", "None", "None", amount, DateTime.Now, Currency.RMB, category) { }
        public Item(string name, Category category, double amount) : this(name, category, "None", "None", amount, Currency.RMB, DateTime.Now) { }
        public Item(string name, Category category, string content, double amount) : this(name, category, content, "None", amount, Currency.RMB, DateTime.Now) { }
        public Item(string name, Category category, double amount, DateTime occuredTime) : this(name, category, "None", "None", amount, Currency.RMB, occuredTime) { }
        public Item(string name, Category category, double amount, Currency currency) : this(name, category, "None", "None", amount, currency, DateTime.Now) { }
        public Item(string name, Category category, double amount, Currency currency, DateTime occuredTime) : this(name, category, "None", "None", amount, currency, occuredTime) { }
        public Item(string name, Category category, string content, double amount, Currency currency) : this(name, category, content, "None", amount, currency, DateTime.Now) { }
        //public Item(string name, Category category, string note, double amount, Currency currency) : this(name, category, "None", note, amount, currency, DateTime.Now) { }
        public Item(string name, Category category, string content, double amount, Currency currency, DateTime occuredTime) : this(name, category, content, "None", amount, currency, occuredTime) { }
        public Item(string name, Category category, string content, string note, double amount, Currency currency) : this(name, category, content, note, amount, currency, DateTime.Now) { }
        public Item(string name, Category category, string content, string note, double amount, Currency currency, DateTime occuredTime)
        
        {
            this.Name = Name;
            this.Content = Content;
            this.Note = Note;
            this.Amount = new Money(amount,currency);
            this.OccueredTime = occuredTime;
            this.category = category;
        }
        public override string ToString()
        {
            return $"Name:{Name}||Content:{Content}||Note:{Note}||Amount:{Amount.ToString()}||Category:{category}";
        }
    }
}
