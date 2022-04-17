/*
Runtime: 93 ms, faster than 77.42% of C# online submissions for Binary Search Tree to Greater Sum Tree.
Memory Usage: 38 MB, less than 24.73% of C# online submissions for Binary Search Tree to Greater Sum Tree.
Uploaded: 04/17/2022 21:17
*/

public class Solution {
    public TreeNode BstToGst(TreeNode root) {
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
