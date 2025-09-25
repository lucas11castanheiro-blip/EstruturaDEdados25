using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Árvores
{
    //<T> O T é a espeficificação de um tipo genérico, vai permitir dizer o tipo da minha classe
    //Como a classe criada é genérica, todos os itens a seguir serão do mesmo tipo que eu atribuir a classe
    //Assim, criando uma árvore toda de strings por exemplo
    public class TreeNode<T>
    {
        public T Data { get; set; }//Dado que o nó vai armazenar o valor de fato
        public TreeNode<T> Parent { get; set; } //o atributo Parent será a referência ao Nó pai 
        public List<TreeNode<T>> Children { get; set; } //Lista de filhos, do tipo genérico

        public int GetHeight()
        {
            int height = 1; //altura começa em 1, porque o nó em si já conta como altura
            TreeNode<T> current = this; //nó atual é this, começa sendo ele mesmo

            while (current.Parent != null)
            {
                height++;
                current = current.Parent;

            }
            return height;

        }

    }
}