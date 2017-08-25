using System;

namespace Codility.Exams
{
    /// <summary>
    /// Fibonacci numbers
    /// </summary>
    public class Lesson13
    {
        /// <summary>
        /// The Fibonacci sequence is defined using the following recursive formula:
        ///
        ///    F(0) = 0
        ///    F(1) = 1
        ///    F(M) = F(M - 1) + F(M - 2) if M &gt;= 2
        ///A small frog wants to get to the other side of a river. The frog is initially located at one bank of the river (position −1) and wants to get to the other bank (position N). The frog can jump over any distance F(K), where F(K) is the K-th Fibonacci number. Luckily, there are many leaves on the river, and the frog can jump between the leaves, but only in the direction of the bank at position N.
        ///
        ///The leaves on the river are represented in a zero-indexed array A consisting of N integers. Consecutive elements of array A represent consecutive positions from 0 to N − 1 on the river. Array A contains only 0s and/or 1s:
        ///
        ///0 represents a position without a leaf;
        ///1 represents a position containing a leaf.
        ///The goal is to count the minimum number of jumps in which the frog can get to the other side of the river (from position −1 to position N). The frog can jump between positions −1 and N (the banks of the river) and every position containing a leaf.
        ///
        ///For example, consider array A such that:
        ///
        ///    A[0] = 0
        ///    A[1] = 0
        ///    A[2] = 0
        ///    A[3] = 1
        ///    A[4] = 1
        ///    A[5] = 0
        ///    A[6] = 1
        ///    A[7] = 0
        ///    A[8] = 0
        ///    A[9] = 0
        ///    A[10] = 0
        ///The frog can make three jumps of length F(5) = 5, F(3) = 2 and F(5) = 5.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A consisting of N integers, returns the minimum number of jumps by which the frog can get to the other side of the river. If the frog cannot reach the other side of the river, the function should return −1.
        ///
        ///For example, given:
        ///
        ///    A[0] = 0
        ///    A[1] = 0
        ///    A[2] = 0
        ///    A[3] = 1
        ///    A[4] = 1
        ///    A[5] = 0
        ///    A[6] = 1
        ///    A[7] = 0
        ///    A[8] = 0
        ///    A[9] = 0
        ///    A[10] = 0
        ///the function should return 3, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..100,000];
        ///each element of array A is an integer that can have one of the following values: 0, 1.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FibFrog(int[] A)
        {
            int[] f = new int[30];
            f[0] = 1; f[1] = 2;
            for (int i = 2; i < f.Length; ++i) f[i] = f[i-1] + f[i-2];
            int[] mins = new int[A.Length+1];
            for (int i = 0; i < mins.Length; ++i) {
                if (i < A.Length && A[i] == 0) {
                    mins[i] = -1;
                    continue;
                }
                int min = int.MaxValue;
                for (int j = f.Length-1; j >= 0; --j) {
                    int k = i - f[j];
                    if (k < -1) continue;
                    if (k == -1) {
                        min = 1;
                        break;
                    }
                    if (mins[k] < 0) continue;
                    int newMin = mins[k] + 1;
                    if (newMin < min) min = newMin;
                }
                if (min != int.MaxValue) mins[i] = min;
                else mins[i] = -1;
            }    
        
            return mins[A.Length];
        }

        /// <summary>
        /// You have to climb up a ladder. The ladder has exactly N rungs, numbered from 1 to N. With each step, you can ascend by one or two rungs. More precisely:
        ///
        ///with your first step you can stand on rung 1 or 2,
        ///if you are on rung K, you can move to rungs K + 1 or K + 2,
        ///finally you have to stand on rung N.
        ///Your task is to count the number of different ways of climbing to the top of the ladder.
        ///
        ///For example, given N = 4, you have five different ways of climbing, ascending by:
        ///
        ///1, 1, 1 and 1 rung,
        ///1, 1 and 2 rungs,
        ///1, 2 and 1 rung,
        ///2, 1 and 1 rungs, and
        ///2 and 2 rungs.
        ///Given N = 5, you have eight different ways of climbing, ascending by:
        ///
        ///1, 1, 1, 1 and 1 rung,
        ///1, 1, 1 and 2 rungs,
        ///1, 1, 2 and 1 rung,
        ///1, 2, 1 and 1 rung,
        ///1, 2 and 2 rungs,
        ///2, 1, 1 and 1 rungs,
        ///2, 1 and 2 rungs, and
        ///2, 2 and 1 rung.
        ///The number of different ways can be very large, so it is sufficient to return the result modulo 2P, for a given integer P.
        ///
        ///Write a function:
        ///
        ///class Solution { public int[] solution(int[] A, int[] B); }
        ///that, given two non-empty zero-indexed arrays A and B of L integers, returns an array consisting of L integers specifying the consecutive answers; position I should contain the number of different ways of climbing the ladder with A[I] rungs modulo 2B[I].
        ///
        ///For example, given L = 5 and:
        ///
        ///    A[0] = 4   B[0] = 3
        ///    A[1] = 4   B[1] = 2
        ///    A[2] = 5   B[2] = 4
        ///    A[3] = 5   B[3] = 3
        ///    A[4] = 1   B[4] = 1
        ///the function should return the sequence [5, 1, 8, 0, 1], as explained above.
        ///
        ///Assume that:
        ///
        ///L is an integer within the range [1..50,000];
        ///each element of array A is an integer within the range [1..L];
        ///each element of array B is an integer within the range [1..30].
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] Ladder(int[] A, int[] B)
        {
            int max = 0;
            for (int i = 0; i < A.Length; i++) {
                max = Math.Max(A[i], max);
            }

            max += 2;

            double[] fib = new double[max];

            fib[0] = 1;
            fib[1] = 1;
            for (int i = 2; i < max; i++) {
                fib[i] = (fib[i - 1] + fib[i - 2]) % (1 << 30);
            }

            int[] res = new int[A.Length];
            for (int i = 0; i < A.Length; i++) {
                res[i] = (int) (fib[A[i]] % (1 << B[i]));
            }

            return res;
        }
    }
}
