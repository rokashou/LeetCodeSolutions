/*
Runtime: 1320 ms, faster than 82.35% of C# online submissions for Prefix and Suffix Search.
Memory Usage: 122.6 MB, less than 5.88% of C# online submissions for Prefix and Suffix Search.
Uploaded: 06/18/2022 18:34
*/

public class WordFilter {
    TrieNode trie;

    public WordFilter(string[] words)
    {
        trie = new TrieNode();
        for(int weight = 0; weight < words.Length; ++weight)
        {
            string word = words[weight] + "{";
            for(int i = 0; i < word.Length; ++i)
            {
                TrieNode cur = trie;
                cur.weight = weight;
                for(int j = i; j < 2 * word.Length - 1; ++j)
                {
                    int k = word[j % word.Length] - 'a';
                    if (cur.children[k] == null)
                        cur.children[k] = new TrieNode();
                    cur = cur.children[k];
                    cur.weight = weight;
                }
            }
        }
    }

    public int F(string prefix, string suffix)
    {
        TrieNode cur = trie;
        foreach(var letter in (suffix + '{' + prefix).ToCharArray())
        {
            if (cur.children[letter - 'a'] == null) return -1;
            cur = cur.children[letter - 'a'];
        }
        return cur.weight;
    }

    public class TrieNode
    {
        public TrieNode[] children;
        public int weight;
        public TrieNode()
        {
            children = new TrieNode[27];
            weight = 0;
        }
    }
}

/**
 * Your WordFilter object will be instantiated and called as such:
 * WordFilter obj = new WordFilter(words);
 * int param_1 = obj.F(prefix,suffix);
 */
 
