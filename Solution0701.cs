/*
Runtime: 128 ms, faster than 38.15% of C# online submissions for Insert into a Binary Search Tree.
Memory Usage: 44.4 MB, less than 6.07% of C# online submissions for Insert into a Binary Search Tree.
Uploaded: 01/12/2022 23:18

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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        TreeNode vn = new TreeNode(val);
        if(root == null) {
            return vn;
        }

        TreeNode tmp = root;

        while(tmp != null){
            if(tmp.val > val && tmp.left != null){
                tmp = tmp.left;
                continue;
            }
            if(tmp.val > val && tmp.left == null){
                tmp.left = vn;
                break;
            }
            if(tmp.val < val && tmp.right != null){
                tmp = tmp.right;
                continue;
            }
            if(tmp.val < val && tmp.right == null){
                tmp.right = vn;
                break;
            }

        }

        return root;
    }
}
