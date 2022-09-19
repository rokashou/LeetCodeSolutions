/*
Runtime: 1445 ms, faster than 51.96% of C# online submissions for Palindrome Pairs.
Memory Usage: 62.1 MB, less than 76.47% of C# online submissions for Palindrome Pairs.
Uploaded: 09/19/2022 12:09
*/

public class Solution {
    private bool IsPalindrome(string word, int l, int r)
    {
        while (l < r && word[l] == word[r])
        {
            l++; r--;
        }
        return l >= r;
    }

    public IList<IList<int>> PalindromePairs(string[] words)
    {
        Dictionary<string, int> wordMap = new Dictionary<string, int>();
        IList<IList<int>> result = new List<IList<int>>();
        //HashSet<int> set = new HashSet<int>();

        int emptyindex = -1;
        List<int> indexOfPalindromes = new();
        for(int i = 0; i < words.Length; i++)
        {
            if (words[i] == "")
            {
                emptyindex = i;
                continue;
            }

            if (IsPalindrome(words[i], 0, words[i].Length - 1))
                indexOfPalindromes.Add(i);

            string str = words[i];
            var strArray = str.ToCharArray();
            Array.Reverse(strArray);
            string reversedStr = new string(strArray);
            wordMap[reversedStr] = i;
        }

        for(int i = 0; i < words.Length; ++i)
        {
            for(int cut = 0; cut < words[i].Length; ++cut)
            {
                if (IsPalindrome(words[i], cut, words[i].Length-1))
                {
                    string rightStr = words[i].Substring(0, cut);
                    if(wordMap.ContainsKey(rightStr) && wordMap[rightStr] != i)
                    {
                        result.Add(new List<int>() { i, wordMap[rightStr] });
                    }
                }

                if (IsPalindrome(words[i],0,cut-1))
                {
                    string leftStr = words[i].Substring(cut);
                    if (wordMap.ContainsKey(leftStr) && wordMap[leftStr] != i)
                    {
                        result.Add(new List<int>() { wordMap[leftStr], i });
                    }
                }
            }
        }

        if(emptyindex != -1)
        {
            foreach(var x in indexOfPalindromes)
            {
                result.Add(new List<int>() { emptyindex, x });
                result.Add(new List<int>() { x, emptyindex });
            }
        }

        return result;

    }
}
