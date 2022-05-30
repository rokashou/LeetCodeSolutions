/*
Runtime: 43 ms, faster than 42.96% of C# online submissions for Divide Two Integers.
Memory Usage: 25.4 MB, less than 76.88% of C# online submissions for Divide Two Integers.
Uploaded: 05/30/2022 22:24
*/

public class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

        long dvd = Math.Abs((long)dividend), dvs = Math.Abs((long)divisor), ans = 0;
        int sign = ((dividend > 0) ^ (divisor > 0)) ? -1 : 1;
        while(dvd >= dvs)
        {
            long tmp = dvs, m = 1;
            while(tmp << 1 <= dvd)
            {
                tmp <<= 1;
                m <<= 1;
            }
            dvd -= tmp;
            ans += m;
        }
        return (int)(sign * ans);
    }
}
