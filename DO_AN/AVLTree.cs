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

        public NodeAVL Search(NodeAVL root, int id)
        {
            if (root == null || root.Data.Id == id)
                return root;

            if (id < root.Data.Id)
                return Search(root.Left, id);
            else
                return Search(root.Right, id);
        }
        public NodeAVL Delete(NodeAVL root, int id)
        {
            if (root == null) return root;

            if (id < root.Data.Id)
                root.Left = Delete(root.Left, id);
            else if (id > root.Data.Id)
                root.Right = Delete(root.Right, id);
            else
            {
                if (root.Left == null || root.Right == null)
                {
                    NodeAVL temp = root.Left ?? root.Right;

                    if (temp == null)
                        return null; 
                    else
                        return temp; 
                }
                else
                {
                    NodeAVL temp = GetMinValueNode(root.Right);
                    root.Data = temp.Data;
                    root.Right = Delete(root.Right, temp.Data.Id);
                }
            }

            root.Height = Math.Max(Height(root.Left), Height(root.Right)) + 1;

            int balance = GetBalance(root);

            if (balance > 1 && GetBalance(root.Left) >= 0)
                return RotateRight(root);

            if (balance > 1 && GetBalance(root.Left) < 0)
            {
                root.Left = RotateLeft(root.Left);
                return RotateRight(root);
            }

            if (balance < -1 && GetBalance(root.Right) <= 0)
                return RotateLeft(root);

            if (balance < -1 && GetBalance(root.Right) > 0)
            {
                root.Right = RotateRight(root.Right);
                return RotateLeft(root);
            }

            return root;
        }

        private NodeAVL GetMinValueNode(NodeAVL node)
        {
            NodeAVL current = node;
            while (current.Left != null)
                current = current.Left;
            return current;
        }
        public bool UpdateNode(NodeAVL root, Xe newData)
        {
            var node = Search(root, newData.Id);
            if (node == null) return false;

            node.Data.Manufacturer = newData.Manufacturer;
            node.Data.Model = newData.Model;
            node.Data.Engine_size = newData.Engine_size;
            node.Data.Fuel_type = newData.Fuel_type;
            node.Data.Year_of_manufacture = newData.Year_of_manufacture;
            node.Data.Mileage = newData.Mileage;
            node.Data.Price = newData.Price;

            return true;
        }
        public List<Xe> GetNodesAtSpecificLevel(int targetLevel)
        {
            List<Xe> ds = new List<Xe>();
            GetNodesAtLevelRecursive(Root, 1, targetLevel, ds);
            return ds;
        }

        private void GetNodesAtLevelRecursive(NodeAVL node, int currentLevel, int targetLevel, List<Xe> ds)
        {
            if (node == null) return;

            if (currentLevel == targetLevel)
            {
                ds.Add(node.Data);
            }
            else
            {
                GetNodesAtLevelRecursive(node.Left, currentLevel + 1, targetLevel, ds);
                GetNodesAtLevelRecursive(node.Right, currentLevel + 1, targetLevel, ds);
            }
        }
       

    }
}

