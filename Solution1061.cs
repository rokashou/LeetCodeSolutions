/*
Runtime: 85 ms, Beats 100%
Memory 41.5 MB, Beats 50%
Uploaded: Jan 14, 2023 23:13
*/

public class Solution {
    // By DSU aka Disjoint Set Union

    int[] representative = new int[26];

    // Returns the root representative of the component.
    int find(int x)
    {
        if (representative[x] == x) return x;
        return representative[x] = find(representative[x]);
    }

    // Perform union if x and y are not in the same component.
    void performUnion(int x, int y)
    {
        x = find(x);
        y = find(y);
        if (x == y) return;

        if (x < y)
            representative[y] = x;
        else
            representative[x] = y;

    }
    

    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        // initialize the representative array
        for(int i = 0; i < 26; i++) { representative[i] = i; }

        // Perform union merge for all the edges.
        for(int i = 0; i < s1.Length; i++)
        {
            performUnion(s1[i] - 'a', s2[i] - 'a');
        }

        string ans = string.Empty;
        // Create the answer string with final mappings.
        foreach(var c in baseStr)
        {
            ans += (char)('a' + find(c - 'a'));
        }

        return ans;
    }
}
