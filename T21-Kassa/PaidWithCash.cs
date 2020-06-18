using System;
using System.Collections.Generic;
using System.Text;

namespace T21_Kassa
{
    class PaidWithCash : ITransaction
    {
        public float Money { get; set; }
        private int BillNumber { get; set; }
        private float TotalCash { get; set; }

        public void Payment(float money, int billNumber)
        {
            BillNumber = billNumber;
            Money = money;
            TotalCash =+ money;
        }

        public float ShowCash()
        {
            return TotalCash;
        }

        public string ShowTransaction()
        {
            return "Paid with cash: billnumber " + BillNumber + " "
                + DateTime.Now + " Amount: " + Money;
        }
    }
}
