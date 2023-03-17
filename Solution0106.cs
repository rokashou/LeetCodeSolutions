/*
Mar 17, 2023 22:45
Runtime 92 ms, Beats 69.44%
Memory 40.1 MB, Beats 84.72%

Inorder: leftSubTree, root, rightSubTree
Postorder: leftSubTree, rightSubTree, root
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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        return BuildTreeHelper(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
    }

    private TreeNode BuildTreeHelper(int[] inorder, int inStart, int inEnd, int[] postorder, int postStart, int postEnd)
    {
        // Base Case
        if(inStart > inEnd || postStart > postEnd)
            return null;

        // Find the root node from the last element of postorder travelsal
        int rootVal = postorder[postEnd];
        TreeNode root = new TreeNode(rootVal);

        // Find the index of the root node in inorder traversal
        int rootIndex = inStart;
        for (; rootIndex <= inEnd; rootIndex++)
        {
            if (inorder[rootIndex] == rootVal) break;
        }

        // Recursively build the left and right subtrees
        int leftSize = rootIndex - inStart;
        int rightSize = inEnd - rootIndex;
        root.left = BuildTreeHelper(inorder, inStart, rootIndex - 1, postorder, postStart, postStart + leftSize - 1);
        root.right = BuildTreeHelper(inorder, rootIndex + 1, inEnd, postorder, postEnd - rightSize, postEnd - 1);

        return root;

    }
}
