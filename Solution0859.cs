/*
Jul 03, 2023 21:35
Runtime 76 ms Beats 70.83%
Memory 39.2 MB Beats 52.78%
*/

public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if (s.Length != goal.Length) return false;

        if (s.Equals(goal)) {
            // if we have 2 same characters in string 's',
            // we can swap them and still the strings will remain equal.
            int[] frequency = new int[26];

            for (int i = 0; i < s.Length; i++) {
                frequency[s[i] - 'a'] += 1;
                if (frequency[s[i] - 'a'] == 2) return true;
            }

            // Otherwise, if we swap any two characters, it will make the strings unequal.
            return false;
        }

        int firstIndex = -1;
        int secondIndex = -1;
        for(int i = 0; i < s.Length; i++) {
            if (s[i] != goal[i]) {
                if (firstIndex == -1)
                    firstIndex = i;
                else if (secondIndex == -1)
                    secondIndex = i;
                else {
                    // we have at least 3 indices with different characters, thus, we can never make the strings equal with only one swap.
                    return false;
                }
            }
        }

        if (secondIndex == -1) {
            // We can't swap if the character at only one index is different.
            return false;
        }

        // All characters of both strings are the same except two indices.

        return s[firstIndex] == goal[secondIndex] &&
            s[secondIndex] == goal[firstIndex];
    }
}
