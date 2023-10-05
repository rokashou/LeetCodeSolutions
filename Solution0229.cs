/*
Oct 05, 2023 23:45
Runtime 130 ms Beats 94.44%
Memory 46.2 MB Beats 82.48%
*/


public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int num1 = int.MinValue;
        int num2 = int.MinValue;
        int count1 = 0, count2 = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (num1 == nums[i])
                count1++;
            else if (num2 == nums[i])
                count2++;
            else if(count1 == 0)
            {
                num1 = nums[i];
                count1 = 1;
            }
            else if(count2 == 0)
            {
                num2 = nums[i];
                count2 = 1;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        var output = new List<int>();
        int countMajority = nums.Length / 3;
        count1 = 0; count2 = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (num1 == nums[i])
                count1++;

            if (num2 == nums[i])
                count2++;
        }
        if (count1 > countMajority)
            output.Add(num1);
        if (count2 > countMajority)
            output.Add(num2);
        return output;        
    }
}
