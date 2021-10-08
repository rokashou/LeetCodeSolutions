    public class Trie {
        private HashSet<string> StoredWords;
        private int MaxLength;

        // Initializes the trie object
        public Trie() {
            StoredWords = new HashSet<string>();
            MaxLength=0;
        }
        
        // Inserts the string *word* into the trie.
        public void Insert(string word) {
            if(!StoredWords.Contains(word)) {
                StoredWords.Add(word);
                if(word.Length > MaxLength) MaxLength = word.Length;
            }
        }

        // Returns *true* if the string *word* is in the trie.
        public bool Search(string word) {
            return StoredWords.Contains(word);
        }
        
        // Returns *true* if there is a previously inserted 
        // string *word* that has the prefix *prefix*, and *false* 
        // otherwise.
        public bool StartsWith(string prefix) {
            if(MaxLength < prefix.Length) return false;

            foreach(string sub in StoredWords)
            {
                if(sub.Length >= prefix.Length && sub.Substring(0,prefix.Length).Equals(prefix)){
                    return true;
                }
            }
            return false;
        }
    }
    
