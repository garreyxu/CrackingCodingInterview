using System.Collections.Generic;

class InorderTraversalSolution
{
    public InorderTraversalSolution(){}

    public static IList<int> InorderTraversalNonRecursion(TreeNode root)
    {
        IList<int> inorder = new List<int>();
        var stack = new Stack<TreeNode>();

        if(root == null)
        {
            return inorder;
        }

        TreeNode node = root;
        while(node != null || stack.Count != 0)
        {
            if(node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            node = stack.Pop();
            inorder.Add(node.val);
            node = node.right;
        }
        return inorder;
    }
}