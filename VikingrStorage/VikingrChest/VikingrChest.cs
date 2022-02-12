using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VikingrStorage.VikingrChest
{
    class VikingrChest
    {
        private float x, y, z;
        private Repository[] Repositories { get; set; }

        public VikingrChest(Piece chest, Repository[] repositories)
        {
            Repositories = repositories;
            Vector3 position = chest.m_localCenter;
            x = position.x;
            y = position.y;
            z = position.z;
        }

        public bool SortItem()
        {
            return false;
        }

        public bool SortItems()
        {
            return false;
        }
    }
}
