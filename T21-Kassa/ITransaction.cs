using System;
using System.Collections.Generic;
using System.Text;

namespace T21_Kassa
{
   public interface ITransaction
    {
        string ShowTransaction();
        float Money { get; set; }
    }
}
