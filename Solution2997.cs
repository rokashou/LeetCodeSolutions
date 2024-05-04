/*
My Solution: May 05, 2024 01:01
Runtime 340 ms Beats 55.22% of users with C#
Memory 71.51 MB Beats 60.94% of users with C#
*/

public class Solution {
    public int MinOperations(int[] nums, int k) {
        int fulxor = nums[0];
        for(int i=1;i<nums.Length;i++){
            fulxor ^= nums[i]; 
        }
        int sum = 0;
        for(int i=0;i<32;i++){
            sum += ((1 << i) & k) == ((1 << i) & fulxor) ? 0 : 1;
        }
        return sum;       
    }
}

