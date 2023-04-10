/*
Apr 10, 2023 23:18
Runtime 80 ms, Beats 86.14%
Memory 38.9 MB, Beats 34.34%
*/

public class Solution {
    public int UniqueMorseRepresentations(string[] words)
    {
        var MorseCode = new string[]{ ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        var set = new HashSet<string>();
        foreach(var word in words)
        {
            var sb = new System.Text.StringBuilder();
            foreach (var ch in word)
                sb.Append(MorseCode[ch - 'a']);
                
            set.Add(sb.ToString());
        }
        return set.Count;
    }
}
