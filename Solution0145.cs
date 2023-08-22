/*
Aug 22, 2023 22:57
Runtime 134 ms Beats 64.75%
Memory 42.6 MB Beats 56.76%
*/

public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> answer = new();
        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            if (curr != null)
            {
                answer.Insert(0,curr.val);
                stack.Push(curr.left);
                stack.Push(curr.right);
            }
        }

        return answer;
    }
}
