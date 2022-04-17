#region Official Solution 1
/*
  Runtime: 109 ms, faster than 84.21% of C# online submissions for Convert BST to Greater Tree.
  Memory Usage: 44.7 MB, less than 5.26% of C# online submissions for Convert BST to Greater Tree.
  Uploaded: 04/17/2022 20:55
 */
public class Solution538_so1
{
    private int Sum = 0;

    public TreeNode ConvertBST(TreeNode root)
    {
        if(root != null)
        {
            ConvertBST(root.right);
            Sum += root.val;
            root.val = Sum;
            ConvertBST(root.left);
        }
        return root;
    }
}
#endregion

#region Official Solution 2
/*
  Runtime: 109 ms, faster than 84.21% of C# online submissions for Convert BST to Greater Tree.
  Memory Usage: 44.6 MB, less than 5.26% of C# online submissions for Convert BST to Greater Tree.
  Uploaded: 04/17/2022 21:01
 */
public class Solution538_so2
{
    public TreeNode ConvertBST(TreeNode root)
    {
        int sum = 0;
        TreeNode node = root;
        Stack<TreeNode> stack = new Stack<TreeNode>();

        while (stack.Count > 0 || node != null)
        {
            // push all nodes up to (and including) this subtree's maximum on the stack
            while(node != null){
                stack.Push(node);
                node = node.right;
            }

            node = stack.Pop();
            sum += node.val;
            node.val = sum;

            // all nodes with values between the current and its parent lie in the left subtree
            node = node.left;
        }

        return root;
    }
}
#endregion

#region Official Solution 3
public class Solution538
{
    /* Get the node with the smallest value greater than this one. */
    private TreeNode GetSuccessor(TreeNode node)
    {
        TreeNode succ = node.right;
        while(succ.left != null && succ.left != node)
        {
            succ = succ.left;
        }
        return succ;
    }

    public TreeNode ConvertBST(TreeNode root)
    {
        int sum = 0;
        TreeNode node = root;

        while(node != null)
        {
            if(node.right == null)
            {
                /* if there is no right subtree, then we can visit this node and 
                 * continue traversing left.
                 */
                sum += node.val;
                node.val = sum;
                node = node.left;
            }
            else {
                /* 
                 * If there is a right subtree, then there is at least one node that
                 * has a greater value than the current one. therefore, we must
                 * traverse that subtree first.
                 */
                TreeNode succ = GetSuccessor(node);
                // if the left subtree is null, then we have never been here before.
                if(succ.left == null)
                {
                    succ.left = node;
                    node = node.right;
                }
                else
                {
                    // if there is a left subtree, it is a link that we created on a
                    // previous pass, so we should unlink it and visit this node.
                    succ.left = null;
                    sum += node.val;
                    node.val = sum;
                    node = node.left;
                }
            }
        }

        return root;
    }
}
#endregion
