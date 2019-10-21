using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class OrderRepository
    {
        IOrderContext Context;

        public OrderRepository(IOrderContext orderContext)
        {
            Context = orderContext;
        }
    }
}
