/*
Runtime: 149 ms, faster than 27.92% of C# online submissions for Symmetric Tree.
Memory Usage: 39.3 MB, less than 60.67% of C# online submissions for Symmetric Tree.
Uploaded: 05/10/2022 00:03
*/


public class Solution {
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode> leftTree = new Queue<TreeNode>();
        Queue<TreeNode> rightTree = new Queue<TreeNode>();
        leftTree.Enqueue(root.left);
        rightTree.Enqueue(root.right);

        while(leftTree.Count > 0 && rightTree.Count > 0)
        {
            var leftNode = leftTree.Dequeue();
            var rightNode = rightTree.Dequeue();
            if (leftNode == null && null == rightNode)
                continue;
            if (leftNode == null || rightNode == null)
                return false;
            if (leftNode.val != rightNode.val)
                return false;
            leftTree.Enqueue(leftNode.left);
            leftTree.Enqueue(leftNode.right);
            rightTree.Enqueue(rightNode.right);
            rightTree.Enqueue(rightNode.left);
        }
        if (leftTree.Count + rightTree.Count > 0) return false;
        return true;

    }
}


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
