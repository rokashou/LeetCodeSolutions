/*
Runtime: 190 ms, faster than 77.06% of C# online submissions for Path Sum II.
Memory Usage: 42.9 MB, less than 80.59% of C# online submissions for Path Sum II.
Uploaded: 09/24/2022 23:47
*/

public class Solution {
    IList<IList<int>> result = new List<IList<int>>();
    List<int> path = new List<int>();

    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        dfs(root, 0, targetSum); // using dfs to traverse on each node
        return result;
    }

    private void dfs(TreeNode root, int current, int target)
    {
        if (root == null) return; // if current root is null, then return

        current += root.val;
        path.Add(root.val);

        // When we reach at leaf node, we have to check if current sum is
        // equal to target
        if(current == target && root.left == null && root.right == null)
        {
            result.Add(path.ToList());
        }

        dfs(root.left, current, target);
        dfs(root.right, current, target);

        path.RemoveAt(path.Count-1);
    }
}
