using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp2.Properties
{
    public class AccontItem
    {
        private List<Item> AccountList = new List<Item>();

        public void  additem(Item item)
        {
            AccountList.Add(item);

        }
        public bool IsSpending(Item item)
        {
            if (item.category == Category.Spending) return true;
            else return false;
        }
        public bool IsIncome(Item item)
        {
            if (item.category == Category.Income) return true;
            else return false;
        }
        public bool IsSameYear(DateTime time,Item item)

        {
            if (item.OccueredTime.Month == time.Month && item.OccueredTime.Year == time.Year)
                return true;
            else return false;
        }
        public Money TotalSpending(DateTime time)
        {
            Money totalspending = new Money();
            foreach (Item item in AccountList)
                {
                if (IsSpending(item) && IsSameYear(time,item))
                {
                    totalspending += item.Amount;
            }
            }
            return totalspending;

        }
        public Money TotalIncome(DateTime time)
        {
            Money totalIncome = new Money();
            foreach (Item item in AccountList)
            {
                if (IsIncome(item) && IsSameYear(time, item))
                {
                    totalIncome += item.Amount;
                }
            }
            return totalIncome;
        }
        public Money TotalRevenue(DateTime time)
        {
            Money totalRevenue = new Money();
            Money totalIncome = new Money();
            Money totalspending = new Money();
            totalIncome = TotalIncome(time);
            totalspending = TotalSpending(time);
            totalRevenue = totalIncome - totalspending;
            return totalRevenue;
        }

        public IEnumerable<Item> Display(DateTime time)
        {
            foreach(Item item in AccountList)
            {
                if(IsSameYear(time, item))
                {
                    yield return item;
                }
            }
        }
    }
}
