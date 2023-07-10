/*
Jul 10, 2023 22:23
Runtime 137 ms Beats 100%
Memory 37.4 MB Beats 80%
*/

public class Solution {
    public int LargestVariance(string s) {
        if (string.IsNullOrWhiteSpace(s) || s.Length == 1) {
            return 0;
        }

        HashSet<char> distinct = new HashSet<char>();
        foreach (char c in s) {
            distinct.Add(c);
        }

        int maxVariance = 0;
        foreach (char max in distinct) {
            foreach (char min in distinct) {
                if (max == min) {
                    continue;
                }

                maxVariance = Math.Max(maxVariance, getVariance(max, min, s));
            }
        }

        return maxVariance;
    }

    private int getVariance(char max, char min, string s) {
        int maxVariance = 0;
        int variance = 0;
        bool hasMin = false;
        bool startsWithMin = false;

        foreach (char c in s) {
            if (c != max && c != min) {
                continue;
            } else if (c == max) {
                variance++;
            } else if (c == min) {
                hasMin = true;
                if (startsWithMin && variance >= 0) {
                    startsWithMin = false;
                } else if (variance - 1 < 0) {
                    startsWithMin = true;
                    variance = -1;
                } else {
                    variance--;
                }
            }
            
            if (hasMin) {
                maxVariance = Math.Max(maxVariance, variance);
            }
        }

        return maxVariance;
    }
}
