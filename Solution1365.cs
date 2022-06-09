/*
Runtime: 157 ms, faster than 88.78% of C# online submissions for How Many Numbers Are Smaller Than the Current Number.
Memory Usage: 44.2 MB, less than 6.12% of C# online submissions for How Many Numbers Are Smaller Than the Current Number.
Uploaded: 06/09/2022 22:01
*/



public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        SortedList<int, List<int>> countTable = new SortedList<int, List<int>>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (!countTable.ContainsKey(nums[i]))
            {
                countTable.Add(nums[i], new List<int>());
            }
            countTable[nums[i]].Add(i);
        }
        int[] result = new int[nums.Length];
        int k = 0;
        foreach (var i in countTable.Keys)
        {
            foreach (var idx in countTable[i])
            {
                result[idx] = k;
            }
            k += countTable[i].Count;
        }
        return result;
    }
}
