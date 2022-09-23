/*
Runtime: 601 ms, faster than 50.00% of C# online submissions for Concatenation of Consecutive Binary Numbers.
Memory Usage: 26.5 MB, less than 50.00% of C# online submissions for Concatenation of Consecutive Binary Numbers.
Uploaded: 09/23/2022 17:57
*/

public class Solution {
    private const int MODULO = 1_000_000_007;

    public int ConcatenatedBinary(int n)
    {
        /*
         * ( a + b ) % n = ( (a%n) + (b%n) ) % n;
         * ( a * b ) % n = ( (a%n) * (b%n) ) % n;
         */

        int result = 0;

        for(int i = 1; i<=n; i++)
        {
            result = GetAddition(result, i);
        }

        return result;
    }

    public int GetAddition(int origin, int addition)
    {
        double numLog = Math.Log2(addition);
        int numLen = (int)Math.Floor(numLog) + 1;

        int num1 = ShiftLeftNWithMod(origin, numLen, MODULO);
        int num2 = addition % MODULO;
        int result = (num1 + num2) % MODULO;

        return result;
    }

    private int ShiftLeftNWithMod(int origin, int n, int modulo)
    {
        int result = origin;
        for(int i = 0; i < n; i++)
        {
            result = (result << 1) % modulo;
        }
        return result;
    }
}

