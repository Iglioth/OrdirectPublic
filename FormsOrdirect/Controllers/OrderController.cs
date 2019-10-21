using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class OrderController
    {
        OrderRepository repo;
        IOrderContext context;

        public OrderController()
        {
            repo = new OrderRepository(context);
            context = new OrderMSSQLContext();
        }
    }
}
