/*
Runtime 291 ms, Beats 83.33%
Memory 59 MB, Beats 66.67%
Accept: Feb 09, 2023 21:13
*/


public class Solution {
    public long DistinctNames(string[] ideas) {
        var groups = new HashSet<string>[26];
        for (int i = 0; i < 26; i++) groups[i] = new HashSet<string>();

        foreach(var idea in ideas)
        {
            int init = idea[0]-'a';
            string suffix = idea.Substring(1);
            groups[init].Add(suffix);
        }

        long sum = 0;
        for(int i = 0; i < 26 - 1; i++)
        {
            for(int j = i + 1; j < 26; j++)
            {
                // Get the number of mutual suffixes.
                long numOfMutual = 0;
                foreach(var idea in groups[i])
                {
                    if (groups[j].Contains(idea))
                    {
                        numOfMutual++;
                    }
                }

                sum += (groups[i].Count - numOfMutual) * (groups[j].Count - numOfMutual);
            }
        }

        // Valid names are only from distinct suffixes in both groups.
        // Since we can swap a with b and swap b with a to create two
        // valid names, multiple answer by 2.
        sum *= 2;

        return sum;
    }
}
