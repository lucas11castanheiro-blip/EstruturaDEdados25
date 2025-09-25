using Árvores;

//Declaração de variável tree do tipo Tree, onde Tree<int> agora é de inteiros
Tree<int> tree = new Tree<int>();

//Root é o nó raiz da árvore 
//instanciado com seu tipo treeNode
//Onde treeNode<int> é do tipo inteiro

tree.Root = new TreeNode<int>(); //Criação do nó raiz
tree.Root.Data = 100; //Atribuição do valor 100 ao nó raiz

tree.Root.Children =
    new List<TreeNode<int>>() //inicialização da lista de filhos
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root },
    new TreeNode<int>() { Data = 1, Parent = tree.Root },
    new TreeNode<int>() { Data = 150, Parent = tree.Root },
};

tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>()
    {
    Data = 30,
    Parent = tree.Root.Children[2]
    }
};