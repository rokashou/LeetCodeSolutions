/*
Runtime: 134 ms, faster than 44.86% of C# online submissions for Kth Smallest Element in a BST.
Memory Usage: 41 MB, less than 47.70% of C# online submissions for Kth Smallest Element in a BST.
Uploaded: 04/20/2022 00:43
*/

public class Solution {
    private List<int> nums=new List<int>();

    public void Inorder(TreeNode root){
        if(root == null) return;
        Inorder(root.left);
        nums.Add(root.val);
        Inorder(root.right);
    }
    
    public int KthSmallest(TreeNode root, int k) {
        inorder(root);
        return nums[k-1];
    }
}
