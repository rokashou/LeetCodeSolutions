/*
Runtime: 107 ms, faster than 68.36% of C# online submissions for Combination Sum III.
Memory Usage: 35 MB, less than 50.28% of C# online submissions for Combination Sum III.
Uploaded: 05/11/2022 00:21
*/

public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        return GetRemainedList(1, k, n);
    }

    private IList<IList<int>> GetRemainedList(int start, int count, int n) {
        List<IList<int>> result = new List<IList<int>>();

        if (start > n) return result;
        if (count == 0) return result;
        if(count == 1)
        {
            if (n <= 9) { 
                return new List<IList<int>>() { new List<int>() { n } };
            }
            else
                return result;
        }

        for(int i = start; i <= 9; i++)
        {
            var lists = GetRemainedList(i + 1, count - 1, n - i);
            if (lists == null)
                break;
            foreach(var list in lists)
            {
                if(list != null && list.Count == count - 1) {
                    list.Insert(0, i);
                    result.Add(list);
                }
            }
        }
        return result;

    }
}
