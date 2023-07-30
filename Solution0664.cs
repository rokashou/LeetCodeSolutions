/*
Jul 30, 2023 23:05
Runtime 64 ms Beats 100%
Memory 38.5 MB Beats 40%
*/


public class Solution {
    public int StrangePrinter(string s) {
        var dp = new int[s.Length, s.Length];

        var charMap = new Dictionary<char, List<int>>();
        for (var i = 0; i < s.Length; i++) {
            var c = s[i];
            if (charMap.ContainsKey(c)) {
                charMap[c].Add(i);
            }
            else {
                charMap[c] = new List<int> { i };
            }
        }

        // init costs for substrings of length n = 1
        for (var i = 0; i < s.Length; i++) {
            dp[i, i] = 1;
        }

        // calculate costs for substrings of length n >= 2
        for (var n = 2; n <= s.Length; n++) {
            for (var i = 0; i <= s.Length - n; i++) {
                var j = i + n - 1;
                
                if (s[j] == s[j - 1]) {
                    // extending the current run
                    dp[i, j] = dp[i, j - 1];
                }
                else {
                    var extensionCost = int.MaxValue;

                    if (charMap.ContainsKey(s[j])) {
                        foreach (var k in charMap[s[j]]) {
                            if (k >= j) {
                                break;
                            }
                            if (k < i) {
                                continue;
                            }

                            extensionCost = Math.Min(extensionCost, dp[i, k] + dp [k + 1, j - 1]);
                        }
                    }

                    var startNewRunCost = dp[i, j - 1] + 1;
                    dp[i, j] = Math.Min(extensionCost, startNewRunCost);
                }
            }
        }

        return dp[0, s.Length - 1];
    }
}
