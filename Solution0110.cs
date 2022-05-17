/*
Runtime: 152 ms, faster than 31.56% of C# online submissions for Balanced Binary Tree.
Memory Usage: 41.2 MB, less than 67.47% of C# online submissions for Balanced Binary Tree.
Uploaded: 05/18/2022 01:03
*/

public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        int left = GetHeight(root.left);
        int right = GetHeight(root.right);
        return (Math.Abs(left - right) <= 1) && IsBalanced(root.left) && IsBalanced(root.right);
           
    }
    
    private int GetHeight(TreeNode root)
    {
        if(root == null) return 0;
        int left = GetHeight(root.left);
        int right = GetHeight(root.right);
        return Math.Max(left,right)+1;
    }
}






/*
Runtime: 165 ms, faster than 21.04% of C# online submissions for Balanced Binary Tree.
Memory Usage: 40.9 MB, less than 96.01% of C# online submissions for Balanced Binary Tree.
Uploaded: 05/18/2022 01:01
*/



public class Solution {
    private Dictionary<TreeNode, int> nodeMap = new Dictionary<TreeNode, int>();
    
    public bool IsBalanced(TreeNode root) {
        
        if (root == null)
            return true;
        
        int leftHeight = GetTreeHeight(root.left);
        int rightHeight = GetTreeHeight(root.right);
        
        if (Math.Abs(leftHeight - rightHeight) > 1)
            return false;
        else {
            return IsBalanced(root.left) && IsBalanced(root.right);            
        }
                    
    }
    
    private int GetTreeHeight(TreeNode node) {
        if (node == null) {
            return 0;
        }
        
        if (nodeMap.ContainsKey(node)) {
            return nodeMap[node];
        } else {
            int height = Math.Max(GetTreeHeight(node.left), 
                        GetTreeHeight(node.right)) + 1;
            nodeMap[node] = height;
            return height;
        }
    }
}






/*
Runtime: 206 ms, faster than 5.20% of C# online submissions for Balanced Binary Tree.
Memory Usage: 41.1 MB, less than 86.82% of C# online submissions for Balanced Binary Tree.
Uploaded: 05/18/2022 00:57
*/

public class Solution {
    private int TreeHeight(TreeNode node)
    {
        if (node == null) return 0;

        int leftHeight = TreeHeight(node.left);
        if (leftHeight == -1) return -1;
        int rightHeight = TreeHeight(node.right);
        if (rightHeight == -1) return -1;

        if (Math.Abs(leftHeight - rightHeight) > 1) return -1;
        return Math.Max(leftHeight, rightHeight) + 1;
    }

    public bool IsBalanced(TreeNode root)
    {
        return TreeHeight(root) != -1;
    }
}
