/*
Runtime: 37 ms, faster than 34.18% of C# online submissions for Subtract the Product and Sum of Digits of an Integer.
Memory Usage: 25.1 MB, less than 68.72% of C# online submissions for Subtract the Product and Sum of Digits of an Integer.
Uploaded: 06/09/2022 21:01
*/

public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum = 0;
        int prod = 1;
        while (n > 0)
        {
            sum += n % 10;
            prod *= (n % 10);
            n /= 10;
        }
        return prod - sum;
    }
}
