/*
Apr 15, 2023 19:47
Runtime 178 ms Beats 94.13% 
Memory 60.7 MB Beats 74.79%
*/

public class Solution {
    private string GetAnagram(string input)
    {
        var strArray = input.ToCharArray();
        Array.Sort(strArray);
        return new string(strArray);
    }

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        foreach(var s in strs)
        {
            var anag = GetAnagram(s);
            if (!dic.ContainsKey(anag))
            {
                dic.Add(anag, new List<string>());
            }
            dic[anag].Add(s);
        }
        List<IList<string>> ans = new List<IList<string>>();
        foreach(var va in dic.Values)
        {
            ans.Add(new List<string>(va));
        }
        return ans;
    }
}
