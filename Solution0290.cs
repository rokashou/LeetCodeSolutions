/*
Runtime: 141 ms, faster than 11.23% of C# online submissions for Word Pattern.
Memory Usage: 35.7 MB, less than 97.10% of C# online submissions for Word Pattern.
Uploaded: 01/17/2022 22:37
*/



public class Solution {
    public bool WordPattern(string pattern, string s) {
        var sarray = s.Split(' ');
        if(sarray.Length != pattern.Length) return false;
        
        Dictionary<char, string> dic = new Dictionary<char, string>();
        for (int i = 0; i < pattern.Length;i++){
            //char ch = pattern[i];
            if(!dic.ContainsKey(pattern[i]) && !dic.ContainsValue(sarray[i])){
                dic.Add(pattern[i], sarray[i]);
            }
            else{
                if(dic.ContainsKey(pattern[i]) && (dic[pattern[i]] != sarray[i])) return false;
                if(dic.ContainsValue(sarray[i]) && !dic.ContainsKey(pattern[i])) return false;
            }
        }
        return true;

    }
}
