/*
Runtime 89 ms Beats 63.46%
Memory 38.4 MB, Beats 17.31%
Feb 17, 2023 23:37
*/

public class Solution {
    public int MinDiffInBST(TreeNode root) {
        List<int> list = new List<int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0)
        {
            var tmp = stack.Pop();
            list.Add(tmp.val);
            if (tmp.left != null) stack.Push(tmp.left);
            if (tmp.right != null) stack.Push(tmp.right);
        }
        list.Sort();
        int ans = int.MaxValue;
        for(int i = 1; i < list.Count; i++)
        {
            ans = Math.Min(ans, list[i] - list[i-1]);
        }
        return ans;    }
}
