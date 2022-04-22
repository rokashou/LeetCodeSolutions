/*
Runtime: 370 ms, faster than 55.24% of C# online submissions for Design HashMap.
Memory Usage: 52.3 MB, less than 46.85% of C# online submissions for Design HashMap.
Uploaded: 04/22/2022 23:18
*/

public class MyHashMap {
    private const int buckets = 10007;
    private int hash(int key) => (key % buckets);

    private Dictionary<int,int>[] table;


    public MyHashMap()
    {
        table = new Dictionary<int, int>[buckets];
    }

    public void Put(int key, int value)
    {

        int hashCode = key % buckets;
        if(table[hashCode] == null)
        {
            table[hashCode] = new Dictionary<int, int>();
        }
        if (table[hashCode].ContainsKey(key))
        {
            table[hashCode][key] = value;
        }
        else
        {
            table[hashCode].Add(key, value);
        }


    }

    public int Get(int key)
    {
        int hashCode = key % buckets;
        if(table[hashCode] == null || table[hashCode].Count == 0)
        {
            return -1;
        }
        if (table[hashCode].ContainsKey(key)) return table[hashCode][key];
        return -1;
    }

    public void Remove(int key)
    {
        int hashCode = key % buckets;
        if(table[hashCode] == null || table[hashCode].Count == 0)
        {
            return;
        }
        table[hashCode].Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
 
