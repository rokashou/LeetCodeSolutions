/*
Sep 26, 2023 18:59
Runtime 80 ms Beats 28.20%
Memory 38 MB Beats 83.33%
*/

public class Solution {
    public string RemoveDuplicateLetters(string s) {
        int[] lastIndex = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            lastIndex[s[i] - 'a'] = i; // track the lastIndex of character presence
        }

        bool[] seen = new bool[26]; // keep track seen
        var st = new Stack<int>();

        for(int i = 0; i < s.Length; i++)
        {
            int curr = s[i] - 'a';
            if (seen[curr]) continue; // if seen continue as we need to pick one char only
            while(st.Count > 0 && st.Peek() > curr && i < lastIndex[st.Peek()])
            {
                seen[st.Pop()] = false; // pop out and mark unseen
            }

            st.Push(curr); // add into stack
            seen[curr] = true; // mark seen
        }

        var sb = string.Empty;
        while (st.Count > 0)
            sb+=((char)(st.Pop() + 'a'));

        var sar = sb.ToCharArray();
        Array.Reverse(sar);
        return new string(sar);
        
    }
}
