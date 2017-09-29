using System;

namespace Codility.Exams
{
    /// <summary>
    /// Caterpillar method
    /// </summary>
    public class Lesson15
    {
        /// <summary>
        /// A non-empty zero-indexed array A consisting of N numbers is given. The array is sorted in non-decreasing order. The absolute distinct count of this array is the number of distinct absolute values among the elements of the array.
        ///
        ///For example, consider array A such that:
        ///
        ///  A[0] = -5
        ///  A[1] = -3
        ///  A[2] = -1
        ///  A[3] =  0
        ///  A[4] =  3
        ///  A[5] =  6
        ///The absolute distinct count of this array is 5, because there are 5 distinct absolute values among the elements of this array, namely 0, 1, 3, 5 and 6.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N numbers, returns absolute distinct count of array A.
        ///
        ///For example, given array A such that:
        ///
        ///  A[0] = -5
        ///  A[1] = -3
        ///  A[2] = -1
        ///  A[3] =  0
        ///  A[4] =  3
        ///  A[5] =  6
        ///the function should return 5, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [−2,147,483,648..2,147,483,647];
        ///array A is sorted in non-decreasing order.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int AbsDistinct(int[] A)
        {
            var count = 1;
            var i = 0;
            var j = A.Length - 1;
            var intMin = int.MinValue;

            if (A[i] == intMin) {
                count++;
                while (i < A.Length && A[i] == intMin) {
                    i++;
                }
            }

            for (var k = 0; k < A.Length; k++) {
                if (A[k] < 0) {
                    A[k] = -A[k];
                } else {
                    break;
                }
            }

            var left = A[i];
            var right = A[j];
            var current = Math.Max(left, right);
            while (j >= i) {
                left = A[i];
                right = A[j];
                if (current == left) {
                    i++;
                    continue;
                }
                if (current == right) {
                    j--;
                    continue;
                }

                if (left >= right) {
                    current = left;
                    i++;
                } else {
                    current = right;
                    j--;
                }

                count++;
            }
            return count;
        }

        /// <summary>
        /// An integer M and a non-empty zero-indexed array A consisting of N non-negative integers are given. All integers in array A are less than or equal to M.
        ///
        ///A pair of integers (P, Q), such that 0 ≤ P ≤ Q &lt; N, is called a slice of array A. The slice consists of the elements A[P], A[P + 1], ..., A[Q]. A distinct slice is a slice consisting of only unique numbers. That is, no individual number occurs more than once in the slice.
        ///
        ///For example, consider integer M = 6 and array A such that:
        ///
        ///    A[0] = 3
        ///    A[1] = 4
        ///    A[2] = 5
        ///    A[3] = 5
        ///    A[4] = 2
        ///There are exactly nine distinct slices: (0, 0), (0, 1), (0, 2), (1, 1), (1, 2), (2, 2), (3, 3), (3, 4) and (4, 4).
        ///
        ///The goal is to calculate the number of distinct slices.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int M, int[] A); }
        ///that, given an integer M and a non-empty zero-indexed array A consisting of N integers, returns the number of distinct slices.
        ///
        ///If the number of distinct slices is greater than 1,000,000,000, the function should return 1,000,000,000.
        ///
        ///For example, given integer M = 6 and array A such that:
        ///
        ///    A[0] = 3
        ///    A[1] = 4
        ///    A[2] = 5
        ///    A[3] = 5
        ///    A[4] = 2
        ///the function should return 9, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///M is an integer within the range [0..100,000];
        ///each element of array A is an integer within the range [0..M].
        /// </summary>
        /// <param name="M"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int CountDistinctSlices(int M, int[] A)
        {
            var n = A.Length;
            var lastOccurIndeces = new int[M + 1];
            
            for (var i = 0; i < M + 1; i++)
                lastOccurIndeces[i] = -1;

            var startIndex = 0;
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                var current = A[i];
                if (lastOccurIndeces[current] >= startIndex)
                    startIndex = lastOccurIndeces[current] + 1;

                count += 1 + (i - startIndex);
                if (count > 1e9)
                    return (int)1e9;

                lastOccurIndeces[current] = i;
            }

            return count;
        }

