/*
May 04, 2024 23:44
Runtime 55 ms Beats 92.83% of users with C#
Memory 44.68 MB Beats 43.02% of users with C#
*/


public class Solution {

    public long WonderfulSubstrings(string word)
    {
        long N = word.Length;
        long mask = 0, result = 0;

        // Create the frequency map
        // Key = bitmask, Value = frequency of bitmask key
        var count = new long[1024];

        // The empty prefix can be the smaller prefix, which is handled like this
        count[0] = 1;

        for(int i =0;i<N;i++){
            char c = word[i];
            // Flip the parity of the c-th bit in the running prefix mask
            mask ^= 1 << (c - 'a');

            // Count smaller prefixes that create substrings with no odd occurring letters
            result += count[mask]++;

            // Loop through every possible letter that can appear an odd number of times in a substring
            for(long odd_c=0;odd_c < 10;odd_c++){
                result += count[mask ^ (1 << (int)odd_c)];
            }
        }
        return result;
    }
}
