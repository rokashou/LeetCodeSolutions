/*
Runtime: 103 ms, faster than 90.91% of C# online submissions for Satisfiability of Equality Equations.
Memory Usage: 41 MB, less than 9.09% of C# online submissions for Satisfiability of Equality Equations.
Uploaded: 09/26/2022 23:05
*/


public class Solution {
    int[] parent = new int[26];


    /** find the root of node x.
     * here we are not using parent[x], because it may not contain the updated
     * value of the connected component that x belongs to.
     * therefore, we walk the ancestors of the vertex until we reach the root.
     */
    public int find(int x)
    {
        return parent[x] == x ? x : find(parent[x]);
    }

    /** the idea is to put all characters in the same group if they are equal.
     * In order to do that, we can use Disjoint Set Union (dsu) aka Union Find
     */
    public bool EquationsPossible(string[] equations)
    {
        int n = equations.Length;

        // init the parent, set parent to itself
        /* at the beginning, put each character index in its own group so we 
         * will have 26 groups with one character each i.e. 'a' in group 0,
         * 'b' in group 1, ..., 'z' in group 25
         */
        for (int i = 0; i < 26; i++) parent[i] = i;

        foreach(var equ in equations)
        {
            // check the equal situation, and build the union
            if (equ[1] == '=')
            {
                // e.g. a==b
                // Then we group them together.
                // How? We use `find` function to find out the parent group of
                // the target character index then update parent. a & b would
                // be in group 1 (i.e. a merged into the group where b belongs
                // to) or you can also do
                //     `parent[find(e[3]-'a'] = find(e[0]-'a');`
                // (i.e. b merged into the group where a belongs to)
                parent[find(equ[0] - 'a')] = find(equ[3] - 'a');
            }
        }

        // handle != case
        // check if v1 and v2 are in the same union.
        foreach(var equ in equations)
        {
            if (equ[1] == '!' && find(equ[0] - 'a') == find(equ[3] - 'a'))
            {
                return false;
            }
        }

        return true;
    }
}
