struct Solution{}

impl Solution {
    pub fn rotate_the_box(box_grid: Vec<Vec<char>>) -> Vec<Vec<char>> {
        let m = box_grid.len();
        let n = box_grid[0].len();
        let mut result = vec![vec!['.'; m]; n];

        // Apply gravity and rotate the grid
        for i in 0..m {
            let mut lowest_row_with_empty_cell = n as isize - 1;

            for j in (0..n).rev() {
                if box_grid[i][j] == '#' {
                    result[lowest_row_with_empty_cell as usize][m - i - 1] = '#';
                    lowest_row_with_empty_cell -= 1;
                }

                if box_grid[i][j] == '*' {
                    result[j][m - i - 1] = '*';
                    lowest_row_with_empty_cell = j as isize - 1;
                }
            }
        }

        result
    }
}
