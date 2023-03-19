/*
Mar 19, 2023 15:45
Runtime 386 ms, Beats 90.91%
Memory 64.9 MB, Beats 7.57%
*/

public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        List<int> smallArr = new List<int>();
        List<int> greatArr = new List<int>();
        foreach (var num in nums)
        {
            if (num < pivot)
                smallArr.Add(num);
            if (num > pivot)
                greatArr.Add(num);
        }
        for (int i = smallArr.Count + greatArr.Count; i < nums.Length; i++)
            smallArr.Add(pivot);

        smallArr.AddRange(greatArr);
        
        return smallArr.ToArray();
    }
}
