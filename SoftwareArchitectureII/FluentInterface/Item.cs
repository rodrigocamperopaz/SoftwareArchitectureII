using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringII.FluentInterface
{
    public class Item
    {
        public string? Id { get; set; }
        public string? Name { get; set; }

        public Item()
        {

        }

        public Item(string? id, string? name)
        {
            Id = id;
            Name = name;
        }
    }
}
