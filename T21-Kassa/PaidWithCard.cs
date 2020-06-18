using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Text;

namespace T21_Kassa
{
    class PaidWithCard : ITransaction
    {
        public float Money { get; set; }
        public string CardNumber { get; set; }
        private float TotalCard { get; set; }

        public void Payment(float money, string cardNumber)
        {

            CardNumber = cardNumber;
            Money = money;
            TotalCard += money;
        }

        public float ShowTotal()
        {
            return TotalCard;

        }

        public string ShowTransaction()
        {
            return "Transaction to bank: charge from card " + CardNumber
                + " " + "Date " + DateTime.Now +  " Amount: " + Money;
        }
    }
}
