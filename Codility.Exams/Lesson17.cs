using System;

namespace Codility.Exams
{
    /// <summary>
    /// Dynamic programming
    /// </summary>
    public class Lesson17
    {
        /// <summary>
        /// A game for one player is played on a board consisting of N consecutive squares, numbered from 0 to N − 1. There is a number written on each square. A non-empty zero-indexed array A of N integers contains the numbers written on the squares. Moreover, some squares can be marked during the game.
        ///
        ///At the beginning of the game, there is a pebble on square number 0 and this is the only square on the board which is marked. The goal of the game is to move the pebble to square number N − 1.
        ///
        ///During each turn we throw a six-sided die, with numbers from 1 to 6 on its faces, and consider the number K, which shows on the upper face after the die comes to rest. Then we move the pebble standing on square number I to square number I + K, providing that square number I + K exists. If square number I + K does not exist, we throw the die again until we obtain a valid move. Finally, we mark square number I + K.
        ///
        ///After the game finishes (when the pebble is standing on square number N − 1), we calculate the result. The result of the game is the sum of the numbers written on all marked squares.
        ///
        ///For example, given the following array:
        ///
        ///    A[0] = 1
        ///    A[1] = -2
        ///    A[2] = 0
        ///    A[3] = 9
        ///    A[4] = -1
        ///    A[5] = -2
        ///one possible game could be as follows:
        ///
        ///the pebble is on square number 0, which is marked;
        ///we throw 3; the pebble moves from square number 0 to square number 3; we mark square number 3;
        ///we throw 5; the pebble does not move, since there is no square number 8 on the board;
        ///we throw 2; the pebble moves to square number 5; we mark this square and the game ends.
        ///The marked squares are 0, 3 and 5, so the result of the game is 1 + 9 + (−2) = 8. This is the maximal possible result that can be achieved on this board.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A of N integers, returns the maximal result that can be achieved on the board represented by array A.
        ///
        ///For example, given the array
        ///
        ///    A[0] = 1
        ///    A[1] = -2
        ///    A[2] = 0
        ///    A[3] = 9
        ///    A[4] = -1
        ///    A[5] = -2
        ///the function should return 8, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [2..100,000];
        ///each element of array A is an integer within the range [−10,000..10,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int NumberSolitaire(int[] A)
        {
            int[] maxInt = new int[A.Length];
            maxInt[0] = A[0];
            maxInt[1] = A[0] + A[1];

            for(int i=2; i< A.Length; i++){
                int max = Int32.MinValue;
                for(int j =1; j<=6; j++){
                    if(i-j>=0){
                        max = Math.Max(max, maxInt[i-j]+A[i]);
                    }
                }
                maxInt[i] = max;
            }
            return maxInt[A.Length-1];
        }

        /// <summary>
        /// For a given array A of N integers and a sequence S of N integers from the set {−1, 1}, we define val(A, S) as follows:
        ///
        ///val(A, S) = |sum{ A[i]*S[i] for i = 0..N−1 }|
        ///(Assume that the sum of zero elements equals zero.)
        ///
        ///For a given array A, we are looking for such a sequence S that minimizes val(A,S).m
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given an array A of N integers, computes the minimum value of val(A,S) from all possible values of val(A,S) for all possible sequences S of N integers from the set {−1, 1}.
        ///
        ///For example, given array:
        ///
        ///  A[0] =  1
        ///  A[1] =  5
        ///  A[2] =  2
        ///  A[3] = -2
        ///your function should return 0, since for S = [−1, 1, −1, 1], val(A, S) = 0, which is the minimum possible value.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..20,000];
        ///each element of array A is an integer within the range [−100..100].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinAbsSum(int[] A)
        {
            int[] preSum = new int[A.Length + 1];
        
            for (int i = 1; i < preSum.Length; i++) {
                preSum[i] += preSum[i - 1] + A[i - 1];
            }

            Array.Sort(preSum);
            int min = 2 * 10000 + 1;

            for (int i = 1; i < preSum.Length; i++) {
                int d = preSum[i] - preSum[i - 1];
                if (d < min) {
                    min = d;
                }
            }

            return min;

        }
    }
}
