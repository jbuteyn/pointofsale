using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
   class PaymentMethod
    {
        public string CreditCard;
        public string Cash;
        public string Check;

        public void Payment()
        {
            var cash = new Cash();
            var check = new Check();
            var ccNumber = new CreditCard();
        }
    }
}
