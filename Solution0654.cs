/*
Runtime 106 ms, Beats 76.27%
Memory 46.3 MB, Beats 45.76%
Accepted: Jan 20, 2023 14:50
*/

public class Solution {
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        var stack = new Stack<TreeNode>();
        for(int i = 0; i < nums.Length; i++)
        {
            TreeNode cur = new TreeNode(nums[i]);
            while(stack.Count > 0 && stack.Peek().val < nums[i])
            {
                cur.left = stack.Pop();
            }
            if (stack.Count > 0) stack.Peek().right = cur;
            stack.Push(cur);
        }
        while (stack.Count > 1) stack.Pop();
        return stack.Pop();
    }
}

