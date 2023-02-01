/*
Runtime 78 ms, Beats 91.67%
Memory 37.9 MB, Beats 38.89%
Accepted: Feb 01, 2023 21:54
*/

public class Solution {
    private int _gcd(int x, int y)
    {
        if (y == 0)
            return x;
        else
            return _gcd(y, x % y);
    }

    public string GcdOfStrings(string str1, string str2)
    {
        // check if they have non-zero gcd string.
        if (!(str1 + str2).Equals(str2 + str1))
        {
            return "";
        }

        // get the gcd of the two lengths.
        int gcdLength = _gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);

    }
}
