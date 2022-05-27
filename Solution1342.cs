/*
Runtime: 54 ms, faster than 5.17% of C# online submissions for Number of Steps to Reduce a Number to Zero.
Memory Usage: 25.3 MB, less than 43.13% of C# online submissions for Number of Steps to Reduce a Number to Zero.
Uploaded: 05/27/2022 20:31
*/

public class Solution {
    public int NumberOfSteps(int num) {
        int round = 0;
        while(num > 0)
        {
            round++;
            if (num % 2 == 0)
                num /= 2;
            else
                num -= 1;
        }
        return round;
    }
}

