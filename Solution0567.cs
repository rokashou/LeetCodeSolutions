/*
Sliding Window
Runtime 80 ms, Beats 85.85%
Memory 39.9 MB, Beats 41.91%
Accept Feb 06, 2023 01:07
*/

public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;

        int[] freq = new int[26];
        int[] window = new int[26];


        // first window
        for(int i = 0; i < s1.Length; i++)
        {
            freq[s1[i]-'a']++;
            window[s2[i]-'a']++;
        }

        if (CheckArrayEquals(freq, window)) return true;
        for(int i = s1.Length; i < s2.Length; i++) {
            window[s2[i - s1.Length] - 'a']--;
            window[s2[i] - 'a']++;

            if (CheckArrayEquals(freq, window)) return true;
        }

        return false;
    }

    private bool CheckArrayEquals(int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}



/*
Runtime 2406 ms, Beats 5.15%
Memory 51.3 MB, Beats 7.17%
Feb 06, 2023 00:17
*/

public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;

        for (int i = 0; i <= s2.Length - s1.Length; i++){
            if (CheckPermutation(s1, s2.Substring(i, s1.Length)))
                return true;
        }

        return false;
    }

    private bool CheckPermutation(string s1, string s2)
    {
        char[] s1map = s1.ToCharArray();
        char[] s2map = s2.ToCharArray();
        Array.Sort(s1map);
        Array.Sort(s2map);
        for(int i = 0; i < s1.Length; i++)
        {
            if (s1map[i] != s2map[i]) return false;
        }
        return true;
    }
}






/*
Runtime: 117 ms, faster than 62.64% of C# online submissions for Permutation in String.
Memory Usage: 37.7 MB, less than 63.25% of C# online submissions for Permutation in String.
Uploaded: 02/11/2022 23:26

Not pass: Feb 06, 2023
*/


public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;

        int[] s1map = new int[26];
        int[] s2map = new int[26];

        for (int i = 0; i < s1.Length;i++){
            s1map[s1[i] - 'a']++;
            s2map[s2[i] - 'a']++;
        }

        int count = 0;
        for (int i = 0; i < 26;i++){
            if(s1map[i] == s2map[i])
                count++;
        }

        for (int i = 0; i < (s2.Length - s1.Length); i++){
            int r = s2[i + s1.Length] - 'a', l = s2[i] - 'a';
            if(count == 26) return true;
            
            s2map[r]++;
            if (s2map[r] == s1map[r]) { 
                count++; 
            } else if (s2map[r]==s1map[r]+1){
                count--;
            }
            s2map[l]--;
            if(s2map[l]==s1map[l]){
                count++;
            }
            else if(s2map[l] == s1map[l]-1){
                count--;
            }
        }
        return (count == 26);

    }
}
