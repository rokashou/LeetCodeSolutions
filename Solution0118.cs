/*
Runtime: 163 ms, faster than 24.07% of C# online submissions for Pascal's Triangle.
Memory Usage: 35 MB, less than 66.64% of C# online submissions for Pascal's Triangle.
Uploaded: 07/19/2022 22:25
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> list = new List<IList<int>>();
        list.Add(new List<int> { 1 });
        for(int i=1;i<numRows;i++) { 
            List<int> subList = new List<int>();
            IList<int> temp = list[list.Count - 1];
            subList.Add(1);
            for(int idx = 1; idx < temp.Count; idx++)
            {
                subList.Add(temp[idx - 1] + temp[idx]);
            }
            subList.Add(1);
            list.Add(subList);
        }
        return list;
    }
}
