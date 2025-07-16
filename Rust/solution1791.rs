struct Solution{}

impl Solution {
    pub fn find_center(edges: Vec<Vec<i32>>) -> i32 {
        if let Some(x) = edges[1].iter().position(|x| *x == edges[0][0]){
            edges[1][x]
        } else {
            edges[0][1]
        }
    }
}