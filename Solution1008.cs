/*
Uploaded: 10/13/2021 21:58
Runtime: 80 ms, 94.40%
Memory Usage: 36.3 MB, 66.72%
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
    public TreeNode BstFromPreorder(int[] preorder) {
        int length = preorder.Length;
        TreeNode root = new TreeNode(preorder[0]);
        TreeNode tn = root;
        int idx=1;
        while(idx<length){
            while(preorder[idx] < tn.val && tn.left != null){
                tn = tn.left;
            }
            if(preorder[idx] < tn.val && tn.left==null){
                tn.left = new TreeNode(preorder[idx]);
            }
            while(preorder[idx] > tn.val && tn.right != null){
                tn = tn.right;
            }
            if(preorder[idx] > tn.val && tn.right == null){
                tn.right = new TreeNode(preorder[idx]);
            }
            if(tn.val == preorder[idx]){
                idx++;
                tn = root;
            }
        }
        return root;
        
    }
}
