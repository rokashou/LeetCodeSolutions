public class Solution {
    public int SingleNumber(int[] nums)
    {
        HashSet<int> list = new HashSet<int>();

        foreach(var item in nums)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
            else
            {
                list.Remove(item);
            }
        }

        return list.First();
    }
}

