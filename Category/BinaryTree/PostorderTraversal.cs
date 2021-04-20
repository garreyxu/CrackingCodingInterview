using System.Collections.Generic;

class PostorderTraversalSolution
{
    public PostorderTraversalSolution(){}

    #region Traverse
    public static IList<int> PostorderTraversal(TreeNode root)
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

    #endregion

    #region Divide and Conquer

    public static IList<int> PostorderDivideConquer(TreeNode root)
    {
        IList<int> postorder = new List<int>();
        if(root == null)
        {
            return postorder;
        }

        IList<int> left = PostorderDivideConquer(root.left);
        IList<int> right = PostorderDivideConquer(root.right);

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

    #endregion
}