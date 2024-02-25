using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOperatorsOverloadApp
{
    internal class Money
    {
        public int Rub { get; set; }
        
        int kop;
        public int Kop 
        {
            get => kop;
            set 
            {
                kop = value % 100;
                Rub += (int)value / 100;
            }
        }

        public Money() { }
        public Money(int rub, int kop)
        {
            Rub = rub;
            Kop = kop;
        }

        public override string ToString()
        {
            return $"{Rub} rub, {Kop} kop";
        }

        // public static <ReturnType> operator <OperatorSign>(params)
        /*
         un operators: +a, -a, !a, ~a, ++, --
        bin operators: +, -, *, /, %
        eq oprators: > и <, >= и <=, == и !=
        logic oparators &&, ||, true и false
        bit operators: &, |, ^, <<, >>

         
        */

        public static Money operator+(Money a, Money b)
        {
            return new Money(a.Rub + b.Rub, a.Kop + b.Kop);
        }

        public static Money operator+(Money a, int k)
        {
            return new Money(a.Rub, a.Kop + k);
        }

        public static Money operator +(int k, Money a)
        {
            return new Money(a.Rub, a.Kop + k);
        }

        public static Money operator-(Money a, Money b)
        {
            if(a.Kop < b.Kop)
            {
                a.Rub--;
                a.kop += 100;
            }
            return new Money(a.Rub - b.Rub, a.Kop - b.Kop);
        }

        public static bool operator>(Money a, Money b)
        {
            return (a.Rub * 100 + a.Kop) > (b.Rub * 100 + b.Kop);
        }

        public static bool operator<(Money a, Money b)
        {
            return (a.Rub * 100 + a.Kop) < (b.Rub * 100 + b.Kop);
        }

        public static bool operator >=(Money a, Money b)
        {
            return (a.Rub * 100 + a.Kop) >= (b.Rub * 100 + b.Kop);
        }

        public static bool operator <=(Money a, Money b)
        {
            return (a.Rub * 100 + a.Kop) <= (b.Rub * 100 + b.Kop);
        }

        public static bool operator ==(Money a, Money b)
        {
            return (a.Rub * 100 + a.Kop) == (b.Rub * 100 + b.Kop);
        }

        public static bool operator !=(Money a, Money b)
        {
            return (a.Rub * 100 + a.Kop) != (b.Rub * 100 + b.Kop);
        }

        public static Money operator++(Money a)
        {
            return new Money(a.Rub++, a.Kop);
        }

        public static bool operator true(Money a)
        {
            return (a.Rub * 100 + a.Kop) != 0;
        }

        public static bool operator false(Money a)
        {
            return (a.Rub * 100 + a.Kop) == 0;
        }

        // implicit - неявное, explicit - явное
        public static explicit operator int(Money a)
        {
            return a.Rub * 100 + a.Kop;
        }
    }
}
