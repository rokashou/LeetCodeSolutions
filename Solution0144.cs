/*
Aug 22, 2023 22:45
Runtime 132 ms Beats 69.73%
Memory 42.6 MB Beats 37.72%
*/

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> answer = new();
        Stack<TreeNode> stack = new();
        stack.Push(root);

        while(stack.Count > 0)
        {
            var curr = stack.Pop();
            if(curr != null)
            {
                answer.Add(curr.val);
                stack.Push(curr.right);
                stack.Push(curr.left);
            }
        }

        return answer;        
    }
}
