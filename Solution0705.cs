/*
04/22/2022 00:03
Runtime: 368 ms, 36.33% better
Memory Usage: 64.2 MB, 21.35% better
*/

public class MyHashSet {
    private const int prime = 10007;
    private List<int>[] table;

    private int GetHashCode(int key)
    {
        return key % prime;
    }

    public MyHashSet()
    {
        table = new List<int>[prime];
    }

    public void Add(int key)
    {
        int idx = GetHashCode(key);
        if(table[idx] == null)
        {
            table[idx] = new List<int>();
        }
        if (!table[idx].Contains(key))
            table[idx].Add(key);
    }

    public void Remove(int key)
    {
        int idx = GetHashCode(key);
        if (table[idx] == null)
            return;
        table[idx].Remove(key);
    }

    public bool Contains(int key)
    {
        int idx = GetHashCode(key);
        if (table[idx] == null) return false;
        return table[idx].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
