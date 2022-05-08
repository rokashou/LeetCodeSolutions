/*
Runtime: 79 ms, faster than 5.20% of C# online submissions for Sqrt(x).
Memory Usage: 25.1 MB, less than 84.64% of C# online submissions for Sqrt(x).
Uploaded: 05/08/2022 22:14
*/

public class Solution {
    public int MySqrt(int x)
    {
        int result = 0;
        while( (long)(result + 1) * (result+1) <= x )
        {
            result ++;
        }
        return result;
    }
}

/*
Runtime: 38 ms, faster than 38.56% of C# online submissions for Sqrt(x).
Memory Usage: 25.3 MB, less than 71.36% of C# online submissions for Sqrt(x).
Uploaded: 05/08/2022 22:32
*/

public class Solution {
    public int MySqrt(int x)
    {
        if (x == 0) return 0;
        int left = 1;
        int right = x / 2;

        while (true) {
            int mid = left + (right - left) / 2;
            if(mid > x / mid)
            {
                right = mid - 1;
            }
            else
            {
                if (mid + 1 > x / (mid + 1)) return mid;
                left = mid + 1;
            }
        }
    }
}
