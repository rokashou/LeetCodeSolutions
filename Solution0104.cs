/*
Runtime: 146 ms, faster than 18.04% of C# online submissions for Maximum Depth of Binary Tree.
Memory Usage: 38.2 MB, less than 43.32% of C# online submissions for Maximum Depth of Binary Tree.
Uploaded: 05/13/2022 21:07	
*/


public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int levels = 0;
        while(queue.Count > 0)
        {
            levels += 1;
            for(int i = queue.Count; i > 0; i--)
            {
                var node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
        return levels;
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
 
