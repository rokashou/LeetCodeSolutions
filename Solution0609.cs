/*
Runtime: 432 ms, faster than 7.50% of C# online submissions for Find Duplicate File in System.
Memory Usage: 50.9 MB, less than 95.00% of C# online submissions for Find Duplicate File in System.
Uploaded: 09/21/2022 01:14
*/

public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string path in paths)
        {
            string[] values = path.Split(" ");
            for(int i = 1; i < values.Length; i++)
            {
                string[] name_count = values[i].Split("(");
                name_count[1] = name_count[1].Replace(")", "");
                
                if (map.ContainsKey(name_count[1]))
                {
                    map[name_count[1]].Add(values[0] + "/" + name_count[0]);
                }
                else
                {
                    var list = new List<string>();
                    list.Add(values[0] + "/" + name_count[0]);
                    map.Add(name_count[1], list);
                }
            }
        }
        IList<IList<string>> result = new List<IList<string>>();
        foreach(var key in map.Keys)
        {
            if (map[key].Count > 1)
                result.Add(map[key]);
        }

        return result;
    }
}
