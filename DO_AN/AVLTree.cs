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

        private int Height(NodeAVL n)
        {
                if (n == null)
                    return 0;
                else
                    return n.Height;
            
        }

        private int GetBalance(NodeAVL n)
        {

            if (n == null)
            {
                return 0; 
            }
            else
            {
                return Height(n.Left) - Height(n.Right);
            }
        }

        private NodeAVL RotateRight(NodeAVL x)
        {
            if (x == null || x.Left == null)
                return x;
            NodeAVL y = x.Left;
            NodeAVL z = y.Right;

            y.Right = x;
            x.Left = z;

            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

            return y;
        }

        private NodeAVL RotateLeft(NodeAVL x)
        {
            if (x == null || x.Right== null)
                return x;
            NodeAVL y = x.Right;
            NodeAVL z = y.Left;

            y.Left = x;
            x.Right = z;

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
                return node; 

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = GetBalance(node);

            
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
        public NodeAVL Insert1(NodeAVL node, Xe data)
        {
            if (node == null)
                return new NodeAVL(data);

            if (data.Price < node.Data.Price)
                node.Left = Insert1(node.Left, data);
            else if (data.Price > node.Data.Price)
                node.Right = Insert1(node.Right, data);
            else
                return node; 

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = GetBalance(node);

            
            if (balance > 1 && data.Price < node.Left.Data.Price)
                return RotateRight(node);

            if (balance < -1 && data.Price > node.Right.Data.Price)
                return RotateLeft(node);

            if (balance > 1 && data.Price > node.Left.Data.Price)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            if (balance < -1 && data.Price< node.Right.Data.Price)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        public void InOrder(NodeAVL node, List<Xe> ds)
        {
            if (node != null)
            {
                InOrder(node.Left, ds);
                ds.Add(node.Data);
                InOrder(node.Right, ds);
            }
        }
        public int GetTreeHeight()
        {
            return Height(Root);
        }
        public int demLa(NodeAVL root)
        {
            if (root == null)
                return 0;
            if (root.Left == null && root.Right == null)
                return 1;
            return demLa(root.Left) + demLa(root.Right);
        }

        public int soLa()
        {
            return demLa(Root);
        }
        
        public int demLaLeft()
        {
            if (Root == null || Root.Left == null)
                return 0;
            return demTongNode(Root.Left);
        }

        
        public int demLaRight()
        {
            if (Root == null || Root.Right == null)
                return 0;
            return demTongNode(Root.Right);
        }

        private int demTongNode(NodeAVL node)
        {
            if (node == null)
                return 0;
            return 1 + demTongNode(node.Left) + demTongNode(node.Right);
        }
        public string FindPosition(int id)
        {


            return " ";
        }
    }
}

