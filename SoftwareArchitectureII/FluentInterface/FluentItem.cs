using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringII.FluentInterface
{
    public class FluentItem
    {
        private readonly Item _item = new Item();

        public FluentItem(Item item)
        {
            _item = item;
        }

        public FluentItem IdOfTheItem(string Id)
        {
            _item.Id = Id;
            return this;
        }

        public FluentItem NameOfTheItem(string Name)
        {
            _item.Name = Name;
            return this;
        }

        public Item Item
        {
            get { return _item; }
        }
    }
}
