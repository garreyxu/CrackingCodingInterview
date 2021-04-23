class MinimumSubtree
{
    private TreeNode subtree = null;
    private int subtreeSum = int.MaxValue;
    public MinimumSubtree(){}

    public TreeNode FindSubtree(TreeNode root)
    {
        helper(root);
        return subtree;
    }

    private int helper(TreeNode root)
    {
        if (root == null) 
        {
            return 0;
        }

        int sum = helper(root.left) + helper(root.right) + root.val;

        if (sum < subtreeSum)
        {
            subtreeSum = sum;
            subtree = root;
        }

        return sum;
    }
}