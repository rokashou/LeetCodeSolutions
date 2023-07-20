/*
Jul 20, 2023 21:00
Runtime 149 ms Beats 77.41%
Memory 45.9 MB Beats 95.19%
*/

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> st = new Stack<int>();

        for(int i = 0; i < asteroids.Length; i++) {
            bool flag = true;
            while(st.Count > 0 && (st.Peek() > 0 && asteroids[i] < 0)) {
                // If the top asteriod in the stack is smaller, then it will explode.
                // Hence pop it from the stack, also continue with the next asteroid in the stack.
                if (Math.Abs(st.Peek()) < Math.Abs(asteroids[i])) {
                    st.Pop();
                    continue;
                }
                // If both asteroids have the same size, then both asteroids will explode.
                // Pop the asteroid from the stack; also, we won't push the current asteroid to the stack.
                else if (Math.Abs(st.Peek()) == Math.Abs(asteroids[i]))
                {
                    st.Pop();
                }

                // If we reach here, the current asteroid will be destroyed
                // Hence, we should not add it to the stack
                flag = false;
                break;
            }

            if (flag) {
                st.Push(asteroids[i]);
            }
        }

        // Add the asteroids from the stack to the vector in the reverse order.
        int[] remainingAsteroids = new int[st.Count];
        for(int i = remainingAsteroids.Length - 1; i >= 0; i--) {
            remainingAsteroids[i] = st.Pop();
        }

        return remainingAsteroids;
    }
}
