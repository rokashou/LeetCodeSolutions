/*
Runtime: 658 ms, faster than 15.00% of C# online submissions for Course Schedule III.
Memory Usage: 49.3 MB, less than 30.00% of C# online submissions for Course Schedule III.
Uploaded: 06/23/2022 21:16
*/

public class Solution {
    private int CompareCourses(int[] course1, int[] course2)
    {
        if (course1[1] == course2[1])
            return course1[0] - course2[0];
        return course1[1] - course2[1];
    }

    public int ScheduleCourse(int[][] courses)
    {
        Array.Sort(courses, CompareCourses);

        int time = 0, count = 0;

        for(int i = 0; i < courses.Length; i++) {
            if(time+courses[i][0] <= courses[i][1])
            {
                time += courses[i][0];
                courses[count++] = courses[i];
            }
            else
            {
                int max_i = i;
                for(int j = 0; j < count; ++j)
                {
                    if(courses[j][0] > courses[max_i][0])  max_i = j;
                }
                if (courses[max_i][0] > courses[i][0])
                {
                    time += courses[i][0] - courses[max_i][0];
                    courses[max_i] = courses[i];
                }
            }
        }

        return count;


    }
}
