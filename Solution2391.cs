/*
Mar 19, 2023 16:28
Runtime 246 ms Beats 68.85%
Memory 74.7 MB, Beats 26.23%
*/


public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int[] garbageCount = new int[3];

        // count by garbage types backward
        for (int i = garbage.Length-1; i >=0; i--)
        {
            for (int j = 0; j < 3; j++)
            {
                if (garbageCount[j] > 0) garbageCount[j] += travel[i];
            }

            foreach (char gc in garbage[i])
            {
                int idx = 0;
                switch (gc)
                {
                    case 'M':
                        break;
                    case 'P':
                        idx = 1;
                        break;
                    case 'G':
                        idx = 2;
                        break;
                }
                garbageCount[idx]++;
            }
        }

        return garbageCount[0] + garbageCount[1] + garbageCount[2];
    }
}
