using System;

namespace Codility.Exams
{
    /// <summary>
    /// Sieve of Eratosthenes
    /// </summary>
    public class Lesson11
    {
        /// <summary>
        ///  Lesson 11 - Sieve of Eratosthenes
        /// A prime is a positive integer X that has exactly two distinct divisors: 1 and X. The first few prime integers are 2, 3, 5, 7, 11 and 13.
        ///
        ///A semiprime is a natural number that is the product of two (not necessarily distinct) prime numbers. The first few semiprimes are 4, 6, 9, 10, 14, 15, 21, 22, 25, 26.
        ///
        ///You are given two non-empty zero-indexed arrays P and Q, each consisting of M integers. These arrays represent queries about the number of semiprimes within specified ranges.
        ///
        ///Query K requires you to find the number of semiprimes within the range (P[K], Q[K]), where 1 ≤ P[K] ≤ Q[K] ≤ N.
        ///
        ///For example, consider an integer N = 26 and arrays P, Q such that:
        ///
        ///    P[0] = 1    Q[0] = 26
        ///    P[1] = 4    Q[1] = 10
        ///    P[2] = 16   Q[2] = 20
        ///The number of semiprimes within each of these ranges is as follows:
        ///
        ///(1, 26) is 10,
        ///(4, 10) is 4,
        ///(16, 20) is 0.
        ///Write a function:
        ///
        ///class Solution { public int[] solution(int N, int[] P, int[] Q); }
        ///that, given an integer N and two non-empty zero-indexed arrays P and Q consisting of M integers, returns an array consisting of M elements specifying the consecutive answers to all the queries.
        ///
        ///For example, given an integer N = 26 and arrays P, Q such that:
        ///
        ///    P[0] = 1    Q[0] = 26
        ///    P[1] = 4    Q[1] = 10
        ///    P[2] = 16   Q[2] = 20
        ///the function should return the values [10, 4, 0], as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..50,000];
        ///M is an integer within the range [1..30,000];
        ///each element of arrays P, Q is an integer within the range [1..N];
        ///P[i] ≤ Q[i].
        /// </summary>
        /// <param name="N"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public static int[] CountSemiprimes(int N, int[] P, int[] Q)
        {
            var m = P.Length;
            var M = new int[m];

            var f = new int[N + 1];
            var i = 2;
            while (i * i <= N)
            {
                if (f[i] == 0)
                {
                    var k = i * i;
                    while (k <= N)
                    {
                        if (f[k] == 0)
                        {
                            f[k] = i;
                        }
                        k += i;
                    }
                }
                i++;
            }

            var semi = new int[N + 1];

            var sum = 0;
            for (var k = 1; k <= N; k++)
            {
                if (f[k] != 0)
                {
                    var b = k / f[k];
                    if (f[b] == 0)
                    {
                        sum++;
                    }
                }
                semi[k] = sum;
            }

            for (var mi = 0; mi < m; mi++)
            {
                var p = P[mi];
                var q = Q[mi];
                M[mi] = semi[q] - semi[p - 1];
            }

            return M;
        }

        /// <summary>
        /// You are given a non-empty zero-indexed array A consisting of N integers.
        ///
        ///For each number A[i] such that 0 ≤ i &lt; N, we want to count the number of elements of the array that are not the divisors of A[i]. We say that these elements are non-divisors.
        ///
        ///For example, consider integer N = 5 and array A such that:
        ///
        ///    A[0] = 3
        ///    A[1] = 1
        ///    A[2] = 2
        ///    A[3] = 3
        ///    A[4] = 6
        ///For the following elements:
        ///
        ///A[0] = 3, the non-divisors are: 2, 6,
        ///A[1] = 1, the non-divisors are: 3, 2, 3, 6,
        ///A[2] = 2, the non-divisors are: 3, 3, 6,
        ///A[3] = 3, the non-divisors are: 2, 6,
        ///A[4] = 6, there aren't any non-divisors.
        ///Write a function:
        ///
        ///class Solution { public int[] solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns a sequence of integers representing the amount of non-divisors.
        ///
        ///The sequence should be returned as:
        ///
        ///a structure Results (in C), or
        ///a vector of integers (in C++), or
        ///a record Results (in Pascal), or
        ///an array of integers (in any other programming language).
        ///For example, given:
        ///
        ///    A[0] = 3
        ///    A[1] = 1
        ///    A[2] = 2
        ///    A[3] = 3
        ///    A[4] = 6
        ///the function should return [2, 4, 3, 2, 0], as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..50,000];
        ///each element of array A is an integer within the range [1..2 * N].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] CountNonDivisible(int[] A)
        {
            int N = A.Length;
            int max = N * 2 + 1;

            var c = new int[max + 1];
            for (int i = 0; i < N; i++)
            {
                c[A[i]]++;
            }

            var result = new int[N];
            for (int i = 0; i < N; i++)
            {
                int r = 0;
                int x = A[i];
                int target = (int)Math.Sqrt(x);
                for (int d = 1; d <= target; d++)
                {
                    if (x % d == 0)
                    {
                        r += c[d];
                        if (x / d != d)
                        {
                            r += c[x / d];
                        }
                    }
                }
                result[i] = N - r;
            }

            return result;
        }
    }
}
