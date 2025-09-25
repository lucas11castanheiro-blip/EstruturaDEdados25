using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvore_binária
{

    // Herdeiro : herança, ou seja, BinaryTreeNode herda de TreeNode
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        /* =>, chama-se Lambda, é uma forma reduzida de escrever funções que retornam um valor simples
        public BinaryTreeNode() => Children = new List<TreeNode<T>>
        (
            null, null
        //São dois Nulls porque uma árvore binária tem no máximo dois filhos
        //Desse modo os dois filhos já são inicializados como null
        );
        */

        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>>();
            Children.Add(null!);
            Children.Add(null!);
        }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }   

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

    }
}