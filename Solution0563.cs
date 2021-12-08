/*
Uploaded: 12/08/2021 22:07
Runtime: 92 ms, faster than 93.15% of C# online submissions for Binary Tree Tilt.
Memory Usage: 41.2 MB, less than 24.66% of C# online submissions for Binary Tree Tilt.

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
    public int FindTilt(TreeNode root) {
        FindSum(root,out int sum, out int tilt);

        return tilt;
    }

    void FindSum(TreeNode root, out int sum, out int tilt){
        if(root==null){sum=0;tilt=0;return;}
        int leftSum = 0;
        int leftTilt = 0;
        if(root.left!=null){
            FindSum(root.left,out leftSum,out leftTilt);                
        }
        int rightSum = 0;
        int rightTilt = 0;
        if(root.right != null){
            FindSum(root.right, out rightSum, out rightTilt);
        }
        sum = root.val + leftSum + rightSum;
        tilt = Math.Abs(leftSum-rightSum) + leftTilt + rightTilt;
    }    
}
