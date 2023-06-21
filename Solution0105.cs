/*
Jun 21, 2023 22:22
Runtime 100 ms Beats 50.26%
Memory 40.9 MB Beats 69.90%

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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
    // 使用遞迴函式來構建二叉樹
    return BuildTreeHelper(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildTreeHelper(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd) {
        if (preStart > preEnd || inStart > inEnd) {
            // 遞迴的終止條件，當遍歷範圍無效時返回 null
            return null;
        }
        
        // 前序遍歷的第一個元素為當前子樹的根節點
        int rootVal = preorder[preStart];
        TreeNode root = new TreeNode(rootVal);
        
        // 在中序遍歷中找到根節點的位置，用於劃分左子樹和右子樹
        int rootIndexInorder = Array.IndexOf(inorder, rootVal);
        
        // 計算左子樹的節點數量
        int leftNodes = rootIndexInorder - inStart;
        
        // 遞迴構建左子樹，左子樹的前序遍歷範圍為 preStart + 1 到 preStart + leftNodes
        // 中序遍歷範圍為 inStart 到 rootIndexInorder - 1
        root.left = BuildTreeHelper(preorder, preStart + 1, preStart + leftNodes, inorder, inStart, rootIndexInorder - 1);
        
        // 遞迴構建右子樹，右子樹的前序遍歷範圍為 preStart + leftNodes + 1 到 preEnd
        // 中序遍歷範圍為 rootIndexInorder + 1 到 inEnd
        root.right = BuildTreeHelper(preorder, preStart + leftNodes + 1, preEnd, inorder, rootIndexInorder + 1, inEnd);
        
        return root;
    }
}