        /// <summary>
        /// A zero-indexed array A consisting of N integers is given. A triplet (P, Q, R) is triangular if it is possible to build a triangle with sides of lengths A[P], A[Q] and A[R]. In other words, triplet (P, Q, R) is triangular if 0 ≤ P &lt; Q &lt; R &lt; N and:
        ///
        ///A[P] + A[Q] &gt; A[R],
        ///A[Q] + A[R] &gt; A[P],
        ///A[R] + A[P] &gt; A[Q].
        ///For example, consider array A such that:
        ///
        ///  A[0] = 10    A[1] = 2    A[2] = 5
        ///  A[3] = 1     A[4] = 8    A[5] = 12
        ///There are four triangular triplets that can be constructed from elements of this array, namely (0, 2, 4), (0, 2, 5), (0, 4, 5), and (2, 4, 5).
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A consisting of N integers, returns the number of triangular triplets in this array.
        ///
        ///For example, given array A such that:
        ///
        ///  A[0] = 10    A[1] = 2    A[2] = 5
        ///  A[3] = 1     A[4] = 8    A[5] = 12
        ///the function should return 4, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..1,000];
        ///each element of array A is an integer within the range [1..1,000,000,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int CountTriangles(int[] A)
        {
            int count = 0;
            Array.Sort(A);
            for(int i=0; i < A.Length-2; i++){
                int left = i+1;
                int right = i+2;
                while(left < A.Length-1){
                    if(right < A.Length && A[i] + A[left] > A[right])
                        right++;
                    else{
                        count += right - left - 1;
                        left++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Let A be a non-empty zero-indexed array consisting of N integers.
        ///
        ///The abs sum of two for a pair of indices (P, Q) is the absolute value |A[P] + A[Q]|, for 0 ≤ P ≤ Q &lt; N.
        ///
        ///For example, the following array A:
        ///
        ///  A[0] =  1
        ///  A[1] =  4
        ///  A[2] = -3
        ///has pairs of indices (0, 0), (0, 1), (0, 2), (1, 1), (1, 2), (2, 2). 
        ///The abs sum of two for the pair (0, 0) is A[0] + A[0] = |1 + 1| = 2. 
        ///The abs sum of two for the pair (0, 1) is A[0] + A[1] = |1 + 4| = 5. 
        ///The abs sum of two for the pair (0, 2) is A[0] + A[2] = |1 + (−3)| = 2. 
        ///The abs sum of two for the pair (1, 1) is A[1] + A[1] = |4 + 4| = 8. 
        ///The abs sum of two for the pair (1, 2) is A[1] + A[2] = |4 + (−3)| = 1. 
        ///The abs sum of two for the pair (2, 2) is A[2] + A[2] = |(−3) + (−3)| = 6. 
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns the minimal abs sum of two for any pair of indices in this array.
        ///
        ///For example, given the following array A:
        ///
        ///  A[0] =  1
        ///  A[1] =  4
        ///  A[2] = -3
        ///the function should return 1, as explained above.
        ///
        ///Given array A:
        ///
        ///  A[0] = -8
        ///  A[1] =  4
        ///  A[2] =  5
        ///  A[3] =-10
        ///  A[4] =  3
        ///the function should return |(−8) + 5| = 3.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinAbsSumOfTwo(int[] A)
        {
            //Array.Sort(A, (a1, a2) => Math.Abs(a1).CompareTo(Math.Abs(a2)));
            //var result = Math.Abs(2 * A[0]);
            //for (var i = 1; i < A.Length; i++)
            //{
            //    result = Math.Min(result, Math.Abs(A[i - 1] + A[i]));
            //}
            //return result;

            //Array.Sort(A);
            //int min = int.MaxValue;
            //for(int i=0; i < A.Length; i++){
            //    int pos = Array.BinarySearch(A,i,A.Length,-A[i]);
            //    if(pos >= 0)
            //        return 0;
            //    pos = -pos-1;
            //    if(pos < A.Length)
            //        min = Math.Min(min,Math.Abs(A[pos]+A[i]));
            //    if(pos-1 > -1)
            //        min = Math.Min(min,Math.Abs(A[pos-1]+A[i]));
            //}
            //return min;

            //Array.Sort(A);
            //int i = 0;
            //int j = A.Length - 1;
            //int min = Int32.MaxValue;;
            //while(i <= j) {
            //    int dif = A[i] + A[j];
            //    if (dif == 0) return 0;
            //    if (dif < 0) {
            //        i++;
            //        dif =- dif;
            //    } else {
            //        j--;
            //    }
            //    if (min > dif) min = dif;
            //}
            //return min;


            //Array.Sort(A);

            //int tail = A.Length - 1;
            //int min = Math.Abs(A[0] + A[tail]);

            //for (int head = 0; head <= tail; head++) {
            //    while (head <= tail) {
            //        int value = Math.Abs(A[head] + A[tail]);
            //        int next = Math.Abs(A[head] + A[Math.Max(0, tail - 1)]);

            //        min = Math.Min(value, min);

            //        if (next <= value) {
            //            tail--;
            //        } else {
            //            break;
            //        }
            //    }
            //}

            //return min;


            //Array.Sort(A);
            //int result = Math.Abs(A[0] + A[A.Length-1]);
            //for (int i = 0, j = A.Length - 1; i < j && result > 0; result = Math.Min(result, Math.Abs(A[i] + A[j]))) {
            //    if (-A[i] > A[j]){ i++; }
            //    else { j--; }
            //}
            //return result;

            Array.Sort(A);
            int i = 0;
            int N = A.Length;
            while (i < N && (A[i] < 0))
            {
                ++i;
            }
            if (i == 0)
            {
                return 2 * A[0];
            }
            if (i == N)
            {
                return - 2 * A[N - 1];
            }
            int j = i - 1;
            int abssum = Math.Min(2 * A[i], - 2 * A[i - 1]);
            while (j >= 0 && i < N && (abssum > 0))
            {
                abssum = Math.Min(abssum, Math.Abs(A[i] + A[j]));
                if (A[i] + A[j] < 0)
                    i++;
                else
                    j--;

            }
            return abssum;



        }
    }
}
