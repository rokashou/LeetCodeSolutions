/*
Runtime: 115 ms, faster than 58.95% of C# online submissions for Same Tree.
Memory Usage: 38.9 MB, less than 33.38% of C# online submissions for Same Tree.
Uploaded: 05/09/2022 22:21
*/


public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Stack<TreeNode> q1 = new Stack<TreeNode>();
        Stack<TreeNode> q2 = new Stack<TreeNode>();

        q1.Push(p); q2.Push(q);

        while(q1.Count > 0 && q2.Count > 0)
        {
            var node1 = q1.Pop();
            var node2 = q2.Pop();

            if (node1 == null && node2 != null) return false;
            if (node1 != null && node2 == null) return false;
            if (node1 == null && node2 == null) continue;

            if (node1.val == node2.val)
            {
                q1.Push(node1.left);
                q1.Push(node1.right);
                q2.Push(node2.left);
                q2.Push(node2.right);
            }
            else
                return false;
        }
        if (q1.Count + q2.Count == 0) return true;
        return false;
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
