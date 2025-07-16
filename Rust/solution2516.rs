struct Solution;

impl Solution {
    pub fn take_characters(s: String, k: i32) -> i32 {
		let n = s.len();
        let mut count = [0; 3];

		// Count total occurrences
		for c in s.chars() {
			count[(c as u8 - b'a') as usize]+=1;
		}

		// Check if we have enough characters
		for i in 0..3 {
			if count[i] < k { return -1;}
		}

		let mut window = [0; 3];
		let mut left = 0;
		let mut max_window = 0;
		let s_bytes = s.as_bytes(); // Convert to bytes for indexing

		// Find the longest window that leaves k of each character outside
		for right in 0..n {
			window[(s_bytes[right] - b'a') as usize] += 1;

			// Shrink window if we take too many characters
			while left <= right 
				&& (count[0]-window[0] < k 
					|| count[1] - window[1] < k 
					|| count[2] - window[2] < k)
			{
				window[(s_bytes[left] - b'a') as usize] -= 1;
				left += 1;
			}

			max_window = max_window.max(right - left + 1);
		}
		

		(n as i32) - max_window as i32
    }
}

