using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eventdot_prescribed
{
    public class pricechangedeventargs : EventArgs
    {
        public decimal oldprice;
        public decimal newprice;

        public pricechangedeventargs(decimal p, decimal newp)
        {
            oldprice = p;
            newprice = newp;

        }

    }


    public class stocks
    {
        string symbol;
       decimal price;

        public event EventHandler<pricechangedeventargs> pricechanged;

        void onpricechange(pricechangedeventargs e)
        {
            if (pricechanged != null)
                pricechanged(this, e);

        }

      public  decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;

                onpricechange(new pricechangedeventargs(Price, value));
                price = value;
            
            }

        
        }

    }


public class stockprice
{
    public static void changeinprice(object sender, pricechangedeventargs e)
{
    if (e.oldprice > e.newprice)
    {
        Console.WriteLine("Prices decreased");

    }

    else
    {
        Console.WriteLine("Prices increased !!");
    }
}

}

            class Program
        {
            static void Main(string[] args)
            {
                stocks mystock = new stocks();
               mystock.Price = 55;

               mystock.pricechanged += stockprice.changeinprice;

               mystock.Price = 99;

            }
        }
    }

