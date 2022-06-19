/*
Runtime: 815 ms, faster than 11.57% of C# online submissions for Search Suggestions System.
Memory Usage: 58.7 MB, less than 23.14% of C# online submissions for Search Suggestions System.
Uploaded: 06/19/2022 21:55
With Official Solution2: Trie + DFS
*/

public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        Trie trie = new Trie();
        List<IList<string>> result = new List<IList<string>>();
        foreach(var w in products)
        {
            trie.Insert(w);
        }
        string prefix = String.Empty;
        foreach(var c in searchWord)
        {
            prefix += c;
            result.Add(trie.GetWordsStartingWith(prefix));
        }
        return result;
    }

    class Trie
    {
        // Node definition of a Trie
        class Node
        {
            public bool isWord = false;
            public List<Node> children = new List<Node>(new Node[26]);
        }

        Node Root;
        List<string> _resultBuffer;

        // Runs a DFS on Trie starting with given prefix and adds all the words in the resultBuffer, limiting result size to 3
        void DfsWithPrefix(Node curr, string word)
        {
            if(_resultBuffer.Count == 3)
            {
                return;
            }
            if (curr.isWord)
            {
                _resultBuffer.Add(word);
            }

            // Run DFS on all possible paths.
            for(char c = 'a'; c <= 'z'; c++)
            {
                if(curr.children[c-'a']!= null)
                {
                    DfsWithPrefix(curr.children[c - 'a'], word + c);
                }
            }
        }

        public Trie()
        {
            Root = new Node();
        }

        public void Insert(string s)
        {
            Node _curr = Root;
            foreach(var c in s.ToCharArray())
            {
                if(_curr.children[c-'a'] == null)
                {
                    _curr.children[c - 'a'] = new Node();
                }
                _curr = _curr.children[c - 'a'];
            }

            _curr.isWord = true;
        }

        public List<string> GetWordsStartingWith(string prefix)
        {
            Node _curr = Root;
            _resultBuffer = new List<string>();

            // Move curr to the end of prefix in its trie representation.
            foreach(var c in prefix)
            {
                if (_curr.children[c - 'a'] == null) return _resultBuffer;
                _curr = _curr.children[c - 'a'];
            }
            DfsWithPrefix(_curr, prefix);
            return _resultBuffer;
        }
    }
}
