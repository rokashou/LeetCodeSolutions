/*
Runtime 333 ms, Beats 82.35%
Memory 51.2 MB, Beats 88.24%
Accepted: Jan 27, 2023 15:37
Approach: Dynamic Programming
*/

public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        var dict = new HashSet<string>();
        foreach (var w in words) dict.Add(w);

        var result = new List<string>();
        foreach(var w in words)
        {
            int length = w.Length;
            bool[] dp = new bool[length + 1];
            dp[0] = true;
            for(int i = 1; i <= length; i++)
            {
                for(int j=(i==length?1:0); !dp[i] && j < i; ++j)
                {
                    dp[i] = dp[j] && dict.Contains(w.Substring(j, i-j));
                }
            }
            if (dp[length])
            {
                result.Add(w);
            }
        }
        return result;

    }
}

/*
The code of best runtime:
1. Sort the words array with the length of words.
2. Search the shorter words only by add the longer words after the shorter ones.
*/

public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        var result = new List<string>();
        var dict = new HashSet<string>();
        // Sort words with their length, since the longer words will be not
        // subset of shorter ones.
        Array.Sort<string>(words, (a, b) => a.Length.CompareTo(b.Length));

        foreach(var w in words)
        {
            int length = w.Length;
            bool[] dp = new bool[length + 1];
            dp[0] = true;
            for(int i = 1; i <= length; i++)
            {
                for(int j=0; j < i; ++j)
                {
                    if (!dp[j]) continue;
                    if(dict.Contains(w.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            // if dp[length]==true, it means this word is perfect concatenated by others: so add it into answer sets.
            if (dp[length])
            {
                result.Add(w);
            }

            // add the word into dicts after compares to others
            dict.Add(w);
        }

        return result;
    }
}


