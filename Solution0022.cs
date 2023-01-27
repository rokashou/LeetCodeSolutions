/*
Runtime 229 ms, Beats 18.59%
Memory 46.3 MB, Beats 24.10%
Accepted: Jan 27, 2023 18:22
*/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();

        if (n == 0)
        {
            result.Add("");
        }
        else
        {
            for(int c = 0; c < n; ++c)
              foreach(string left in GenerateParenthesis(c))
                foreach(string right in GenerateParenthesis(n - 1 - c))
                    result.Add("(" + left + ")" + right);
        }

        return result;        
    }
}
