/*
Mar 11, 2023 11:14
Runtime 79 ms, Beats 100%
Memory 41.9 MB, Beats 17.65%
*/


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
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
    public TreeNode SortedListToBST(ListNode head)
    {
        List<int> lst = new List<int>();
        var ln = head;
        while (ln != null)
        {
            lst.Add(ln.val);
            ln = ln.next;
        }
        
        if(lst.Count == 0)
            return null;

        TreeNode tn = GetSubTreeNode(lst,0,lst.Count-1);
        return tn;
    }

    private TreeNode GetSubTreeNode(List<int> list, int leftBound, int rightBound)
    {
        int m = leftBound + (rightBound - leftBound) / 2;
        TreeNode node = new TreeNode(list[m]);
        if (leftBound < rightBound)
        {
            if(m > leftBound)
                node.left = GetSubTreeNode(list, leftBound, m - 1);
            if(m < rightBound)
                node.right = GetSubTreeNode(list, m + 1, rightBound);
        }
        return node;
    }
}
