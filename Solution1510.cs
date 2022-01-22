/*
Approach 1: DFS in memoization

Uploaded: 01/22/2022 21:40
Runtime: 472 ms, faster than 33.33% of C# online submissions for Stone Game IV.
Memory Usage: 39.7 MB, less than 33.33% of C# online submissions for Stone Game IV.

*/

public class Solution_AP1 {
    public bool WinnerSquareGame(int n)
    {
        Dictionary<int, bool> cache = new Dictionary<int, bool>();
        cache.Add(0, false);
        return dfs(cache, n);
    }

    public static bool dfs(Dictionary<int,bool> cache, int remain){
        if(cache.ContainsKey(remain)) {
            return cache[remain];
        }
        int sqrt_root = (int)Math.Sqrt(remain);
        for (int i = 1; i <= sqrt_root;i++){
            // if there is any chance to make the opponent lose the game in the next round,
            // then the current player will win.
            if(!dfs(cache,remain- i*i)){
                cache.Add(remain, true);
                return true;
            }

        }
        cache.Add(remain, false);
        return false;
    }

}



/*
Approach 2: DP - 1
Uploaded: 01/22/2022 21:42
Runtime: 79 ms, faster than 100.00% of C# online submissions for Stone Game IV.
Memory Usage: 27.3 MB, less than 66.67% of C# online submissions for Stone Game IV.
*/

public class Solution_Ap2_1 {
    public bool WinnerSquareGame(int n)
    {
        bool[] dp = new bool[n + 1];
        for (int i = 0; i < n + 1;i++){
            for (int k = 1; k * k <= i;k++){
                if(dp[i-k*k] == false){
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[n];
    }

}


/*
Approach 2: DP - 2
Uploaded: 01/22/2022 21:44
Runtime: 47 ms, faster than 100.00% of C# online submissions for Stone Game IV.
Memory Usage: 27.3 MB, less than 66.67% of C# online submissions for Stone Game IV.
*/

public class Solution {
    public bool WinnerSquareGame(int n)
    {
        bool[] dp = new bool[n + 1];
        for (int i = 0; i <= n; i++){
            if(dp[i]){
                continue;
            }
            for (int k = 1; i + k * k <= n;k++){
                dp[i + k * k] = true;
            }
        }
        return dp[n];
    }
}


