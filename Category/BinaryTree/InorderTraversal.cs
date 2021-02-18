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

    public static IList<int> InorderTraversalRecursion(TreeNode root)
    {
        IList<int> inorder = new List<int>();
        if(root == null)
        {
            return inorder;
        }
        dfs(inorder, root);
        return inorder;
    }

    private static void dfs(IList<int> res, TreeNode root)
    {
        if(root == null)
        {
            return;
        }
        if(root.left != null)
        {
            dfs(res, root.left);
        }
        res.Add(root.val);
        if(root.right != null)
        {
            dfs(res, root.right);
        }
    }
}