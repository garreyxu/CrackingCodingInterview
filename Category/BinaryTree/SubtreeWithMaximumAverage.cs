class SubtreeWithMaximumAverage
{
    private TreeNode maxAveNode = null;
    private ResultType subtreeResult = null;
    
    public SubtreeWithMaximumAverage(){}

    public TreeNode FindSubtree2(TreeNode root)
    {
        Helper(root);
        return maxAveNode;
    }

    public ResultType Helper(TreeNode root)
    {
        if (root == null)
        {
            return new ResultType(0, 0);
        }

        ResultType left = Helper(root.left);
        ResultType right = Helper(root.right);

        ResultType rootResult = new ResultType
        (
            left.size + right.size + 1,
            left.sum + right.sum + root.val
        );

        if (maxAveNode == null 
            || rootResult.sum * 1.0 / rootResult.size > subtreeResult.sum * 1.0 / subtreeResult.size)
        {
            maxAveNode = root;
            subtreeResult = rootResult;
        }

        return rootResult;
    }

    public class ResultType 
    {
        public int size;
        public int sum;

        public ResultType(int size, int sum)
        {
            this.size = size;
            this.sum = sum;
        }
    }
    
}