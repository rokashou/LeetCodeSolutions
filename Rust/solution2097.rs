


struct Solution;
// Hierholzer's Algorithm(iterative)
/*

impl Solution {
    pub fn valid_arrangement(pairs: Vec<Vec<i32>>) -> Vec<Vec<i32>> {
        use std::collections::{HashMap, VecDeque, HashSet};
        let mut adjacency_matrix: HashMap<i32, VecDeque<i32>> = HashMap::new();
        let mut in_degree: HashMap<i32,i32> = HashMap::new();
        let mut out_degree: HashMap<i32,i32> = HashMap::new();

        // Build the adjacency list and track in-degrees and out-degrees
        for pair in &pairs{
            let start = pair[0];
            let end = pair[1];
            adjacency_matrix.entry(start).or_default().push_back(end);
            *out_degree.entry(start).or_insert(0) += 1;
            *in_degree.entry(end).or_insert(0) += 1;
        }

        let mut result_list = Vec::new();

        // Find the start node (out_degree == in_degree + 1)
        let mut start_node = -1;
        for(&node,&out) in &out_degree{
            let in_degree_val = in_degree.get(&node).unwrap_or(&0);
            if out == in_degree_val + 1 {
                start_node = node;
                break;
            }
        }

        // If no such node exists, start from the first pair's first element
        if start_node == -1 {
            start_node = pairs[0][0];
        }

        let mut node_stack = vec![start_node];

        // Iterative DFS using stack
        while let Some(&node) = node_stack.last() {
            if let Some(neighbors) = adjacency_matrix.get_mut(&node) {
                if !neighbors.is_empty(){
                    let next_node = neighbors.pop_front().unwrap();
                    node_stack.push(next_node);
                }else{
                    // No more neighbors to visit, add node to result
                    result_list.push(node);
                    node_stack.pop();
                }
            }else{
                // No neighbors at all, add node to result
                result_list.push(node);
                node_stack.pop();
            }
        }

        // Reverse the result since DFS gives us the path in reverse
        result_list.reverse();

        // Construct the result pairs
        let mut final_result = Vec::new();
        for i in 1..result_list.len() {
            final_result.push(vec![result_list[i-1],result_list[i]]);
        }

        final_result
    }
}

 */

 impl Solution {
    pub fn valid_arrangement(pairs: Vec<Vec<i32>>) -> Vec<Vec<i32>> {
        use std::collections::{HashMap, VecDeque};
        
        let mut adj_list: HashMap<i32, Vec<i32>> = HashMap::with_capacity(pairs.len());
        let mut in_out_deg: HashMap<i32, i32> = HashMap::with_capacity(pairs.len() * 2);
        
        // Build optimized graph
        for pair in &pairs {
            adj_list.entry(pair[0])
                .or_insert_with(Vec::new)
                .push(pair[1]);
            *in_out_deg.entry(pair[0]).or_default() += 1;
            *in_out_deg.entry(pair[1]).or_default() -= 1;
        }
        
        // Find start efficiently
        let start_node = in_out_deg.iter()
            .find(|(_, &deg)| deg == 1)
            .map(|(&node, _)| node)
            .unwrap_or(pairs[0][0]);
        
        let mut path = Vec::with_capacity(pairs.len() + 1);
        let mut stack = vec![start_node];
        
        // Iterative DFS
        while let Some(&current) = stack.last() {
            if let Some(neighbors) = adj_list.get_mut(&current) {
                if let Some(next) = neighbors.pop() {
                    stack.push(next);
                } else {
                    path.push(stack.pop().unwrap());
                }
            } else {
                path.push(stack.pop().unwrap());
            }
        }
        
        // Build result efficiently
        let mut result = Vec::with_capacity(pairs.len());
        for window in path.windows(2).rev() {
            result.push(vec![window[1], window[0]]);
        }
        
        result
    }
}