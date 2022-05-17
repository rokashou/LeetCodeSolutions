/*
Runtime: 327 ms, faster than 83.61% of C# online submissions for Find a Corresponding Node of a Binary Tree in a Clone of That Tree.
Memory Usage: 47.9 MB, less than 96.72% of C# online submissions for Find a Corresponding Node of a Binary Tree in a Clone of That Tree.
Uploaded: 05/17/2022 21:28
*/
public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if (object.ReferenceEquals(original, target)) return cloned;

        TreeNode lresult = null;
        TreeNode rresult = null;
        if (original.left != null) lresult = GetTargetCopy(original.left, cloned.left, target);
        if (original.right != null) rresult = GetTargetCopy(original.right, cloned.right, target);
        return lresult ?? rresult;
    }
}




/*
Runtime: 461 ms, faster than 34.43% of C# online submissions for Find a Corresponding Node of a Binary Tree in a Clone of That Tree.
Memory Usage: 48 MB, less than 96.72% of C# online submissions for Find a Corresponding Node of a Binary Tree in a Clone of That Tree.
Uploaded: 05/17/2022 21:21
*/

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        stack1.Push(original);
        stack2.Push(cloned);

        while (stack1.Count > 0)
        {
            var node1 = stack1.Pop();
            var node2 = stack2.Pop();
            if (object.ReferenceEquals(node1,target))
            {
                return node2;
            }
            if (node1.left != null)
            {
                stack1.Push(node1.left);
                stack2.Push(node2.left);
            }
            if (node1.right != null)
            {
                stack1.Push(node1.right);
                stack2.Push(node2.right);
            }
        }
        return null;
    }
}
