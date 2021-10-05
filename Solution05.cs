public class Solution {
    public string LongestPalindrome(string s)
    {
        string lp = string.Empty;
        int left = 0;
        int right = 0;
        int length = s.Length;
        PalindromicChecker pc = new PalindromicChecker();

        if (length == 1) return s;

        pc.CheckPalindromic(s[0].ToString());
        for (left = 0; left < length - 1; left++)
        {
            for(right = length-1; right > left; right--) {
                if (s[right] != s[left]) continue;

                lp = s.Substring(left, right - left + 1);

                pc.CheckPalindromic(lp);
            }
        }
        return pc.LongestPalindromicString;
    }

    class PalindromicChecker
    {
        public string LongestPalindromicString = string.Empty;

        public bool CheckPalindromic(string s)
        {
            int length = s.Length;

            if(length < LongestPalindromicString.Length) return false;

            for (int index = 0; index < length / 2; index++)
            {
                if (s[index] != s[length - index - 1]) return false;
            }

            if (LongestPalindromicString.Length < s.Length)
            {
                LongestPalindromicString = s;
            }

            return true;
        }

    }
}
