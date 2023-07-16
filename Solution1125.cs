/*
Jul 17, 2023 00:07
Runtime 194 ms Beats 80%
Memory 56.6 MB Beats 20%
*/

public class Solution {
    public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
    {
        var bitMaskKey = BuildBitMask(req_skills);
        var skillSets = new Dictionary<int, List<int>>();

        skillSets[0] = new List<int>();
        int bitmask, newBitmask;
        for(int i=0;i<people.Count; i++) {
            bitmask = ConvertPersonToBitMask(bitMaskKey, people[i]);
            foreach(int key in skillSets.Keys.ToArray()) {
                if((key & bitmask) != bitmask) {
                    newBitmask = (key | bitmask);
                    if(!skillSets.ContainsKey(newBitmask) || (skillSets[newBitmask].Count > (skillSets[key].Count + 1))) {
                        skillSets[newBitmask] = new List<int>(skillSets[key]);
                        skillSets[newBitmask].Add(i);
                    }
                }
            }
        }
        return skillSets[ConvertPersonToBitMask(bitMaskKey, req_skills)].ToArray();

    }

    private int ConvertPersonToBitMask(Dictionary<string, int> bitMaskKey, IEnumerable<string> person)
    {
        int bitmask = 0;
        foreach(var skill in person) {
            bitmask += bitMaskKey[skill];
        }
        return bitmask;
    }

    private Dictionary<string,int> BuildBitMask(string[] req_skills)
    {
        var bitMaskKey = new Dictionary<string, int>();
        int val = 1;
        foreach(var skill in req_skills) {
            bitMaskKey.Add(skill, val);
            val *= 2;
        }
        return bitMaskKey;
    }
}
