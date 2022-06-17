/*
Runtime: 147 ms, faster than 33.33% of C# online submissions for Binary Tree Cameras.
Memory Usage: 38.8 MB, less than 44.44% of C# online submissions for Binary Tree Cameras.
Uploaded: 06/17/2022 20:20	
*/


public class Solution {
    private int ans;
    private HashSet<TreeNode> covered;
    public int MinCameraCover(TreeNode root)
    {
        ans = 0;
        covered = new HashSet<TreeNode>();
        covered.Add(null);

        dfs(root, null);
        return ans;

    }

    private void dfs(TreeNode node, TreeNode parent)
    {
        if(node != null)
        {
            dfs(node.left, node);
            dfs(node.right, node);

            if(parent == null && !covered.Contains(node)
                || !covered.Contains(node.left)
                || !covered.Contains(node.right))
            {
                ans++;
                covered.Add(node);
                covered.Add(parent);
                covered.Add(node.left);
                covered.Add(node.right);
            }
        }
    }
}
