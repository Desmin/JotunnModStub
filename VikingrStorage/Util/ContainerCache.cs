using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingrStorage.Util
{
    public class ContainerCache
    {
        private List<Container> Containers { get; set; }

        public ContainerCache()
        {
            Containers = InitializeCache();
        }

        private List<Container> InitializeCache()
        {
            return null;
        }
    }
}
