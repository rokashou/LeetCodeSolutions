/*
Offical Solution with Greedy
Apr 04, 2023 23:05
Runtime 69 ms, Beats 97.56%
Memory 42.2 MB, Beats 87.80%
*/

public class Solution {
    public int PartitionString(string s) {
        int[] lastSeen = new int[26];
        Array.Fill(lastSeen, -1);
        int count = 1, substringStart = 0;
        for(int i = 0; i < s.Length; i++) {
            if (lastSeen[s[i] - 'a'] >= substringStart)
            {
                count++;
                substringStart = i;
            }
            lastSeen[s[i] - 'a'] = i;
        }

        return count;
        
    }
}
