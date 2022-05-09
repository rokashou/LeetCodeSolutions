/*
    Runtime: 185 ms, faster than 50.97% of C# online submissions for Letter Combinations of a Phone Number.
    Memory Usage: 42.7 MB, less than 32.19% of C# online submissions for Letter Combinations of a Phone Number.
    Uploaded: 05/09/2022 21:41
*/


public class Solution {
    private Dictionary<char,string> GetDigitLettersTable()
    {
        Dictionary<char, string> letters = new Dictionary<char, string>();
        letters.Add('2', "abc");
        letters.Add('3', "def");
        letters.Add('4', "ghi");
        letters.Add('5', "jkl");
        letters.Add('6', "mno");
        letters.Add('7', "pqrs");
        letters.Add('8', "tuv");
        letters.Add('9', "wxyz");
        letters.Add('0', " ");
        return letters;
    }

    private List<string> GenerateStringBySeed(List<string> seeds)
    {
        List<string> k = new List<string>();
        k.Add(string.Empty);
        foreach(string seed in seeds)
        {
            List<string> afterCombind = new List<string>();

            foreach(var c in seed)
            {
                foreach(var s in k)
                {
                    afterCombind.Add(s + c);
                }
            }

            k = afterCombind;
        }
        return k;
    }

    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();
        if (string.IsNullOrEmpty(digits)) return result;
        List<string> seeds = new List<string>();
        Dictionary<char, string> letters=GetDigitLettersTable();
        foreach(var d in digits)
        {
            seeds.Add(letters[d]);
        }
        result = GenerateStringBySeed(seeds);

        return result;
    }
}

