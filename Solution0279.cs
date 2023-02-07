/*
Runtime 25 ms, Beats 98.21%
Memory 26.5 MB, Beats 98.21%
Accept Feb 07, 2023 23:27
Math: Lagrange's Four Square theorem
*/

public class Solution {
    private bool IsSquare(int n)
    {
        int sqrt_n = (int)Math.Sqrt(n);
        return (sqrt_n * sqrt_n == n);
    }

    // Based on Lagrange's Four Square theorem, there are only 4 possible
    // results: 1,2,3,4.
    public int NumSquares(int n) {
        // if n is a prefect square, return 1
        if (IsSquare(n)) return 1;

        // The result is 4 iff n can be written in the form of
        // 4^k(8m+7)
        // Please refer to Legendre's three-square theorem.
        while((n&3)==0) // n%4 == 0
        {
            n >>= 2;
        }
        if((n&7)==7) // n%8 == 7
        {
            return 4;
        }

        // Check whether 2 is the result
        int sqrt_n = (int)Math.Sqrt(n);
        for(int i = 1; i <= sqrt_n; i++)
        {
            if (IsSquare(n - i * i))
            {
                return 2;
            }
        }

        return 3;
    }
}


/*
Runtime 65 ms, Beats 62.50%
Memory 32.6 MB, Beats 30.95%
Feb 07, 2023 23:48
Dynamic Programming
*/

public class Solution {
    public int NumSquares(int n) {
        if (n <= 0) return 0;

        // cntPerfectSquares[i] = the least number of perfect square numbers
        // which sum to i. Since cntPerfectSquares is a static List, if
        // cntPrefectSquares.Count > n, we have already calculated the result
        // during previous function calls and we can just return the result now.
        var cntPerfectSquares = new List<int>();
        cntPerfectSquares.Add(0);


        // while cntPerfectSquares.Count <= n, we need to incrementally
        // calculate the next result until we get the result for n.
        while(cntPerfectSquares.Count <= n)
        {
            int m = cntPerfectSquares.Count;
            int cntSquares = int.MaxValue;
            for(int i = 1; i * i <= m; i++)
            {
                cntSquares = Math.Min(cntSquares, cntPerfectSquares[m - i * i] + 1);
            }
            cntPerfectSquares.Add(cntSquares);
        }

        return cntPerfectSquares[n];
    }
}
