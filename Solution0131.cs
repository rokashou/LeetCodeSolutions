/*
Runtime 652 ms, Beats 48.10%
Memory 78 MB, Beats 14.46%
Accepted: Jan 27, 2023 20:24
*/

public class Solution {
    // Backtracking Approach
    public IList<IList<string>> Partition(string s)
    {
        // 1. define "result" to hold "candidates"
        IList<IList<string>> result = new List<IList<string>>();
        // 2. define "candidates" to hold all potential candidates(palindromic substring)
        var candidates = new List<string>();
        // 3. start backtrack from index 0
        _backtrack(s, result, candidates, 0);
        // 4. return the answer
        return result;
    }

    private void _backtrack(string s, IList<IList<string>> ans, List<string> candidates, int start)
    {
        // 1. check if the goal is fulfulled,
        // i.e. reaching the end of string in this problem
        if(start == s.Length)
        {
            ans.Add(new List<string>(candidates));
            return;
        }

        // 2. find all potential candidates
        for(int i = start; i < s.Length; i++)
        {
            // we want to test all substrings, each substring is a potential candidate
            // e.g. "aab" -> "a","a","b","aa","ab","aab"
            string candidate = s.Substring(start, i - start + 1);
            // 3. check if the current candidate is palindrome or not
            // if not, drop it.
            if (!_isPalindrome(candidate)) continue;
            // 4. if yes, add it to candidates
            candidates.Add(candidate);
            // 5. backtrack with index + 1
            _backtrack(s, ans, candidates, i + 1);
            // 6. remove the current substring from "candidates"
            candidates.RemoveAt(candidates.Count - 1);
        }
    }

    private bool _isPalindrome(string s)
    {
        var sArray = s.ToArray();
        Array.Reverse(sArray);

        return (new string(s.Reverse().ToArray())).Equals(s);
    }
}
