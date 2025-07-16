struct Solution{}

impl Solution {
    pub fn num_submatrix_sum_target(matrix: Vec<Vec<i32>>, target: i32) -> i32 {
        let (m,n) = (matrix.len(), matrix[0].len());
        let mut res = 0;

        for l in 0..n {
            let mut sums = vec![0;105];
            for r in l..n{
                for i in 0..m{
                    sums[i] += matrix[i][r];
                }

                for i in 0..m{
                    let mut sum = 0;
                    for j in i..m{
                        sum += sums[j];
                        if sum == target {
                            res += 1;
                        }
                    }
                }
            }
        }

        res
    }
}