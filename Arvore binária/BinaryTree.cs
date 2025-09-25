using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvore_binária
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; } = null!;
        public int Count { get; set; }

        public enum TraversalEnum
        {
            PREORDER, INORDER, POSTORDER
        }
        private void TraversePreOrder(
            BinaryTreeNode<T> node,
                List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        private void TraverseInOrder(
            BinaryTreeNode<T> node,
                List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }
        private void TraversePostOrder(
            BinaryTreeNode<T> node,
                List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> result = new List<BinaryTreeNode<T>>();

            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root, result);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root, result);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root, result);
                    break;
            }
            return result;
        }
    }
}

//tarefa : leitura da página 160 até 164 e implementar o quiz