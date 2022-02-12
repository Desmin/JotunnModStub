using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingrStorage.VikingrChest
{
    class Repository
    {
        public string Name { get; set; }

        private List<string> Items { get; set; }

        public Repository(string name, string[] items)
        {
            Name = name;
            Items = new List<string>(items);
            Items.Sort();
        }
    }
}
