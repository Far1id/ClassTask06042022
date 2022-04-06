using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException(string msg):base(msg)
        {

        }
    }
}
