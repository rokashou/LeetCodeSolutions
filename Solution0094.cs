/*
Runtime: 257 ms, faster than 7.94% of C# online submissions for Binary Tree Inorder Traversal.
Memory Usage: 40.9 MB, less than 67.67% of C# online submissions for Binary Tree Inorder Traversal.
Uploaded: 04/20/2022 23:24
*/


public class Solution {
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        helper(root, res);
        return res;
    }

    public void helper(TreeNode root, List<int> res)
    {
        if (root != null)
        {
            helper(root.left, res);
            res.Add(root.val);
            helper(root.right, res);
        }
    }
}
