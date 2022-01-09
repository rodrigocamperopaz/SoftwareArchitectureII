using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringII.FluentInterface
{
    public class FluentOrder
    {
        private readonly Order _order = new Order();

        public FluentOrder(Order order)
        {
            _order = order;
        }

        public FluentOrder IdOfTheOrder(int Id)
        {
            _order.Id = Id;
            return this;
        }

        public FluentOrder AddItem(Item Item)
        {
            _order.Items.Add(Item);
            return this;
        }

        public Order Order
        {
            get { return _order; }
        }
    }
}
