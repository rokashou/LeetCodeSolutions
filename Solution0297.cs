/*
May 31, 2023 22:20
Runtime 108 ms Beats 51.84%
Memory 47 MB Beats 44.8%
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        return serial(new StringBuilder(), root).ToString();
    }

    private StringBuilder serial(StringBuilder sb, TreeNode root)
    {
        if (root == null) return sb.Append("#");
        sb.Append(root.val).Append(",");
        serial(sb, root.left).Append(",");
        serial(sb, root.right);
        return sb;
    }


    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        return deserial(new LinkedList<string>(new List<string>(data.Split(","))));
    }

    private TreeNode deserial(LinkedList<string> q)
    {
        string val = q.First.Value;
        q.RemoveFirst();
        if ("#".Equals(val)) return null;
        TreeNode root = new TreeNode(int.Parse(val));
        root.left = deserial(q);
        root.right = deserial(q);
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
