using System;
using System.Linq;

namespace Codility.Exams
{
    /// <summary>
    /// Binary search algorithm
    /// </summary>
    public class Lesson14
    {
        /// <summary>
        /// You are given integers K, M and a non-empty zero-indexed array A consisting of N integers. Every element of the array is not greater than M.
        ///
        ///You should divide this array into K blocks of consecutive elements. The size of the block is any integer between 0 and N. Every element of the array should belong to some block.
        ///
        ///The sum of the block from X to Y equals A[X] + A[X + 1] + ... + A[Y]. The sum of empty block equals 0.
        ///
        ///The large sum is the maximal sum of any block.
        ///
        ///For example, you are given integers K = 3, M = 5 and array A such that:
        ///
        ///  A[0] = 2
        ///  A[1] = 1
        ///  A[2] = 5
        ///  A[3] = 1
        ///  A[4] = 2
        ///  A[5] = 2
        ///  A[6] = 2
        ///The array can be divided, for example, into the following blocks:
        ///
        ///[2, 1, 5, 1, 2, 2, 2], [], [] with a large sum of 15;
        ///[2], [1, 5, 1, 2], [2, 2] with a large sum of 9;
        ///[2, 1, 5], [], [1, 2, 2, 2] with a large sum of 8;
        ///[2, 1], [5, 1], [2, 2, 2] with a large sum of 6.
        ///The goal is to minimize the large sum. In the above example, 6 is the minimal large sum.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int K, int M, int[] A); }
        ///that, given integers K, M and a non-empty zero-indexed array A consisting of N integers, returns the minimal large sum.
        ///
        ///For example, given K = 3, M = 5 and array A such that:
        ///
        ///  A[0] = 2
        ///  A[1] = 1
        ///  A[2] = 5
        ///  A[3] = 1
        ///  A[4] = 2
        ///  A[5] = 2
        ///  A[6] = 2
        ///the function should return 6, as explained above.
        ///
        ///Assume that:
        ///
        ///N and K are integers within the range [1..100,000];
        ///M is an integer within the range [0..10,000];
        ///each element of array A is an integer within the range [0..M].
        /// </summary>
        /// <param name="K"></param>
        /// <param name="M"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinMaxDivision(int K, int M, int[] A)
        {
            int l = A.Max();
            M = l * A.Length;

            while (l < M)
            {
                int t = (l + M) / 2;

                int i = 0, j = 0, s = 0;
                while (i < A.Length && j < K)
                {
                    s += A[i];
                    if (s > t)
                    {
                        s = A[i];
                        j++;
                    }
                    i++;
                }

                if (j == K)
                    l = t + 1;
                else
                    M = t;
            }
            return M;
        }

        /// <summary>
        /// You are given two non-empty zero-indexed arrays A and B consisting of N integers. These arrays represent N planks. More precisely, A[K] is the start and B[K] the end of the K−th plank.
        ///
        ///Next, you are given a non-empty zero-indexed array C consisting of M integers. This array represents M nails. More precisely, C[I] is the position where you can hammer in the I−th nail.
        ///
        ///We say that a plank (A[K], B[K]) is nailed if there exists a nail C[I] such that A[K] ≤ C[I] ≤ B[K].
        ///
        ///The goal is to find the minimum number of nails that must be used until all the planks are nailed. In other words, you should find a value J such that all planks will be nailed after using only the first J nails. More precisely, for every plank (A[K], B[K]) such that 0 ≤ K &lt; N, there should exist a nail C[I] such that I &lt; J and A[K] ≤ C[I] ≤ B[K].
        ///
        ///For example, given arrays A, B such that:
        ///
        ///    A[0] = 1    B[0] = 4
        ///    A[1] = 4    B[1] = 5
        ///    A[2] = 5    B[2] = 9
        ///    A[3] = 8    B[3] = 10
        ///four planks are represented: [1, 4], [4, 5], [5, 9] and [8, 10].
        ///
        ///Given array C such that:
        ///
        ///    C[0] = 4
        ///    C[1] = 6
        ///    C[2] = 7
        ///    C[3] = 10
        ///    C[4] = 2
        ///if we use the following nails:
        ///
        ///0, then planks [1, 4] and [4, 5] will both be nailed.
        ///0, 1, then planks [1, 4], [4, 5] and [5, 9] will be nailed.
        ///0, 1, 2, then planks [1, 4], [4, 5] and [5, 9] will be nailed.
        ///0, 1, 2, 3, then all the planks will be nailed.
        ///Thus, four is the minimum number of nails that, used sequentially, allow all the planks to be nailed.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A, int[] B, int[] C); }
        ///that, given two non-empty zero-indexed arrays A and B consisting of N integers and a non-empty zero-indexed array C consisting of M integers, returns the minimum number of nails that, used sequentially, allow all the planks to be nailed.
        ///
        ///If it is not possible to nail all the planks, the function should return −1.
        ///
        ///For example, given arrays A, B, C such that:
        ///
        ///    A[0] = 1    B[0] = 4
        ///    A[1] = 4    B[1] = 5
        ///    A[2] = 5    B[2] = 9
        ///    A[3] = 8    B[3] = 10
        ///
        ///    C[0] = 4
        ///    C[1] = 6
        ///    C[2] = 7
        ///    C[3] = 10
        ///    C[4] = 2
        ///the function should return 4, as explained above.
        ///
        ///Assume that:
        ///
        ///N and M are integers within the range [1..30,000];
        ///each element of arrays A, B, C is an integer within the range [1..2*M];
        ///A[K] ≤ B[K].
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static int NailingPlanks(int[] A, int[] B, int[] C)
        {
            int N = A.Length;
            int M = C.Length;
            int lwBits = 15;
            
            var c = C.ToList();
            for (var i = 0; i < c.Count; i++)
            {
                c[i] = c[i] << lwBits | i;
            }
            c.Sort();

            int result = 0;
            
            for (int i = 0; i < N && result < M; i++)
            {
                int minNail = M;
                
                int j1 = c.BinarySearch(A[i] << lwBits);
                j1 = j1 < 0 ? ~j1 : j1;
                
                int j2 = c.BinarySearch(B[i] + 1 << lwBits);
                j2 = j2 < 0 ? ~j2 : j2;
                
                for (int k = j1; k < j2 && minNail > result; k++)
                {
                    minNail = Math.Min(minNail, c[k] % (1 << lwBits));
                }
                
                result = Math.Max(result, minNail);
            }
            
            return result < M ? result + 1 : -1;
        }
    }
}
