/*
Aug 01, 2023 22:38
Runtime 70 ms Beats 91.18%
Memory 36.7 MB Beats 88.24%
*/

public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        
        // Make sure s2 is smaller string
        if (s1.Length < s2.Length) {
            return MinimumDeleteSum(s2, s1);
        }
        
        // Case for empty s1
        int m = s1.Length, n = s2.Length;
        int[] currRow = new int[n + 1];
        for (int j = 1; j <= n; j++) {
            currRow[j] = currRow[j - 1] + s2[j - 1];
        }
        
        // Compute answer row-by-row
        for (int i = 1; i <= m; i++) {
            
            int diag = currRow[0];
            currRow[0] += s1[i - 1];
            
            for (int j = 1; j <= n; j++) {

                int answer;
                
                // If characters are the same, the answer is top-left-diagonal value
                if (s1[i - 1] == s2[j - 1]) {
                    answer = diag;
                }
                
                // Otherwise, the answer is minimum of top and left values with
                // deleted character's ASCII value
                else {
                    answer = Math.Min(
                        s1[i - 1] + currRow[j],
                        s2[j - 1] + currRow[j - 1]
                    );
                }
                
                // Before overwriting currRow[j] with answer, save it in diag
                // for the next column
                diag = currRow[j];
                currRow[j] = answer;
            }
        }
        
        // Return the answer
        return currRow[n];
    }
}
