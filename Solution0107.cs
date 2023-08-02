/*
Aug 02, 2023 23:04
Runtime 140 ms Beats 81.93%
Memory 43.5 MB Beats 37.35%
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var res = new List<IList<int>>();

        if (root == null) return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            var qCount = q.Count;
            var currentLevel = new List<int>();

            while(qCount-- > 0)
            {
                var currentNode = q.Dequeue();
                currentLevel.Add(currentNode.val);

                if (currentNode.left != null)
                    q.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    q.Enqueue(currentNode.right);
            }

            res.Insert(0, currentLevel);
        }

        return res;
    }
}
