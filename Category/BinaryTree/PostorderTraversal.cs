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
}