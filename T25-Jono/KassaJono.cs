using System;
using System.Collections.Generic;
using System.Text;

namespace T25_Jono
{
    class KassaJono
    {
        public Queue<string> CashierQueue { get; set;}
        public int Lenght { get; set; }
        
        public KassaJono(Queue<string> cashierQueue)
        {
            CashierQueue = cashierQueue;
        }
        public void GoToLine(string name)
        {
            CashierQueue.Enqueue(name);
        }
        public string LeaveLine()
        {
            return "Palvellaan asiakasta: " + CashierQueue.Dequeue();
        }
        public int CheckLenght()
        {
            Lenght = CashierQueue.Count;
            return Lenght;
        } 
    }
}
