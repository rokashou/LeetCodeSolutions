    // 220ms 70.3MB
    
    // The Official Solution
    public class Trie 
    {
        class TrieNode 
        {
            private TrieNode[] links;
            private const int R = 26;
            private bool _isEnd=false;
            public TrieNode(){
                links = new TrieNode[R];
            }
            public bool ContainsKey(char ch) {
                return links[ch - 'a'] != null;
            }
            public TrieNode GetTrieNode(char ch){
                return links[ch-'a'];
            }
            public void Put(char ch, TrieNode node){
                links[ch - 'a'] = node;
            }
            public void SetEnd() {
                _isEnd = true;
            }
            public bool IsEnd(){
                return _isEnd;
            }
        }

        private TrieNode root;

        public Trie() {
            root = new TrieNode();
        }

        public void Insert(string word){
            TrieNode node = root;
            for(int i=0;i<word.Length;i++){
                char currentChar = word[i];
                if(!node.ContainsKey(currentChar)) {
                    node.Put(currentChar,new TrieNode());
                }
                node=node.GetTrieNode(currentChar);
            }
            node.SetEnd();
        }

        private TrieNode SearchPrefix(string word){
            TrieNode node = root;
            for(int i=0;i<word.Length;i++){
                char curLetter = word[i];
                if(node.ContainsKey(curLetter)){
                    node = node.GetTrieNode(curLetter);
                }
                else{
                    return null;
                }
            }
            return node;
        }

        public bool Search(string word){
            TrieNode node = SearchPrefix(word);
            return node != null && node.IsEnd();
        }

        public bool StartsWith(string prefix){
            TrieNode node = SearchPrefix(prefix);
            return node != null;
        }
    }
