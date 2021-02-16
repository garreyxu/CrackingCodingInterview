using System;
using System.Collections.Generic;

class PreorderTraversalSolution
{
    public PreorderTraversalSolution(){}

    public static IList<int> PreorderTraversalNonRecursion(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        IList<int> preorder = new List<int>();

        if(root == null)
        {
            return preorder;
        }

        stack.Push(root);
        while(stack.Count != 0)
        {
            TreeNode node = stack.Pop();
            preorder.Add(node.val);
            if(node.right != null)
            {
                stack.Push(node.right);
            }
            if(node.left != null)
            {
                stack.Push(node.left);
            }
        }
        return preorder;
    }

    public static IList<int> PreorderTraversalRecursion(TreeNode root)
    {
        IList<int> result = new List<int>();
        if(root == null)
        {
            return result;
        }
        traverse(root, result);
        return result;
    }

    private static void traverse(TreeNode root, IList<int> result)
    {
        if(root == null)
        {
            return;
        }

        result.Add(root.val);
        if(root.left != null)
        {
            traverse(root.left, result);
        }
        if(root.right != null)
        {
            traverse(root.right, result);
        }
    }

    public static IList<IList<int>> GetResultNonRecursion()
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> orderedNodes1 = new List<int>();
        IList<int> orderedNodes2 = new List<int>();
        
        TreeNode root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
        TreeNode root2 = new TreeNode(0, null, null);

        orderedNodes1 = PreorderTraversalNonRecursion(root1);
        orderedNodes2 = PreorderTraversalNonRecursion(root2);

        result.Add(orderedNodes1);
        result.Add(orderedNodes2);

        return result;
    }

    public static IList<IList<int>> GetResultRecursion()
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> orderedNodes1 = new List<int>();
        IList<int> orderedNodes2 = new List<int>();
        
        TreeNode root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
        TreeNode root2 = new TreeNode(0, null, null);

        orderedNodes1 = PreorderTraversalRecursion(root1);
        orderedNodes2 = PreorderTraversalRecursion(root2);

        result.Add(orderedNodes1);
        result.Add(orderedNodes2);

        return result;
    }

    public static void Print()
    {
        IList<IList<int>> resultNonRecursion = GetResultNonRecursion();
        Console.WriteLine("Non Recursion: ");
        foreach(var orderedNodes in resultNonRecursion)
        {
            Console.Out.Write("[");
            foreach(var node in orderedNodes)
            {
                Console.Out.Write(node);
                Console.Out.Write(", ");
            }
            Console.Out.WriteLine("]");
        }
        
        IList<IList<int>> resultRecursion = GetResultRecursion();
        Console.WriteLine("Recursion: ");
        foreach(var orderedNodes in resultRecursion)
        {
            Console.Out.Write("[");
            foreach(var node in orderedNodes)
            {
                Console.Out.Write(node);
                Console.Out.Write(", ");
            }
            Console.Out.WriteLine("]");
        }
        
    }
}