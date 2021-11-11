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
    /*
    Uploaded: 10/19/2021 00:43
    Runtime: 154 ms, 27.23% better
    Memory Usage: 38 MB, 80.91% better
    */
    

    public bool IsCousins(TreeNode root, int x, int y) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            int n=queue.Count;
            bool f1=false,f2=false;

            for(int i=0;i<n;i++){
                var temp = queue.Peek();
                queue.Dequeue();

                // check values found
                if(temp.val == x) f1=true;
                if(temp.val == y) f2=true;

                // check same parent
                if(temp.left != null && temp.right != null){
                    if((temp.left.val==x && temp.right.val==y) || (temp.left.val == y && temp.right.val==x))
                        return false;
                }

                if(temp.left!=null) queue.Enqueue(temp.left);
                if(temp.right!=null) queue.Enqueue(temp.right);

            }

            if(f1 && f2) return true;
            else if(f1 || f2) return false;
        }

        return false;
    }
}
