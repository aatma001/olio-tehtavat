using System;

namespace T21_Kassa
{
    class Program
    {
        static void Main(string[] args)
        {
            PaidWithCard cardPay = new PaidWithCard();
            cardPay.Payment(50.4f, "100-666");
            Console.WriteLine(cardPay.ShowTransaction());
            cardPay.Payment(31.2f, "200-135");
            Console.WriteLine(cardPay.ShowTransaction());
            Console.WriteLine("Total money in the bank: " + Math.Round(cardPay.ShowTotal(), 2));
            Console.WriteLine("");

            PaidWithCash cashPay = new PaidWithCash();
            cashPay.Payment(30, 1);
            Console.WriteLine(cashPay.ShowTransaction());
            cashPay.Payment(50, 2);
            Console.WriteLine(cashPay.ShowTransaction());
            Console.WriteLine("Total money in cash: " + cashPay.ShowCash());
            Console.WriteLine("");

            float total = cardPay.ShowTotal() + cashPay.ShowCash();
            Console.WriteLine("Total sales today " + DateTime.Now + " " + total);




        }

        




    }
}
