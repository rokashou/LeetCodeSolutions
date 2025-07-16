struct Solution;

impl Solution {
    pub fn decrypt(code: Vec<i32>, k: i32) -> Vec<i32> {
        let n = code.len();
        let mut result = vec![0; n];
        if k == 0 {
            return result;
        }

        // Define the initial window and initial sum
        let (mut start, mut end, mut sum) = if k > 0 {
            (1, k as usize, 0)
        } else {
            (n - k.abs() as usize, n - 1, 0)
        };

        // Calculate the initial sum
        for i in start..=end {
            sum += code[i % n];
        }

        // Slide the window through the array
        for i in 0..n {
            result[i] = sum;
            sum -= code[start % n];
            sum += code[(end + 1) % n];
            start += 1;
            end += 1;
        }

        result
    }
}

/*
#[cfg(test)]
mod tests {

	#[test]
	fn test1() {
		assert!(vec![12,10,16,13], 
			Solution::decrypt(vec![5,7,1,4],3));
	}

	fn test2() {
		assert!(vec![0,0,0,0], 
			Solution::decrypt(vec![1,2,3,4],0));
	}

	fn test3() {
		assert!(vec![12,5,6,13], 
			Solution::decrypt(vec![2,4,9,3],-2));
	}
}
*/
