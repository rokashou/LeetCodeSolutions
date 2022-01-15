/*
Runtime: 212 ms, faster than 70.00% of C# online submissions for Jump Game IV.
Memory Usage: 56.7 MB, less than 25.00% of C# online submissions for Jump Game IV.
Uploaded: 01/15/2022 21:15
*/

public class Solution {
    public int MinJumps(int[] arr) {
        int n = arr.Length;
        if (n <= 1) { return 0; }

        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++){
            if(graph.ContainsKey(arr[i])){
                graph[arr[i]].Add(i);
            }else{
                List<int> tmpList = new List<int>();
                tmpList.Add(i);
                graph.Add(arr[i], tmpList);
            }
        }

        HashSet<int> curs = new HashSet<int>(); // store layers from start
        curs.Add(0); 
        HashSet<int> visited = new HashSet<int>();
        visited.Add(0);
        visited.Add(n - 1);
        int step = 0;

        HashSet<int> other = new HashSet<int>(); // store layers from end
        other.Add(n - 1);

        // when current layer exists
        while(curs.Count > 0){
            // search from the side with fewer nodes
            if(curs.Count > other.Count){
                HashSet<int> tmp = curs;
                curs = other;
                other = tmp;
            }

            HashSet<int> nex = new HashSet<int>();

            // iterate the layer
            foreach(var node in curs){
                // check same value
                var nodes = graph[arr[node]];
                foreach(var child in nodes){
                    if(other.Contains(child)){
                        return step + 1;
                    }
                    if(!visited.Contains(child)){
                        visited.Add(child);
                        nex.Add(child);
                    }
                }

                // clear the list to prevent redundant search
                graph[arr[node]].Clear();

                // check neighbors
                if(other.Contains(node + 1) || other.Contains(node -1)) {
                    return step + 1;
                }

                if(node + 1 < n && !visited.Contains(node + 1)){
                    visited.Add(node + 1);
                    nex.Add(node + 1);
                }
                if(node -1 >= 0 && !visited.Contains(node - 1)){
                    visited.Add(node - 1);
                    nex.Add(node - 1);
                }

            }

            curs = nex;
            step++;
        }

        return -1;
    }
}

