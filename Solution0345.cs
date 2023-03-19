/*
Mar 19, 2023 14:43
Runtime 92 ms, Beats 51.99%
Memory 41 MB, Beats 53.97%
*/

public class Solution {
    public string ReverseVowels(string s)
    {
        var ar = s.ToCharArray();
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            while (l<=r && isVowel(ar[l]) == false) l++;
            while (r>=l && isVowel(ar[r]) == false) r--;

            // swap l and r
            if (l < r)
            {
                var tmp = ar[l];
                ar[l] = ar[r];
                ar[r] = tmp;
            }

            l++;r--;
        }

        return new string(ar);
    }
    
    private bool isVowel(char input) {
        switch (input)
        {
            case 'A':
            case 'a':
            case 'E':
            case 'e':
            case 'I':
            case 'i':
            case 'O':
            case 'o':
            case 'U':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}
