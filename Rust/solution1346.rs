/*
Dec 02, 2024 00:25

Runtime 0ms, Beats 100.00%
Memory 2.25MB, Beats 50.00%
*/


impl Solution {
    pub fn check_if_exist(arr: Vec<i32>) -> bool {
        use std::collections::HashSet;

        let mut hashtable:HashSet<i32> = HashSet::new();

        for v in arr {
            if hashtable.contains(&(v * 2)) {
                return true;
            }
            if v % 2 == 0 && hashtable.contains(&(v/2)) {
                return true;
            }
            hashtable.insert(v);
        }

        return false;        
    }
}
