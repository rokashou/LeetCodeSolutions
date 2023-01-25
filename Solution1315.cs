/*
Runtime 144 ms, Beats 49.2%
Memory 43.5 MB, Beats 100%
Accepted: Jan 25, 2023 22:12
*/


public class Solution {
    public int SumEvenGrandparent(TreeNode root) {
        var st = new Queue<TreeNode>();
        var vals = new Dictionary<TreeNode, TreeNode>(); // store the parent of each node as (node, parent)
        int sum = 0;

        st.Enqueue(root);

        while (st.Count > 0)
        {
            var node = st.Dequeue();
            // set node as parent, and try to find the grandparent
            TreeNode gp = vals.ContainsKey(node) ? vals[node]:null;

            // check if the grantparent value is even 
            bool gpFlag = (gp != null && gp.val % 2 == 0);

            if (node.left != null)
            {
                vals.Add(node.left, node);
                st.Enqueue(node.left);

                // Sum up the children vals if the check is passed
                if (gpFlag) sum += node.left.val;
            }
            if (node.right != null)
            {
                vals.Add(node.right, node);
                st.Enqueue(node.right);

                // Sum up the children vals if the check is passed
                if (gpFlag) sum += node.right.val;
            }
        }

        return sum;
    }
}
