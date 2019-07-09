using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp2.Properties
{
    public enum Currency
    {
        RMB, EUR, USD
    }
    public class Money
    {

        public double FaceValue;
        public Currency currency;

        private double GetTrueValue
        {
            get
            {
                switch (this.currency)
                {
                    case Currency.EUR: return FaceValue * 8.0;
                    case Currency.USD: return FaceValue * 7.0;
                    case Currency.RMB: return FaceValue;
                    default:
                        Console.WriteLine("Input is wrong");
                        return 0;
                }
            }
        }

        //构造函数
        public Money()
        {
            FaceValue = 0;
            this.currency = Currency.RMB;
        }
        public Money(double FaceValue)
        {
            this.FaceValue = FaceValue;
            this.currency = Currency.RMB;
        }
        public Money(double FaceValue, Currency currency)
        {
            this.FaceValue = FaceValue;
            this.currency = currency;
        }

        //操作符重载
        public static Money operator+ (Money money1, Money money2)
            {
            double TotalValue = money1.GetTrueValue + money2.GetTrueValue;
            return new Money(TotalValue); 
            }

        public static Money operator -(Money money1, Money money2)
        {
            double TotalValue = money1.GetTrueValue - money2.GetTrueValue;
            return new Money(TotalValue);
        }

        public override string ToString()
        {
            return $"The money is {this.FaceValue}  {this.currency}";
        }
    }



}
