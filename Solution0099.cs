/*
May 31, 2023 23:08
Runtime 106 ms Beats 50.75%
Memory 46.5 MB Beats 68.66%
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
    private TreeNode firstElement = null;
    private TreeNode secondElement = null;
    private TreeNode prevElement = null;

    public void RecoverTree(TreeNode root)
    {
        if (root == null) return;

        // Inorder traversal to find the two elements
        Traverse(root);

        // Swap the values of the two nodes
        int temp = firstElement.val;
        firstElement.val = secondElement.val;
        secondElement.val = temp;

        return;
    }

    private void Traverse(TreeNode root)
    {
        if (root == null) return;

        Traverse(root.left);

        if (firstElement == null && (prevElement == null || prevElement.val >= root.val)) {
            // If first element has not been found, assign it to prevElement
            firstElement = prevElement;
        }
        if(firstElement!=null && (prevElement.val >= root.val)) { 
            // else, assign the second element to the root
            secondElement = root;
        }
        prevElement = root;

        Traverse(root.right);

    }
}
