/*
05/26/2022 19:53	
104 ms,	40.6 MB	
*/

public class Solution {
    public bool CheckTree(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            var tmp = queue.Dequeue();
            int sum = 0;
            if (tmp == null ||( tmp.left == null && tmp.right == null)) continue;
            if(tmp.left != null)
            {
                queue.Enqueue(tmp.left);
                sum += tmp.left.val;
            }
            if(tmp.right != null)
            {
                queue.Enqueue(tmp.right);
                sum += tmp.right.val;
            }
            if(tmp.val != sum)
            {
                return false;
            }
        }
        return true;
    }
}
