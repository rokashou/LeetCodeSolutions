/*
Runtime 521 ms, Beats 22.76%
Memory 57.9 MB, Beats 56.9%
Accepted: Jan 27, 2023 21:20
*/

public class Solution {
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(null);
        int result = 0;

        while(q.Count > 0)
        {
            var tmp = q.Dequeue();
            if(tmp == null)
            {
                result += 1;
                if (q.Count > 0) q.Enqueue(null);
                continue;
            }
            if (tmp.left == null && tmp.right == null) break;
            if (tmp.left != null) q.Enqueue(tmp.left);
            if (tmp.right != null) q.Enqueue(tmp.right);
        }

        return result+1;
    }
}
