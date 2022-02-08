/*
Runtime: 8 ms, faster than 100.00% of C# online submissions for Minimum Sum of Four Digit Number After Splitting Digits.
Memory Usage: 26.8 MB, less than 18.52% of C# online submissions for Minimum Sum of Four Digit Number After Splitting Digits.
Uploaded: 02/08/2022 23:38
*/



public class Solution {
    public int MinimumSum(int num) {
        int[] na = new int[4];
        na[0] = num % 10;
        num /= 10;
        na[1] = num % 10;
        num /= 10;
        na[2] = num % 10;
        num /= 10;
        na[3] = num;
        Array.Sort<int>(na);

        return (na[0] + na[1]) * 10 + na[2] + na[3];

    }
}
