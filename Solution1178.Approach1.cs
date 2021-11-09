// Approach 1: bitmask
// Uploaded: 11/10/2021 01:23
// Runtime: 176 ms, faster than 100.00% of C# online submissions for Number of Valid Words for Each Puzzle.
// Memory Usage: 54.9 MB, less than 25.00% of C# online submissions for Number of Valid Words for Each Puzzle.

public class Solution {
    private int bitmask(in string word) {
        // Build a bitmask of chars to represent each word
        // the build in std::bitset in C++ alse works
        int mask = 0;
        foreach(var ch in word)
        {
            mask |= 1 << (ch - 'a');
        }
        return mask;
    }


    public IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
    {
        Dictionary<int, int> wordCount = new Dictionary<int, int>();

        foreach(var word in words)
        {
            int mask = bitmask(word);
            if(wordCount.TryGetValue(mask,out int value))
            {
                wordCount.Remove(mask);
                wordCount.Add(mask, value + 1);
            }
            else
            {
                wordCount.Add(mask, 1);
            }
        }

        List<int> result = new List<int>(); 

        foreach(var puzzle in puzzles)
        {
            int first = 1 << (puzzle[0] - 'a');
            int count = wordCount.GetValueOrDefault(first);

            // Make bitmask but ignore the first character since it must always be there.
            int mask = bitmask(puzzle.Substring(1));

            // iterate over the submask
            for(int submask = mask; submask != 0; submask = (submask-1) & mask)
            {
                count += wordCount.GetValueOrDefault(submask | first); // add first character
            }
            result.Add(count);
        }

        return result;
    }

}
