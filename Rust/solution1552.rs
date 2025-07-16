struct Solution{}

impl Solution {
    pub fn max_distance(mut position: Vec<i32>, m: i32) -> i32 {
        position.sort_unstable();
        let first = position[0];
        let max_diff = position.iter().last().unwrap() - first;

        let mut low = 1;
        let mut high = max_diff / (m-1);
        while(low <= high){
            let mid = low + (high - low) / 2 + 1;
            if position.iter().fold((1, first), |(acc, prev), &i| if i - prev >= mid {(acc + 1, i)} else {(acc, prev)}).0 >= m {
                low = mid;
            }else{
                high = mid - 1;
            }
        }

        low
    }
}
