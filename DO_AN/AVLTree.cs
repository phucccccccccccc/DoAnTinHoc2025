using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN
{
   public  class AVLTree
    {
        public NodeAVL Root;

        private int Height(NodeAVL n) => n?.Height ?? 0;

        private int GetBalance(NodeAVL n) => n == null ? 0 : Height(n.Left) - Height(n.Right);

        private NodeAVL RotateRight(NodeAVL y)
        {
            var x = y.Left;
            var T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

            return x;
        }

        private NodeAVL RotateLeft(NodeAVL x)
        {
            var y = x.Right;
            var T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

            return y;
        }

        public NodeAVL Insert(NodeAVL node, Xe data)
        {
            if (node == null)
                return new NodeAVL(data);

            if (data.Id < node.Data.Id)
                node.Left = Insert(node.Left, data);
            else if (data.Id > node.Data.Id)
                node.Right = Insert(node.Right, data);
            else
                return node; // Không chèn trùng Id

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = GetBalance(node);

            // 4 trường hợp mất cân bằng
            if (balance > 1 && data.Id < node.Left.Data.Id)
                return RotateRight(node);

            if (balance < -1 && data.Id > node.Right.Data.Id)
                return RotateLeft(node);

            if (balance > 1 && data.Id > node.Left.Data.Id)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            if (balance < -1 && data.Id < node.Right.Data.Id)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        // Duyệt cây theo thứ tự giữa (In-Order)
        public void InOrder(NodeAVL node, List<Xe> ds)
        {
            if (node != null)
            {
                InOrder(node.Left, ds);
                ds.Add(node.Data);
                InOrder(node.Right, ds);
            }
        }
    }
}

