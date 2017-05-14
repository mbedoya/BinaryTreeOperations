using BinaryTreeOperations.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations.Model
{
    public class BinaryTree
    {
        private NodeDTO root;

        public BinaryTree()
        {
            
        }

        public BinaryTree(int rootValue)
        {
            root = new NodeDTO();
            root.Value = rootValue;
        }

        public NodeDTO AddNode(int value)
        {
            if (root == null)
            {
                root = new NodeDTO();
                root.Value = value;
            }

            return AddNodeToTree(root, value);
        }

        public int GetMaxHeight()
        {
            return GetMaxTreeHeight(root);
        }

        private int GetMaxTreeHeight(NodeDTO node)
        {
            if (node == null)
            {
                return 0;
            }
            int leftHeight = GetMaxTreeHeight(node.LeftNode);
            int rightHeight = GetMaxTreeHeight(node.RightNode);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }

        private NodeDTO AddNodeToTree(NodeDTO node, int value)
        {
            if (value < node.Value)
            {
                if (node.LeftNode == null)
                {
                    NodeDTO newNode = new NodeDTO();
                    newNode.Value = value;
                    node.LeftNode = newNode;

                    return newNode;
                }
                else
                {
                    return AddNodeToTree(node.LeftNode, value);
                }
            }
            else
            {
                if (value > node.Value)
                {
                    if (node.RightNode == null)
                    {
                        NodeDTO newNode = new NodeDTO();
                        newNode.Value = value;
                        node.RightNode = newNode;

                        return newNode;
                    }
                    else
                    {
                        return AddNodeToTree(node.RightNode, value);
                    }
                }
                else
                {
                    throw new Exception(String.Format("Can't add nodes with the same value {0}", value));
                }
            }
        }
    }
}
