/*
    url: https://leetcode.com/problems/range-sum-of-bst/
    Uploaded: 12/14/2021 22:45
    Runtime: 239 ms, faster than 21.44% of C# online submissions for Range Sum of BST.
    Memory Usage: 44.2 MB, less than 100.00% of C# online submissions for Range Sum of BST.
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
    public int RangeSumBST(TreeNode root, int low, int high) {
        int result=0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0){
            TreeNode temp = stack.Pop();
            if(temp.left!=null) stack.Push(temp.left);
            if(temp.right!=null) stack.Push(temp.right);
            if(temp.val >= low && temp.val <= high) result += temp.val;
        }
        return result;

    }
}
