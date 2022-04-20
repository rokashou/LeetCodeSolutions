/*
Runtime: 270 ms, faster than 12.36% of C# online submissions for Binary Search Tree Iterator.
Memory Usage: 49.9 MB, less than 66.36% of C# online submissions for Binary Search Tree Iterator.
Uploaded: 04/20/2022 22:54
*/

public class BSTIterator {

    public Queue<TreeNode> backet;

    public BSTIterator(TreeNode root)
    {
        backet = new Queue<TreeNode>();

        Inorder(root);
    }

    public void Inorder(TreeNode node)
    {
        if(node.left != null)
        {
            Inorder(node.left);
        }
        backet.Enqueue(node);
        if (node.right != null)
        {
            Inorder(node.right);
        }
    }

    public int Next()
    {
        if(backet.Count > 0)
        {
            var tmp = backet.Dequeue();
            return tmp.val;
        }
        return -1;
    }

    public bool HasNext()
    {
        return (backet.Count > 0);
    }
}
