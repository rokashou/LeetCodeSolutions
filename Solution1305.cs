/*
Runtime: 533 ms, faster than 13.04% of C# online submissions for All Elements in Two Binary Search Trees.
Memory Usage: 49.8 MB, less than 15.22% of C# online submissions for All Elements in Two Binary Search Trees.
Uploaded: 01/26/2022 20:42
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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if(root1 != null) stack.Push(root1);
        if(root2 != null) stack.Push(root2);
        while(stack.Count > 0){
            var tmp = stack.Pop();
            list.Add(tmp.val);
            if(tmp.left != null) stack.Push(tmp.left);
            if(tmp.right != null) stack.Push(tmp.right);

        }
        list.Sort();
        return list;
    }
}
