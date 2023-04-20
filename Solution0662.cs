/*
Apr 20, 2023 22:47
Runtime 90 ms Beats 76.25%
Memory 39.5 MB Beats 91.25%
*/


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
public class Solution {
    public int WidthOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return 1;

        int maxWidth = 0;
        var q = new Queue<(TreeNode,int)>();
        q.Enqueue((root, 0));

        while(q.Count > 0)
        {
            int size = q.Count, left = int.MaxValue, right = int.MinValue;

            for(int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                left = Math.Min(left, node.Item2);
                right = Math.Max(right, node.Item2);

                if (node.Item1.left != null)
                    q.Enqueue((node.Item1.left, 2 * node.Item2 + 1));
                if (node.Item1.right != null)
                    q.Enqueue((node.Item1.right, 2 * node.Item2 + 2));
            }

            maxWidth = Math.Max(maxWidth, right - left + 1);
        }

        return maxWidth; 
    }
}
