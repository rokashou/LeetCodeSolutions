/*
Runtime: 108 ms, faster than 85.36% of C# online submissions for Search in a Binary Search Tree.
Memory Usage: 43.5 MB, less than 20.30% of C# online submissions for Search in a Binary Search Tree.
Uploaded: 01/12/2022 23:27
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
    public TreeNode SearchBST(TreeNode root, int val) {
        var tmp = root;
        while(tmp != null){
            if(tmp.val == val) return tmp;
            if(tmp.val > val) {
                tmp = tmp.left;
                continue;
            }
            if(tmp.val < val) {
                tmp = tmp.right;
            }
        }
        return null;
    }
}

