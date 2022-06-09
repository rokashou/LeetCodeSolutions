/*
Runtime: 216 ms, faster than 41.81% of C# online submissions for Two Sum II - Input Array Is Sorted.
Memory Usage: 44.7 MB, less than 79.14% of C# online submissions for Two Sum II - Input Array Is Sorted.
Uploaded: 06/09/2022 20:51	
*/



public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int p1 = 0, p2 = numbers.Length-1;
        while (p1<p2)
        {
            int k = numbers[p1] + numbers[p2];
            if (k == target)
            {
                return new int[] { p1 + 1, p2 + 1 }; 
            }

            if (k > target)
                p2--;
            else
                p1++;

        }
        return new int[2];
    }
}
