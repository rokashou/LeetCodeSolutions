struct Solution;

impl Solution {
    pub fn results_array(nums: Vec<i32>, k: i32) -> Vec<i32> {
        if k == 1 {
            return nums.clone(); // If k is 1, every single element is a valid subarray
        }

        let length: usize = nums.len();
        let array_max_size = length + 1 - (k as usize);
        let mut result: Vec<i32> = vec![-1; array_max_size]; // Initialize results with -1
        let mut consecutive_count = 1; // count of consecutive elements

        for index in 0..length -1 {
            if nums[index] + 1 == nums[index+1] {
                consecutive_count += 1;
            }else {
                consecutive_count = 1; // Reset count if not consecutive
            }

            // If we have enough consecutive elements, update the result
            if consecutive_count >= k {
                result[index+2 - (k as usize)] = nums[index+1];
            }
        }

        result

    }
}