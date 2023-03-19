/*
Mar 19, 2023 11:36
Runtime 1913 ms, Beats 41.27%
Memory 148 MB, Beats 66.99%
*/

public class WordDictionary {
    // Be a TrieNode, Actually
    private WordDictionary[] children;
    bool isEnd;

    // Initializes the object
    public WordDictionary()
    {
        children = new WordDictionary[26];
        isEnd = false;
    }

    // Adds word to the data structure, it can be matched later.
    public void AddWord(string word)
    {
        WordDictionary node = this;
        foreach (char c in word)
        {
            if (node.children[c - 'a'] == null)
                node.children[c - 'a'] = new WordDictionary();
            node = node.children[c - 'a'];
        }
        node.isEnd = true;
    }

    // Returns true if there is any string in the data structure that
    // matches word or false otherwise.
    // word may contain dots '.' where dots can be matched with any letter.
    public bool Search(string word)
    {
        WordDictionary node = this;
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            if (c == '.')
            {
                foreach (var ch in node.children)
                    if (ch != null && ch.Search(word.Substring(i + 1))) return true;
                return false;
            }
            if (node.children[c - 'a'] == null) return false;
            node = node.children[c - 'a'];

        }
        return node != null && node.isEnd;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
 
