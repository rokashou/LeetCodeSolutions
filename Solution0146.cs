/*
Jul 19, 2023 21:39
Runtime 813 ms Beats 67.83%
Memory 154 MB Beats 80.17%
*/

public class LRUCache {
    private Dictionary<int, LinkedListNode<(int key, int value)>> cache = new();
    private LinkedList<(int key, int value)> _val = new();

    private int capacity;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key)) return -1;

        var node = cache[key];
        _val.Remove(node);
        _val.AddFirst(node);
        return node.Value.value;

    }
    

    public void Put(int key, int value)
    {
        if(!cache.ContainsKey(key) && cache.Count >= capacity)
        {
            var node = _val.Last;
            cache.Remove(node.Value.key);
            _val.Remove(node);
        }

        var existingNode = cache.GetValueOrDefault(key);
        if(existingNode != null)
        {
            _val.Remove(existingNode);
        }

        _val.AddFirst((key, value));
        cache[key] = _val.First;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
