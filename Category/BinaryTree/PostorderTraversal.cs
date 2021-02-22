using System.Collections.Generic;

class PostorderTraversalSolution
{
    public PostorderTraversalSolution(){}

    public static IList<int> PostorderTraversalRecursion(TreeNode root)
    {
        IList<int> postorder = new List<int>();
        if(root == null)
        {
            return postorder;
        }
        
        dfs(postorder, root);
        return postorder;
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
        if(root.right != null)
        {
            dfs(res, root.right);
        }
        res.Add(root.val);
    }

    public static IList<int> PostorderTraversalDC(TreeNode root)
    {
        IList<int> postorder = new List<int>();
        if(root == null)
        {
            return postorder;
        }

        IList<int> left = PostorderTraversalDC(root.left);
        IList<int> right = PostorderTraversalDC(root.right);

        foreach(int i in left)
        {
            postorder.Add(i);
        }
        foreach(int j in right)
        {
            postorder.Add(j);
        }
        postorder.Add(root.val);

        return postorder;
    }
}