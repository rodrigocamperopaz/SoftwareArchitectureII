using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringII.FluentInterface
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Item> Items { get; set; }

        public Order()
        {
            CreatedAt = DateTime.Now;
            Items = new List<Item>();
        }

        public Order(int id, List<Item> items)
        {
            Id = id;
            CreatedAt = DateTime.Now;
            Items = items;
        }
    }
}
