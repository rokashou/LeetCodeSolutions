/*
Mar 19, 2023 16:04
Runtime 124 ms, Beats 96.71%
Memory 53.8 MB, Beats 36.84%
*/

public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count = 0;

        int keyIndex = 0;
        switch (ruleKey)
        {
            case "type":
                keyIndex = 0;
                break;
            case "color":
                keyIndex = 1;
                break;
            case "name":
                keyIndex = 2;
                break;
        }

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i][keyIndex] == ruleValue) count+=1;
        }

        return count;
    }
}
