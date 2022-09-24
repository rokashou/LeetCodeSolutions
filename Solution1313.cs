/*
Runtime: 159 ms, faster than 87.37% of C# online submissions for Decompress Run-Length Encoded List.
Memory Usage: 45.4 MB, less than 81.05% of C# online submissions for Decompress Run-Length Encoded List.
Uploaded: 09/24/2022 23:55
*/


public class Solution {
    public int[] DecompressRLElist(int[] nums)
    {
        List<int> result = new List<int>();
        for(int i = 0; i < nums.Length; i += 2)
        {
            result.AddRange(CreateNumsList(nums[i], nums[i + 1]));
        }
        return result.ToArray();
    }

    public int[] CreateNumsList(int freq, int val)
    {
        int[] result = new int[freq];
        Array.Fill(result, val);
        return result;
    }
}
