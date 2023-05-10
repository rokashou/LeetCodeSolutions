/*
May 10, 2023 23:30
Runtime 105 ms Beats 59.62%
Memory 47.2 MB Beats 65.38%
*/

public class Solution {
    public IList<int> GrayCode(int n) {
        List<int> ans = new List<int>();
        ans.Add(0);

        for(int i = 0; i < n; i++)
        {
            int size = ans.Count;
            while (size > 0)
            {
                size--;
                int curNum = ans[size];
                curNum += (1 << i);
                ans.Add(curNum);
            }
        }
        return ans;        
    }
}
