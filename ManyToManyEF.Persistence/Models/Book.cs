using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEF.Persistence.Models
{
    public class Book
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<Category> Categories { get; private set; }

        public Book(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Categories = new List<Category>();
        }
    }
}
