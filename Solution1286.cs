/*
Uploaded: 11/14/2021 19:26
Runtime: 160 ms, faster than 26.67% of C# online submissions for Iterator for Combination.
Memory Usage: 48.2 MB, less than 73.33% of C# online submissions for Iterator for Combination.
*/


public class CombinationIterator {

    private int CurrentIdx;
    private int MaxIdx;
    private List<string> combinationList;

    /*
    // Ref: https://www.algotree.org/algorithms/numeric/subsets_bitwise/
    private List<string> GetCombinationsBitwise(string characters){
        int sz = characters.Length;
        List<string> combinations =  new List<string>();
        for (int mask = 0; mask < (1<<sz); mask++){
            string comb = string.Empty; // Stores a combination
            for (int pos = 0; pos < sz; pos++){
                if((mask & (1 << pos)) != 0) {
                    comb += characters[pos];
                }
            }
            combinations.Add(comb);
        }
        return combinations;
    }
    */

    public CombinationIterator(string characters, int combinationLength) {
        combinationList = new List<string>();
        CurrentIdx = 0;

        // Generate the list
        int sz = characters.Length;

        for (int mask = 0; mask < (1<<sz); mask++){
            string comb = string.Empty; // Stores a combination
            for (int pos = 0; pos < sz; pos++){
                if((mask & (1 << pos)) != 0) {
                    comb += characters[pos];
                }
            }
            if(comb.Length == combinationLength)
                combinationList.Add(comb);
        }
        combinationList.Sort();

        // Set MaxIdx with list's Length
        MaxIdx = combinationList.Count;
    }

    public string Next() {
        CurrentIdx ++;
        return combinationList[CurrentIdx-1];
    }

    public bool HasNext() {
        return (CurrentIdx != MaxIdx);
    }
    
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
