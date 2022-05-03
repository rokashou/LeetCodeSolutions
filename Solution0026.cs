/*
Runtime: 218 ms, faster than 34.25% of C# online submissions for Remove Duplicates from Sorted Array.
Memory Usage: 45 MB, less than 46.89% of C# online submissions for Remove Duplicates from Sorted Array.
Uploaded: 05/04/2022 01:10
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index1 = 0, index2 = 1;
        while (index2 < nums.Length)
        {
            if(nums[index1] == nums[index2])
            {
                index2++;
                continue;
            }
            if(index2-index1 > 1)
            {
                index1++;
                nums[index1] = nums[index2];
                index2++;
                continue;
            }
            index1++;index2++;
        }
        return index1 + 1;

    }
}
