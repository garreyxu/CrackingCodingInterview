using System.Collections.Generic;

class BinarayTreePath
{
    public BinarayTreePath(){}

    public IList<string> BinaryTreePaths(TreeNode root)
    {
        IList<string> paths = new List<string>();

        if (root == null)
        {
            return paths;
        }

        if (root.left == null && root.right == null)
        {
            paths.Add(root.val + "");
            return paths;
        } 

        IList<string> leftPaths = BinaryTreePaths(root.left);
        IList<string> rightPaths = BinaryTreePaths(root.right);

        foreach (string path in leftPaths)
        {
            paths.Add(root.val + "->" + path);
        }
        foreach (string path in rightPaths)
        {
            paths.Add(root.val + "->" + path);
        } 

        return paths;
    }
}