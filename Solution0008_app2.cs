/*
Runtime: 68 ms, faster than 87.21% of C# online submissions for String to Integer (atoi).
Memory Usage: 38.6 MB, less than 35.59% of C# online submissions for String to Integer (atoi).
Uploaded: 01/14/2022 23:19
*/



public class Solution {
    enum State { q0, q1, q2, qd };

    class StateMachine
    {
        // Store current state value.
        private State currentState;
        // Store result formed and it's sign.
        private int result, sign;

        public StateMachine()
        {
            currentState = State.q0;
            result = 0;
            sign = 1;
        }

        // Transition to state q1.
        private void toStateQ1(char ch)
        {
            sign = (ch == '-') ? -1 : 1;
            currentState = State.q1;
        }

        // Transition to state q2.
        private void toStateQ2(int digit)
        {
            currentState = State.q2;
            appendDigit(digit);
        }

        // Transition to dead state qd.
        private void toStateQd()
        {
            currentState = State.qd;
        }

        // Append digit to result, if out of range return clamped value.
        private void appendDigit(int digit)
        {
            if ((result > int.MaxValue / 10) ||
               (result == int.MaxValue / 10 && digit > int.MaxValue % 10))
            {
                if (sign == 1)
                {
                    // if sign is 1, clamp result to INT_MAX.
                    result = int.MaxValue;
                }
                else
                {
                    // if sign is -1, clamp result to INT_MIN.
                    result = int.MinValue;
                    sign = 1;
                }

                // When the 32-bit int range is exceeded, a dead state is reached.
                toStateQd();
            }
            else
            {
                result = 10 * result + digit;
            }
        }

        // Change state based on current input character.
        public void transition(char ch)
        {
            if (currentState == State.q0)
            {
                // Beginning state to the string (or some whitespaces are skipped).
                if (ch == ' ')
                {
                    // Current character is a whitespaces.
                    // We stay in same state.
                    return;
                }
                else if (ch == '-' || ch == '+')
                {
                    toStateQ1(ch);
                }
                else if (char.IsDigit(ch))
                {
                    // Current character is a digit.
                    toStateQ2(ch - '0');
                }
                else
                {
                    // Current character is not a space/sign/digit.
                    // Reached a dead state.
                    toStateQd();
                }
            }
            else if (currentState == State.q1 || currentState == State.q2)
            {
                // Previous character was a sign or digit.
                if (char.IsDigit(ch))
                {
                    toStateQ2(ch - '0');
                }
                else
                {
                    // current character is not a digit.
                    // reached a dead state.
                    toStateQd();
                }
            }
        }

        // return the final result formed with it's sign.
        public int getInteger()
        {
            return sign * result;
        }

        // Get current state.
        public State getState(){
            return currentState;
        }
    }

    public int MyAtoi(string s)
    {
        StateMachine Q = new StateMachine();

        for (int i = 0; i < s.Length && Q.getState() != State.qd; i++){
            Q.transition(s[i]);
        }

        return Q.getInteger();
    }

}
