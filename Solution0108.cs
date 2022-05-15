/*
Runtime: 85 ms, faster than 86.36% of C# online submissions for Convert Sorted Array to Binary Search Tree.
Memory Usage: 39.9 MB, less than 5.55% of C# online submissions for Convert Sorted Array to Binary Search Tree.
Uploaded: 05/15/2022 10:20
*/

public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0) return null;
        if (nums.Length == 1) return new TreeNode(nums[0]);

        int mid = nums.Length / 2;
        TreeNode result = new TreeNode(nums[mid]);
        TreeNode left = SortedArrayToBST(nums[0..mid]);
        TreeNode right = SortedArrayToBST(nums[(mid + 1)..^0]);
        result.left = left;
        result.right = right;

        return result;
    }
}
