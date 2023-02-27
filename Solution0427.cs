/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid)
    {
        int totalHeight = grid.Length-1;
        int totalWidth = grid[0].Length-1;

        Node root = CreateChild(grid, 0, totalWidth, 0, totalHeight);

        return root;
    }

    public Node CreateChild(int[][] grid, int xbegin, int xend, int ybegin, int yend)
    {
        Node nd = new Node();
        if (xbegin == xend && ybegin == yend)
        {
            nd.val = (grid[ybegin][xbegin] == 1);
            nd.isLeaf = true;
            return nd;
        }

        int midWidth = xbegin + (xend - xbegin)/ 2;
        int midHeight = ybegin + (yend - ybegin) / 2;

        nd.topLeft = CreateChild(grid, xbegin, midWidth, ybegin, midHeight);
        nd.topRight = CreateChild(grid, midWidth + 1, xend, ybegin, midHeight);
        nd.bottomLeft = CreateChild(grid, xbegin, midWidth, midHeight + 1, yend);
        nd.bottomRight = CreateChild(grid, midWidth + 1, xend, midHeight + 1, yend);

        int check = (nd.topLeft.val ? 1 : 0) + (nd.topRight.val ? 1 : 0) + (nd.bottomLeft.val ? 1 : 0) + (nd.bottomRight.val ? 1 : 0);

        nd.isLeaf = nd.topLeft.isLeaf && nd.topRight.isLeaf && nd.bottomLeft.isLeaf && nd.bottomRight.isLeaf && (check == 4 || check == 0);

        if (nd.isLeaf)
        {
            nd.val = nd.topLeft.val;
            nd.topLeft = null;
            nd.topRight = null;
            nd.bottomLeft = null;
            nd.bottomRight = null;
        }
        else
        {
            nd.val = true;
        }

        return nd;
    }
}
