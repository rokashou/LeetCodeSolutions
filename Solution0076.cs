/*
Apr 22, 2023 21:19
Runtime 95 ms Beats 66.94%
Memory 40.3 MB Beats 73.12%
*/


public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length == 0 || t.Length == 0) return "";

        var tSet = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        // building tSet and window
        foreach (var ch in t) {
            if (!tSet.ContainsKey(ch)) {
                tSet.Add(ch, 1);
                window.Add(ch, 0);
            } else { 
                tSet[ch]++;
            }
        }

        int lenT = tSet.Count;
        int winReq = 0;

        int resLen = int.MaxValue;
        int resp1 = -1, resp2 = -1;
        int p1 = 0, p2 = 0;

        while (p2 < s.Length) {
            if (window.ContainsKey(s[p2])) {
                window[s[p2]]++;
                if (window[s[p2]] == tSet[s[p2]]) 
                    winReq++;
            }

            while(p1<=p2 && winReq == lenT)
            {
                if(p2-p1+1 < resLen) {
                    resLen = p2 - p1 + 1;
                    resp1 = p1;
                    resp2 = p2;
                }

                if (window.ContainsKey(s[p1])) {
                    window[s[p1]]--;
                    if (window[s[p1]] < tSet[s[p1]]) 
                        winReq--;
                }

                p1++;
            }
            p2++;
        }

        if(winReq == lenT) {
            resLen = p2 - p1 + 1;
            resp1 = p1;
            resp2 = p2;
        }

        if (resp1 == -1) return "";

        return s.Substring(resp1, resLen);

    }
}

