use std::collections::VecDeque;

struct Solution;

impl Solution {
    pub fn shortest_subarray(nums: Vec<i32>, k: i32) -> i32 {
        let n = nums.len();
		let mut prefix_sums = vec![0i64; n+1]; // Prefix sums array with size n+1

		// Calculate prefix sums
		for i in 1..=n {
			prefix_sums[i] = prefix_sums[i-1] + nums[i-1] as i64;
		}
		
		let mut candidate_indices = VecDeque::new();
		let mut shortest_subarray_length = i32::MAX;

		for i in 0..=n{
			// Remove candidates from front of deque where subarray sum meets target
			while let Some(&front) = candidate_indices.front() {
				if prefix_sums[i] - prefix_sums[front] >= (k as i64) {
					shortest_subarray_length = shortest_subarray_length.min((i-front) as i32);
					candidate_indices.pop_front();
				}else{
					break;
				}
			}

			// Maintain monotonicity by removing indices with larger prefix sums
			while let Some(&back) = candidate_indices.back() {
				if prefix_sums[i] <= prefix_sums[back] {
					candidate_indices.pop_back();
				}else{
					break;
				}
			}

			// Add current index to candidates
			candidate_indices.push_back(i);
		}

		// Return -1 if no valid subarray found
		if shortest_subarray_length == i32::MAX {
			-1
		}else{
			shortest_subarray_length
		}

    }
}