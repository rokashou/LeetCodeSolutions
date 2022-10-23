/*

Runtime: 253 ms, faster than 50.00% of C# online submissions for Group the People Given the Group Size They Belong To.
Memory Usage: 45.8 MB, less than 50.00% of C# online submissions for Group the People Given the Group Size They Belong To.
Uploaded: 10/23/2022 22:44
*/

public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        IList<IList<int>> result = new List<IList<int>>();
        Dictionary<int, List<int>> unfilledList = new Dictionary<int, List<int>>();

        int count = groupSizes.Length;
        for(int i = 0; i < count; i++)
        {
            var groupsize = groupSizes[i];
            if (unfilledList.ContainsKey(groupsize))
            {
                unfilledList[groupsize].Add(i);
            }
            else
            {
                var newList = new List<int>();
                newList.Add(i);
                unfilledList.Add(groupsize, newList);
            }

            if (unfilledList[groupsize].Count == groupsize)
            {
                result.Add(unfilledList[groupsize]);
                unfilledList.Remove(groupsize);
            }
        }

        return result;
    }
}
