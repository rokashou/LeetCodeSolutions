/*
try 2

May 01, 2023 20:38
Runtime 129 ms Beats 97.66%
Memory 44.7 MB Beats 5.85%
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int p1 = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(p1-2 < 0)
            {
                nums[p1] = nums[i];
                p1++;
                continue;
            }

            nums[p1] = nums[i];
            if (nums[p1 - 2] != nums[i])
            {
                p1++;
            }
        }

        return p1;
    }
}


/*
May 01, 2023 20:30
Runtime 142 ms Beats 63.16%
Memory 44.3 MB Beats 21.5%
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int cnt = 0, p1 = 1;

        int tmp = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            if(tmp == nums[i])
                cnt++;
            else
            {
                cnt = 0;
                tmp = nums[i];
            }

            if (cnt < 2) {
                nums[p1] = nums[i];
                p1++;
            }
        }

        return p1;
    }
}
