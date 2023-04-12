/*
Apr 12, 2023 21:48
Runtime 81 ms, Beats 75.51%
Memory 38.7 MB, Beats 83.67%
*/

public class Solution {
    public string SimplifyPath(string path) {
        string str = path.Replace("../","/");
        List<string> dirList = new List<string>();
        foreach(string dir in path.Split('/'))
        {
            if(dir == "..")
            {
                if(dirList.Count>0)
                    dirList.RemoveAt(dirList.Count-1);

            }else if(!String.IsNullOrEmpty(dir) && dir != ".")
                dirList.Add(dir);
        }
        return "/" + String.Join("/", dirList.ToArray());
    }
}
