
#region Iterative Solution
/*
Runtime 161 ms, Beats 33.38%
Memory 42.9 MB, Beats 79.13%
Accepted: Jan 25, 2023 11:40
*/

public class Solution93_1
{
    public IList<string> RestoreIpAddresses(string s)
    {
        IList<string> result = new List<string>();
        for (int a = 1; a <= 3; ++a)
        {
            for (int b = 1; b <= 3; ++b)
            {
                for (int c = 1; c <= 3; ++c)
                {
                    int d = s.Length - a - b - c;
                    // Last number must use all remain digits. Check:
                    // 1. The size of the last number is valid
                    // 2. Every number uses 1 digit for 0 and is less than 255 if using 3 digits
                    if (1 <= d && d <= 3 &&
                        (1 == a || '0' != s[0] && (3 != a || 0 < string.Compare("256", 0, s, 0, 3))) &&
                        (1 == b || '0' != s[a] && (3 != b || 0 < string.Compare("256", 0, s, a, 3))) &&
                        (1 == c || '0' != s[a + b] && (3 != c || 0 < string.Compare("256", 0, s, a + b, 3))) &&
                        (1 == d || '0' != s[a + b + c] && (3 != d || 0 < string.Compare("256", 0, s, a + b + c, 3))))
                    {
                        result.Add(
                            s.Substring(0, a) + "." +
                            s.Substring(a, b) + "." +
                            s.Substring(a + b, c) + "." +
                            s.Substring(a + b + c));
                    }

                }
            }
        }
        return result;
    }
}

#endregion




#region 93-2 Recursive Backtrack solution

/*
Runtime 154 ms, Beats 45.38%
Memory 44 MB, Beats 41.63%
Accepted: Jan 25, 2023 12:09
*/

public class Solution93_2
{
    private IList<string> res = new List<string>();

    public IList<string> RestoreIpAddresses(string s)
    {
        Backtrack(s, new StringBuilder(), 0, 0);
        return res;
    }

    private void Backtrack(string s, StringBuilder cur, int i, int cnt)
    {
        // The last section
        if (3 == cnt)
        {
            string str = s.Substring(i, s.Length - i);

            if (str[0] == '0' && s.Length - i > 1) return;

            long range = Convert.ToInt64(s.Substring(i, s.Length - i));

            if (range >= 0 && range <= 255)
            {
                res.Add(cur.ToString() + range);
            }

            return;
        }

        // must remain 3+cnt digits
        // ex: cnt==0, j must >= 3
        for (int j = i; j < s.Length - 3 + cnt; j++)
        {
            var str = s.Substring(i, j - i + 1);

            if (str[0] == '0' && (j - i + 1) > 1) return;

            long range = Convert.ToInt64(str);

            if (range >= 0 && range <= 255)
            {
                cur.Append(range.ToString() + ".");

                Backtrack(s, cur, j + 1, cnt + 1);

                // remove the lastest range
                cur.Remove(cur.Length - (range.ToString().Length + 1), range.ToString().Length + 1);

            }
        }
    }
}
#endregion
