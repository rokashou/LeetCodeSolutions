/*
Runtime: 175 ms, faster than 97.50% of C# online submissions for Decode XORed Array.
Memory Usage: 59.9 MB, less than 5.00% of C# online submissions for Decode XORed Array.
Uploaded: 07/11/2022 21:35
*/


public class Solution {
    public int[] Decode(int[] encoded, int first) {
        List<int> list = new List<int>();
        list.Add(first);
        int next = first;
        for(int i = 0; i < encoded.Length; i++)
        {
            next = encoded[i] ^ next;
            list.Add(next);
        }
        return list.ToArray();
    }
}
