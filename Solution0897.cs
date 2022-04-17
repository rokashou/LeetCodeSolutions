/*
My Solution 01
Runtime: 95 ms, faster than 75.71% of C# online submissions for Increasing Order Search Tree.
Memory Usage: 38.1 MB, less than 14.29% of C# online submissions for Increasing Order Search Tree.
Uploaded: 04/17/2022 22:26
*/

public class Solution897
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        TreeNode finalRoot = null;
        TreeNode crt = null;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            if (node == null)
            {
                continue;
            }

            if (node.left != null)
            {
                var leftNode = node.left;
                node.left = null;
                stack.Push(node);
                stack.Push(leftNode);
                continue;
            }

            if(node.right != null)
            {
                stack.Push(node.right);
                node.right = null;
            }

            if(finalRoot == null)
            {
                finalRoot = node;
                crt = finalRoot;
                continue;
            }

            crt.right = node;
            crt = crt.right;
        }
        return finalRoot;

    }
}


#region Approach 01
/*
 Runtime: 96 ms, faster than 75.00% of C# online submissions for Increasing Order Search Tree.
 Memory Usage: 37.9 MB, less than 17.86% of C# online submissions for Increasing Order Search Tree.
 Uploaded: 04/17/2022 22:55
 */
public class Solution897_Ap01
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        List<int> vals = new List<int>();
        inorder(root, vals);
        TreeNode ans = new TreeNode(0), cur = ans;
        foreach (var v in vals)
        {
            cur.right = new TreeNode(v);
            cur = cur.right;
        }
        return ans.right;
    }

    void inorder(TreeNode node, List<int> vals)
    {
        if (node == null) return;
        inorder(node.left, vals);
        vals.Add(node.val);
        inorder(node.right, vals);
    }
}
#endregion // App01

#region Approach 02
/*
    Runtime: 86 ms, faster than 83.57% of C# online submissions for Increasing Order Search Tree.
    Memory Usage: 38.2 MB, less than 14.29% of C# online submissions for Increasing Order Search Tree.
    Uploaded: 04/17/2022 23:06
 */
public class Solution897_Ap02
{
    TreeNode cur;

    public TreeNode IncreasingBST(TreeNode root)
    {
        TreeNode ans = new TreeNode(0);
        cur = ans;
        Inorder(root);
        return ans.right;
    }

    private void Inorder(TreeNode node)
    {
        if (node == null) return;
        Inorder(node.left);
        node.left = null;
        cur.right = node;
        cur = node;
        Inorder(node.right);
    }
}
#endregion // App02


