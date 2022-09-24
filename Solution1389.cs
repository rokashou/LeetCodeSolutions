/*
Runtime: 243 ms, faster than 23.94% of C# online submissions for Create Target Array in the Given Order.
Memory Usage: 41 MB, less than 24.65% of C# online submissions for Create Target Array in the Given Order.
Uploaded: 09/25/2022 00:07
*/

public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        List<int> result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            result.Insert(index[i], nums[i]);
        }

        return result.ToArray();
    }
}
