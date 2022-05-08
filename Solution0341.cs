/*
Runtime: 131 ms, faster than 92.27% of C# online submissions for Flatten Nested List Iterator.
Memory Usage: 45.3 MB, less than 5.00% of C# online submissions for Flatten Nested List Iterator.
Uploaded: 05/08/2022 20:40
*/


/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {

    private Queue<int> FlatedList;
    private List<int> GetChild(NestedInteger node)
    {
        List<int> result = new List<int>();
        if (node.IsInteger())
        {
            result.Add(node.GetInteger());
        }
        else
        {
            foreach(var child in node.GetList())
            {
                result.AddRange(GetChild(child));
            }
        }
        return result;
    }

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        FlatedList = new Queue<int>();
        foreach(var node in nestedList)
        {
            var childList = GetChild(node);
            foreach(var child in childList)
            {
                FlatedList.Enqueue(child);
            }
        }
    }

    public bool HasNext()
    {
        return FlatedList.Count > 0;
    }

    public int Next()
    {
        return FlatedList.Dequeue();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
 
