/*
May 02, 2023 21:30
Runtime 76 ms Beats 97.34%
Memory 39.9 MB Beats 11.79%
*/

public class Solution {
    public int ArraySign(int[] nums) {
        int negaCnt=0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) return 0;
            if (nums[i] < 0) negaCnt++;
        }

        return negaCnt%2==0?1:-1;
    }
}
