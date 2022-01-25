/*
Uploaded: 01/25/2022 20:54
Runtime: 124 ms, faster than 61.08% of C# online submissions for Capitalize the Title.
Memory Usage: 36.9 MB, less than 71.43% of C# online submissions for Capitalize the Title.
*/

public class Solution {
    public string CapitalizeTitle(string title) {
        var sa = title.Split(' ');
        var sb = new System.Text.StringBuilder();
        foreach(var s in sa){
            string tmp = s.ToLower();
            if (sb.Length > 0) sb.Append(" ");
            if(s.Length >= 3){
                sb.Append(char.ToUpper(s[0]));
                sb.Append(tmp.Substring(1));
            }else{
                sb.Append(tmp);
            }
        }
        return sb.ToString();
    }
}
