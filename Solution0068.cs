/*
Apr 18, 2023 19:36
Runtime 148 ms Beats 91.18%
Memory 43.4 MB Beats 40.20%
*/

public class Solution {
    private string CreateFixedWidthString(List<string> words, int width)
    {
        if (words.Count == 1) {
            while (words[0].Length < width) words[0] += ' ';
            return words[0];
        }
        int count = -1;
        foreach (var w in words) count += w.Length + 1;

        int idx = 0;
        while(count < width)
        {
            words[idx] += " ";
            count++;
            idx = (idx + 1) % (words.Count - 1);
        }

        return string.Join(" ", words);
    }

    private string CreateFinalFixedWidthString(List<string> words, int width)
    {
        var sb = new StringBuilder();
        sb.AppendJoin(" ", words);
        while (sb.Length < width)
            sb.Append(" ");
        return sb.ToString();
    }

    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> ans = new List<string>();
        List<string> tmp = new List<string>();
        
        int count = -1;
        foreach(var w in words) {
            if (count + 1 + w.Length > maxWidth) { 
                ans.Add(CreateFixedWidthString(tmp, maxWidth));
                tmp = new List<string>();
                count = -1;
            }
            tmp.Add(w);
            count += 1 + w.Length;
        }

        ans.Add(CreateFinalFixedWidthString(tmp, maxWidth));

        return ans;
    }
}
