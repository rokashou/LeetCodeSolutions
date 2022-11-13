/*
Runtime: 310 ms, faster than 91.67% of C# online submissions for Find The Original Array of Prefix Xor.
Memory Usage: 59.2 MB, less than 6.41% of C# online submissions for Find The Original Array of Prefix Xor.
Uploaded: 11/13/2022 10:39
*/


public class Solution {
    public int[] FindArray(int[] pref) {
        int[] result = new int[pref.Length];
        result[0] = pref[0];
        for(int i = 1; i < pref.Length; i++)
        {
            result[i] = pref[i] ^ pref[i-1];
        }
        return result;

    }
}
