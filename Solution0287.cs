/*
Runtime: 270 ms, faster than 58.11% of C# online submissions for Find the Duplicate Number.
Memory Usage: 47 MB, less than 98.61% of C# online submissions for Find the Duplicate Number.
Uploaded: 03/29/2022 20:54
*/

public class Solution {
    public int FindDuplicate(int[] nums) {
        int[] arr = new int[nums.Length];
        foreach(int i in nums){
            if(arr[i]==1){
                return i;
            }else{
                arr[i] = 1;
            }
        }
        return 0;
    }
}
