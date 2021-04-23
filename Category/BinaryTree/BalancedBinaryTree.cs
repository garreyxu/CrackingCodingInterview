/*
1. result type
2. balanced binary tree
2.1 when the difference between left subtree height and right 
subtree height is not more than 1, then it's a balanced binary tree
*/

using System;

public class ResultType 
{
    public bool isBalanced;
    public int height;
    public ResultType(bool isBalanced, int height)
    {
        this.isBalanced = isBalanced;
        this.height = height;
    }
}


class BalancedBinaryTree
{
    public BalancedBinaryTree(){}

     public bool IsBalanced(TreeNode root) {
        return Helper(root).isBalanced;
    }

    private ResultType Helper(TreeNode root)
    {
        if (root == null) 
        {
            return new ResultType(true, 0);
        }

        ResultType left = Helper(root.left); 
        ResultType right = Helper(root.right);

        if (!left.isBalanced || !right.isBalanced) 
        {
            return new ResultType(false, -1);
        }

        if (Math.Abs(left.height - right.height) > 1)
        {
            return new ResultType(false, -1);
        }

        return new ResultType(true, Math.Max(left.height, right.height) + 1);
    }
}