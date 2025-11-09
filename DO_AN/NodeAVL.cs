using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN
{
    public  class NodeAVL
    {
        public Xe Data { get; set; }
        public NodeAVL Left { get; set; }
        public NodeAVL Right { get; set; }
        public int Height { get; set; }

        public NodeAVL(Xe data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
        }
    }
}
