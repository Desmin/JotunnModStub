using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingrStorage.Util
{
    public class ContainerCache
    {
        private SortedList<string, List<Container>> Containers { get; set; }

        public ContainerCache()
        {
            Containers = InitializeCache();
        }

        private SortedList<string, List<Container>> InitializeCache()
        {
            return null;
        }

    }
}