/*
    Runtime: 309 ms, faster than 15.00% of C# online submissions for Jump Game IV.
    Memory Usage: 57.9 MB, less than 5.00% of C# online submissions for Jump Game IV.
    Uploaded: 01/15/2022 20:56
*/

public class Solution {
    public int MinJumps(int[] arr) {
        int n = arr.Length;
        if (n <= 1) { return 0; }

        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < n;i++){
            if(graph.ContainsKey(arr[i])) {
                graph[arr[i]].Add(i);
            }else{
                List<int> targetList = new List<int>();
                targetList.Add(i);
                graph.Add(arr[i], targetList);
            }
        }

        List<int> curs = new List<int>(); // store current layer
        curs.Add(0);
        HashSet<int> visited = new HashSet<int>();
        int step = 0;

        // when current layer exists
        while(curs.Count > 0){
            List<int> nex = new List<int>();

            // iterate the layer
            foreach(int node in curs){
                // check if reached end
                if(node == (n - 1)){
                    return step;
                }

                // check same value
                var nodes = graph[arr[node]];
                foreach(int child in nodes){
                    if(!visited.Contains(child)){
                        visited.Add(child);
                        nex.Add(child);
                    }
                }

                // clear the list to prevent redundant search
                graph[arr[node]].Clear();

                // check neighbors
                if(node + 1 < n && !visited.Contains(node + 1)){
                    visited.Add(node + 1);
                    nex.Add(node + 1);
                }
                if(node - 1 >= 0 && !visited.Contains(node - 1)){
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

