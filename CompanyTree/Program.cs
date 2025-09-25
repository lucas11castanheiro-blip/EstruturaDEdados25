using CompanyTree;

Tree<PersonTreeNode> companyTree = new Tree<PersonTreeNode>();
companyTree.Root = new PersonTreeNode()
{
    Data = new PersonTreeNode(100, "Marcin Jamro", "CEO"),
    Parent = null
};
companyTree.Root.Children = new List<PersonTreeNode>()
{
    new PersonTreeNode()
    {
        Data = new PersonTreeNode(1, "John Smith", "Head of Development"),
        Parent = PersonTreeNode.Root
    },
    new PersonTreeNode()
    {
        Data = new PersonTreeNode(50, "Mary Fox", "Head of Research"),
        Parent = PersonTreeNode.Root
    },
    new PersonTreeNode()
    {
        Data = new PersonTreeNode(150, "Lily Smith", "Head of Sales"),
        Parent = PersonTreeNode.Root
    }
};
companyTree.Root.Children[2].Children = new List<PersonTreeNode>()
{
    new PersonTreeNode()
    {
        Data = new PersonTreeNode(30,"Anthony Black","Sales Specialist"),
        Parent = PersonTreeNode.Root.Children[2]
    }
};