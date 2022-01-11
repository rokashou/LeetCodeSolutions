# Solution

## Overview

### Prerequisites: Bitwise Trick

If you work with decimal representation, the conversion of `1->2` into `12` is easy. You start from `curr_number = 1`, then shift one register to the left and add the next digit: `curr_number = 1 * 10 + 2 = 12`.

If you work with binaries `1 -> 1` -> `3`, it's the same. You start from `curr_number = 1`, then shift one register to the left and add the next digit: `curr_number = (1 << 1) | 1 = 3`.

### Prerequisites: Tree Traversals

There are three DFS ways to traverse the tree: preorder, postorder and inorder. Please check two minutes picture explanation, if you don't remember them quite well: [here is Python version](https://leetcode.com/problems/binary-tree-inorder-traversal/discuss/283746/all-dfs-traversals-preorder-inorder-postorder-in-python-in-1-line) and [here is Java version](https://leetcode.com/problems/binary-tree-inorder-traversal/discuss/328601/all-dfs-traversals-preorder-postorder-inorder-in-java-in-5-lines).

### Optimal Strategy to Solve the Problem

> Root-to-left traversal is so-called *DFS preorder traversal*. To implement it, one has to follow straightforward strategy Root->Left->Right.

Since one has to visit all nodes, the best possible time complexity here is linear. Hence all interest here is to improve the space complexity.

> There are 3 ways to implement preorder traversal: iterative, recursive and Morris.

Iterative and recursive approaches here do the job in one pass, but they both need up to $\mathcal{O}(H)$ space to keep the stack, where $H$ is a tree height.

Morris approach is two-pass approach, but it's a constant-space one.

![preorder2](https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/Figures/1022/preorder2.png)

---

## Approach 1: Iterative Preorder Traversal.

### Intuition

Here we implement standard iterative preorder traversal with the stack:

- Push root into stack.

- While stack is not empty:

    - Pop out a node from stack and update the current number.

    - If the node is a leaf, update root-to-leaf sum.

    - Push right and left child nodes into stack.

- Return root-to-leaf sum.

Note, that [Javadocs recommends to use ArrayDeque, and not Stack as a stack implementation](https://docs.oracle.com/javase/8/docs/api/java/util/ArrayDeque.html).

```Java
class Solution {
    public int sumRootToLeaf(TreeNode root) {
        int rootToLeaf = 0, currNumber = 0;
        Deque<Pair<TreeNode, Integer>> stack = new ArrayDeque();
        stack.push(new Pair(root, 0));

        while (!stack.isEmpty()) {
          Pair<TreeNode, Integer> p = stack.pop();
          root = p.getKey();
          currNumber = p.getValue();

          if (root != null) {
            currNumber = (currNumber << 1) | root.val;
            // if it's a leaf, update root-to-leaf sum
            if (root.left == null && root.right == null) {
              rootToLeaf += currNumber;
            } else {
              stack.push(new Pair(root.right, currNumber));
              stack.push(new Pair(root.left, currNumber));
            }
          }
        }
        return rootToLeaf;
    }
}
```

### Complexity Analysis

- Time complexity: $\mathcal{O}(N)$, where $N$ is a number of nodes, since one has to visit each node.

- Space complexity: up to $\mathcal{O}(H)$ to keep the stack, where $H$ is a tree height.

---

## Approach 2: Recursive Preorder Traversal.
Iterative approach 1 could be converted into recursive one.

Recursive preorder traversal is extremely simple: follow Root->Left->Right direction, i.e. do all the business with the node (= update the current number and root-to-leaf sum), and then do the recursive calls for the left and right child nodes.

P.S. Here is the difference between preorder and the other DFS recursive traversals. On the following figure the nodes are enumerated in the order you visit them, please follow `1-2-3-4-5` to compare different DFS strategies implemented as recursion.

![ddfs2](https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/Figures/1022/ddfs2.png)

### Implementation

```Java
class Solution {
    int rootToLeaf = 0;
    
    public void preorder(TreeNode r, int currNumber) {
        if (r != null) {
            currNumber = (currNumber << 1) | r.val;
            // if it's a leaf, update root-to-leaf sum
            if (r.left == null && r.right == null) {
            rootToLeaf += currNumber;
            }
            preorder(r.left, currNumber);
            preorder(r.right, currNumber);
        }
    }

    public int sumRootToLeaf(TreeNode root) {
        preorder(root, 0);
        return rootToLeaf;
    }
}
```

### Complexity Analysis

- Time complexity: $\mathcal{O}(N)$, where $N$ is a number of nodes, since one has to visit each node.

- Space complexity: up to $\mathcal{O}(H)$ to keep the recursion stack, where $H$ is a tree height.

---

## Approach 3: Morris Preorder Traversal.
We discussed already iterative and recursive preorder traversals, which both have great time complexity though use up to $\mathcal{O}(H)$ to keep the stack. We could trade in performance to save space.

The idea of Morris preorder traversal is simple: to use no space but to traverse the tree.

> How that could be even possible? At each node one has to decide where to go: to the left or to the right, traverse the left subtree or traverse the right subtree. How one could know that the left subtree is already done if no additional memory is allowed?

The idea of [Morris](https://www.sciencedirect.com/science/article/pii/0020019079900681) algorithm is to set the *temporary link* between the node and its [predecessor](https://leetcode.com/articles/delete-node-in-a-bst/): `predecessor.right = root`. So one starts from the node, computes its predecessor and verifies if the link is present.

- There is no link? Set it and go to the left subtree.

- There is a link? Break it and go to the right subtree.

There is one small issue to deal with : what if there is no left child, i.e. there is no left subtree? Then go straightforward to the right subtree.

### Implementation

```Java
class Solution {
    public int sumRootToLeaf(TreeNode root) {
        int rootToLeaf = 0, currNumber = 0;
        int steps;
        TreeNode predecessor;

        while (root != null) {
            // If there is a left child,
            // then compute the predecessor.
            // If there is no link predecessor.right = root --> set it.
            // If there is a link predecessor.right = root --> break it.
            if (root.left != null) {
                // Predecessor node is one step to the left
                // and then to the right till you can.
                predecessor = root.left;
                steps = 1;
                while (predecessor.right != null && predecessor.right != root) {
                    predecessor = predecessor.right;
                    ++steps;
                }

                // Set link predecessor.right = root
                // and go to explore the left subtree
                if (predecessor.right == null) {
                    currNumber = (currNumber << 1) | root.val;
                    predecessor.right = root;
                    root = root.left;
                }
                // Break the link predecessor.right = root
                // Once the link is broken,
                // it's time to change subtree and go to the right
                else {
                    // If you're on the leaf, update the sum
                    if (predecessor.left == null) {
                        rootToLeaf += currNumber;
                    }
                    // This part of tree is explored, backtrack
                    for(int i = 0; i < steps; ++i) {
                        currNumber >>= 1;
                    }
                    predecessor.right = null;
                    root = root.right;
                }
            }
            // If there is no left child
            // then just go right.
            else {
                currNumber = (currNumber << 1) | root.val;
                // if you're on the leaf, update the sum
                if (root.right == null) {
                    rootToLeaf += currNumber;
                }
                root = root.right;
            }
        }
        return rootToLeaf;
    }
}
```

### Complexity Analysis

- Time complexity: $\mathcal{O}(N)$, where $N$ is a number of nodes.

- Space complexity: $\mathcal{O}(1)$.

