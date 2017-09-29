﻿namespace Codility.Exams
{
    /// <summary>
    /// Greedy algorithms
    /// </summary>
    public class Lesson16
    {
        /// <summary>
        /// Located on a line are N segments, numbered from 0 to N − 1, whose positions are given in zero-indexed arrays A and B. For each I (0 ≤ I &lt; N) the position of segment I is from A[I] to B[I] (inclusive). The segments are sorted by their ends, which means that B[K] ≤ B[K + 1] for K such that 0 ≤ K &lt; N − 1.
        ///
        ///Two segments I and J, such that I ≠ J, are overlapping if they share at least one common point. In other words, A[I] ≤ A[J] ≤ B[I] or A[J] ≤ A[I] ≤ B[J].
        ///
        ///We say that the set of segments is non-overlapping if it contains no two overlapping segments. The goal is to find the size of a non-overlapping set containing the maximal number of segments.
        ///
        ///For example, consider arrays A, B such that:
        ///
        ///    A[0] = 1    B[0] = 5
        ///    A[1] = 3    B[1] = 6
        ///    A[2] = 7    B[2] = 8
        ///    A[3] = 9    B[3] = 9
        ///    A[4] = 9    B[4] = 10
        ///The segments are shown in the figure below.
        ///
        ///
        ///
        ///The size of a non-overlapping set containing a maximal number of segments is 3. For example, possible sets are {0, 2, 3}, {0, 2, 4}, {1, 2, 3} or {1, 2, 4}. There is no non-overlapping set with four segments.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A, int[] B); }
        ///that, given two zero-indexed arrays A and B consisting of N integers, returns the size of a non-overlapping set containing a maximal number of segments.
        ///
        ///For example, given arrays A, B shown above, the function should return 3, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..30,000];
        ///each element of arrays A, B is an integer within the range [0..1,000,000,000];
        ///A[I] ≤ B[I], for each I (0 ≤ I &lt; N);
        ///B[K] ≤ B[K + 1], for each K (0 ≤ K &lt; N − 1).
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int MaxNonoverlappingSegments(int[] A, int[] B)
        {
            int len = A.Length;
            if(len == 0)
                return 0;
            int last = B[len-1]+1;
            int count = 0;
            for(int i=len-1; i >= 0; i--)
                if(B[i] < last){
                    count++;
                    last = A[i];
                }
                else if(A[i] > last)
                    last = A[i];
            return count;
        }

        /// <summary>
        /// There are N ropes numbered from 0 to N − 1, whose lengths are given in a zero-indexed array A, lying on the floor in a line. For each I (0 ≤ I &lt; N), the length of rope I on the line is A[I].
        ///
        ///We say that two ropes I and I + 1 are adjacent. Two adjacent ropes can be tied together with a knot, and the length of the tied rope is the sum of lengths of both ropes. The resulting new rope can then be tied again.
        ///
        ///For a given integer K, the goal is to tie the ropes in such a way that the number of ropes whose length is greater than or equal to K is maximal.
        ///
        ///For example, consider K = 4 and array A such that:
        ///
        ///    A[0] = 1
        ///    A[1] = 2
        ///    A[2] = 3
        ///    A[3] = 4
        ///    A[4] = 1
        ///    A[5] = 1
        ///    A[6] = 3
        ///The ropes are shown in the figure below.
        ///
        ///
        ///
        ///We can tie:
        ///
        ///rope 1 with rope 2 to produce a rope of length A[1] + A[2] = 5;
        ///rope 4 with rope 5 with rope 6 to produce a rope of length A[4] + A[5] + A[6] = 5.
        ///After that, there will be three ropes whose lengths are greater than or equal to K = 4. It is not possible to produce four such ropes.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int K, int[] A); }
        ///that, given an integer K and a non-empty zero-indexed array A of N integers, returns the maximum number of ropes of length greater than or equal to K that can be created.
        ///
        ///For example, given K = 4 and array A such that:
        ///
        ///    A[0] = 1
        ///    A[1] = 2
        ///    A[2] = 3
        ///    A[3] = 4
        ///    A[4] = 1
        ///    A[5] = 1
        ///    A[6] = 3
        ///the function should return 3, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///K is an integer within the range [1..1,000,000,000];
        ///each element of array A is an integer within the range [1..1,000,000,000].
        /// </summary>
        public static int TieRopes(int K, int[] A)
        {
            var counter = 0;
            var len = 0;

            for (var i = 0; i < A.Length; i++)
            {
                len += A[i];
                if (len < K) continue;
                counter++;
                len = 0;
            }

            return counter;
        }
    }
}
