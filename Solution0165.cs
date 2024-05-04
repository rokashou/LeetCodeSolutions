/*
May 05, 2024 00:04
Runtime 42 ms Beats 83.33% of users with C#
Memory 38.25 MB Beats 5.83% of users with C#
*/

public class Solution {
    public int CompareVersion(string version1, string version2) {
        var ver1Split = version1.Split(new[] { '.' });
        var ver2Split = version2.Split(new[] { '.' });
        int i = 0; // for looping the revision in version1 string
        while(i < ver1Split.Length && i < ver2Split.Length){
            int ver1 = int.Parse(ver1Split[i]);
            int ver2 = int.Parse(ver2Split[i]);
            if (ver1 > ver2) return 1;
            if (ver1 < ver2) return -1;
            i++;
        }
        while(i<ver1Split.Length){
            int ver1 = int.Parse(ver1Split[i]);
            if (ver1 > 0) return 1;
            i++;
        }
        while(i<ver2Split.Length){
            int ver2 = int.Parse (ver2Split[i]);
            if (ver2 > 0) return -1;
            i++;
        }
        return 0;
    }
}
