/*
Jul 25, 2023 23:14
Runtime 115 ms Beats 71.52%
Memory 37.9 MB Beats 97.97%
*/

public class Solution {
    private int dfs(int i, int[] distribute, int[] cookies, int k, int zeroCount) {
        // if there are not enough cookies remaining, return int.MaxValue as it leads to an invalid distribution.
        if (cookies.Length - i < zeroCount) {
            return int.MaxValue;
        }

        // After distributing all cookies, return the unfairness of his distribution
        if (i == cookies.Length) {
            int unfairness = int.MinValue;
            for(int y = 0; y < distribute.Length; y++) {
                unfairness = Math.Max(unfairness, distribute[y]);
            }
            return unfairness;
        }

        // Try to distribute the i-th cookie to each child, and update answer as the minimum unfairness in these distributions.
        int answer = int.MaxValue;
        for(int j = 0; j < k; j++) {
            zeroCount -= (distribute[j] == 0) ? 1 : 0;
            distribute[j] += cookies[i];

            // recursively distribute the next cookie.
            answer = Math.Min(answer, dfs(i + 1, distribute, cookies, k, zeroCount));

            distribute[j] -= cookies[i];
            zeroCount += (distribute[j] == 0 )? 1 : 0;

        }

        return answer;
    }

    public int DistributeCookies(int[] cookies, int k)
    {
        int[] distribute = new int[k];

        return dfs(0, distribute, cookies, k, k);
    }
}
