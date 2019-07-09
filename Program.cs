using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountApp2.Properties;

namespace AccountApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Money money1 = new Money(12, Currency.RMB);
            //Money money2 = new Money(15, Currency.USD);
            //money1 = money2 - money1;
            //Console.WriteLine(money1.ToString());
            //Console.ReadKey();

            //Item item1 = new Item("Work", Category.Income, 1000);
            //Item item2 = new Item("Work", Category.Income, "Salary", 5000, Currency.RMB);
            //Item item3 = new Item("Food", Category.Spending, 100, Currency.RMB);
            //Item item4 = new Item("Food", Category.Spending, 50, Currency.EUR, new DateTime(2019, 06, 06));
            //Item item5 = new Item("Work", Category.Income, 3000, new DateTime(2019, 06, 06));
            //Item item6 = new Item("Computer", Category.Spending, "Lenovo", "Buy a computer", 5000, Currency.RMB);
            //Item item7 = new Item("Work", Category.Income, "Salary", "Two month", 10000, Currency.USD, new DateTime(2019, 06, 07));
            //Item item8 = new Item("Food", Category.Spending, 500, Currency.RMB, new DateTime(2019, 05, 06));
            //Item item9 = new Item("Food", Category.Spending, 100, new DateTime(2019, 07, 06));

            //AccontItem AccountList = new AccontItem();
            //AccountList.additem(item1);
            //AccountList.additem(item2);
            //AccountList.additem(item3);
            //AccountList.additem(item4);
            //AccountList.additem(item5);
            //AccountList.additem(item6);
            //AccountList.additem(item7);
            //AccountList.additem(item8);
            //AccountList.additem(item9);

            //Money totalRevenue = AccountList.TotalRevenue(DateTime.Now);
            //Console.WriteLine(totalRevenue);
            //Money totalExpenditure = AccountList.TotalSpending(DateTime.Now);
            //Console.WriteLine(totalExpenditure);
            //Money totalIncome = AccountList.TotalIncome(DateTime.Now);
            //Console.WriteLine(totalIncome);
            //foreach (Item item in AccountList.Display(DateTime.Now))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();
            Application.Run(new Form1());
        }
    }
}
