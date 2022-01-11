/*
Approach 1: Iterative Preorder Traversal.
Runtime: 157 ms, faster than 5.41% of C# online submissions for Sum of Root To Leaf Binary Numbers.
Memory Usage: 36.5 MB, less than 76.58% of C# online submissions for Sum of Root To Leaf Binary Numbers.
Uploaded: 01/12/2022 00:13
*/

public class Solution_Approach01 {
    public int SumRootToLeaf(TreeNode root) {
        // Approach 1
        int rootToLeaf = 0, currNumber = 0;
        Stack<KeyValuePair<TreeNode, int>> stack = new Stack<KeyValuePair<TreeNode, int>>();
        stack.Push(new KeyValuePair<TreeNode, int>(root, 0));

        while(stack.Count>0){
            var p = stack.Pop();
            root = p.Key;
            currNumber = p.Value;

            if(root != null){
                currNumber = (currNumber << 1) | root.val;
                // if it is a leaf, update root-to-leaf sum
                if(root.left == null && root.right==null){
                    rootToLeaf += currNumber;
                }else{
                    stack.Push(new KeyValuePair<TreeNode, int>(root.right, currNumber));
                    stack.Push(new KeyValuePair<TreeNode, int>(root.left, currNumber));
                }
            }
        }

        return rootToLeaf;
    }
}

/*
Approach 02: Recursive Preorder Traversal.
Runtime: 100 ms, faster than 27.93% of C# online submissions for Sum of Root To Leaf Binary Numbers.
Memory Usage: 36.8 MB, less than 72.07% of C# online submissions for Sum of Root To Leaf Binary Numbers.
Uploaded: 01/12/2022 00:23
*/

public class Solution_Approach02 {
    int rootToLeaf = 0;

    public void PreOrder(TreeNode r, int currNumber)
    {
        if (r != null)
        {
            currNumber = (currNumber << 1) | r.val;
            // if it is a leaf, update root-to-leaf sum
            if (r.left == null && r.right == null)
            {
                rootToLeaf += currNumber;
            }
            PreOrder(r.left, currNumber);
            PreOrder(r.right, currNumber);
        }
    }

    public int SumRootToLeaf(TreeNode root){
        PreOrder(root, 0);
        return rootToLeaf;
    }

}

/*
Approach 03: Morris Preorder Traversal.
Runtime: 88 ms, faster than 60.36% of C# online submissions for Sum of Root To Leaf Binary Numbers.
Memory Usage: 38.2 MB, less than 37.84% of C# online submissions for Sum of Root To Leaf Binary Numbers.
Uploaded: 01/12/2022 00:39	
*/

public class Solution_Approach03 {
    public int SumRootToLeaf(TreeNode root) {
        int rootToLeaf = 0, currNumber = 0;
        int steps;
        TreeNode predecessor;

        while(root!=null){
            // if there is a left child,
            // then compute the predecessor.
            // if there is no link predecessor.right = root --> set it.
            // if there is a link predecessor.right = root --> break it.
            if (root.left != null)
            {
                // Predecessor node is one stemp to the left
                // and then to the right till you can.
                predecessor = root.left;
                steps = 1;
                while (predecessor.right != null && predecessor.right != root)
                {
                    predecessor = predecessor.right;
                    ++steps;
                }

                // Set link predecessor.right = root
                // and go to explore the left subtree
                if(predecessor.right == null){
                    currNumber = (currNumber << 1) | root.val;
                    predecessor.right = root;
                    root = root.left;
                }

                // break the link predecessor.right = root
                // once the link is broken, 
                // it's time to change subtree and go to the right 
                else{
                    // if you're on the leaf,, update the sum
                    if(predecessor.left == null){
                        rootToLeaf += currNumber;
                    }
                    // this part of tree is explored, backtrack
                    for (int i = 0; i < steps;++i){
                        currNumber >>= 1;
                    }
                    predecessor.right = null;
                    root = root.right;
                }
            }
            // if there is no left child
            // then just go right
            else{
                currNumber = (currNumber << 1) | root.val;
                // if you're on the leaf, update the sum
                if(root.right == null){
                    rootToLeaf += currNumber;
                }
                root = root.right;
            }
        }
        return rootToLeaf;
    }
}


