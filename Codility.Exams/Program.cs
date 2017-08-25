using System;

namespace Codility.Exams
{
    public class Program
    {
        static void Main(string[] args)
        {


            var methodBinayGap = BinaryGap(20); // Lesson 01 - Iterations

            var methodOddOccurrencesInArray = OddOccurrencesInArray(new[] { 9, 3, 9, 3, 9, 7, 9, 7 }); // Lesson 02 - Arrays
            var methodCyclicRotation = CyclicRotation(new[] { 3, 8, 9, 7, 6 }, 0); // Lesson 02 - Arrays

            var methodPermMissingElem = PermMissingElem(new[] { 2, 3, 1, 5 }); // Lesson 03 - Time Complexity
            var methodFrogJmp = FrogJmp(10, 69, 20); // Lesson 03 - Time Complexity
            var methodTapeEquilibrium = TapeEquilibrium(new[] { 3, 1, 2, 4, 3 }); // Lesson 03 - Time Complexity

            var methodMissingInteger = MissingInteger(new[] { -1, -2, 0, 1, 2, 4, 5, 13 }); // Lesson 04 - Counting Elements
            var methodPermCheck = PermCheck(new[] { 4, 1, 3 }); // Lesson 04 - Counting Elements
            var methodFrogRiverOne = FrogRiverOne(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }); // Lesson 04 - Counting Elements
            var methodMaxCounters = MaxCounters(5, new[] {3, 4, 4, 6, 1, 4, 4}); // Lesson 04 - Counting Elements

            Console.WriteLine(string.Join(",", methodMaxCounters));
            //Console.WriteLine(methodFrogRiverOne);
            //Console.WriteLine(stopWatch.Elapsed.Milliseconds.ToString("D5"));
            Console.ReadLine();
        }

        /// <summary>
        /// Lesson 01 - Iterations
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
        ///
        ///For example, number 9 has binary representation 1001 and contains a binary gap of length 2. 
        ///The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
        ///The number 20 has binary representation 10100 and contains one binary gap of length 1. 
        ///The number 15 has binary representation 1111 and has no binary gaps.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int N); }
        ///that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.
        ///
        ///For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..2,147,483,647].
        ///Complexity:
        ///
        ///expected worst-case time complexity is O(log(N));
        ///expected worst-case space complexity is O(1).
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int BinaryGap(int N)
        {
            return BinaryGap(N, 0, 0, 0);
        }

        public static int BinaryGap(int N, int counter, int max, int index)
        {
            if (N == 0)
                return max;

            if (N % 2 == 0 && index == 0)
            {
                index = 0;
            }
            else if (N % 2 == 0)
            {
                counter++;
            }
            else
            {
                max = Math.Max(counter, max);
                index++;
                counter = 0;
            }

            N = N / 2;
            return BinaryGap(N, counter, max, index);
        }



        /// <summary>
        /// Lesson 02 - Arrays
        /// A non-empty zero-indexed array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
        ///
        ///For example, in array A such that:
        ///
        ///  A[0] = 9  A[1] = 3  A[2] = 9
        ///  A[3] = 3  A[4] = 9  A[5] = 7
        ///  A[6] = 9
        ///the elements at indexes 0 and 2 have value 9,
        ///the elements at indexes 1 and 3 have value 3,
        ///the elements at indexes 4 and 6 have value 9,
        ///the element at index 5 has value 7 and is unpaired.
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
        ///
        ///For example, given array A such that:
        ///
        ///  A[0] = 9  A[1] = 3  A[2] = 9
        ///  A[3] = 3  A[4] = 9  A[5] = 7
        ///  A[6] = 9
        ///the function should return 7, as explained in the example above.
        ///
        ///Assume that:
        ///
        ///N is an odd integer within the range [1..1,000,000];
        ///each element of array A is an integer within the range [1..1,000,000,000];
        ///all but one of the values in A occur an even number of times.
        ///Complexity:
        ///
        ///expected worst-case time complexity is O(N);
        ///expected worst-case space complexity is O(1), beyond input storage (not counting the storage required for input arguments).
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int OddOccurrencesInArray(int[] A)
        {
            Array.Sort(A);
            int i;
            int res = 0;
            for (i = 0; i < A.Length; i++)
            {
                res = res ^ A[i];
            }
            return res;
        }


        /// <summary>
        /// Lesson 02 - Arrays
        /// A zero-indexed array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is also moved to the first place.
        ///
        ///For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7]. The goal is to rotate array A K times; that is, each element of A will be shifted to the right by K indexes.
        ///
        ///Write a function:
        ///
        ///class Solution { public int[] solution(int[] A, int K); }
        ///that, given a zero-indexed array A consisting of N integers and an integer K, returns the array A rotated K times.
        ///
        ///For example, given array A = [3, 8, 9, 7, 6] and K = 3, the function should return [9, 7, 6, 3, 8].
        ///
        ///Assume that:
        ///
        ///N and K are integers within the range [0..100];
        ///each element of array A is an integer within the range [−1,000..1,000].
        /// </summary>
        /// <param name="A"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] CyclicRotation(int[] A, int k)
        {
            int[] b = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
            {
                b[(i + k) % A.Length] = A[i];
            }

            return b;
        }
        


        /// <summary>
        /// Lesson 03 - Time Complexity
        /// A zero-indexed array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
        ///
        ///Your goal is to find that missing element.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A, returns the value of the missing element.
        ///
        ///For example, given array A such that:
        ///
        ///  A[0] = 2
        ///  A[1] = 3
        ///  A[2] = 1
        ///  A[3] = 5
        ///the function should return 4, as it is the missing element.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..100,000];
        ///the elements of A are all distinct;
        ///each element of array A is an integer within the range [1..(N + 1)].
        ///Complexity:
        ///
        ///expected worst-case time complexity is O(N);
        ///expected worst-case space complexity is O(1), beyond input storage (not counting the storage required for input arguments).
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int PermMissingElem(int[] A)
        {
            var n = A.Length;
            long sum = 0;
            for (var i = 0; i < n; i++)
            {
                sum = sum + A[i];
            }

            return (int)(PermSum(n + 1) - sum);
        }
        private static long PermSum(long n)
        {
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// Lesson 03 - Time Complexity
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        ///
        ///Count the minimal number of jumps that the small frog must perform to reach its target.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int X, int Y, int D); }
        ///that, given three integers X, Y and D, returns the minimal number of jumps from position X to a position equal to or greater than Y.
        ///
        ///For example, given:
        ///
        ///  X = 10
        ///  Y = 85
        ///  D = 30
        ///the function should return 3, because the frog will be positioned as follows:
        ///
        ///after the first jump, at position 10 + 30 = 40
        ///after the second jump, at position 10 + 30 + 30 = 70
        ///after the third jump, at position 10 + 30 + 30 + 30 = 100
        ///Assume that:
        ///
        ///X, Y and D are integers within the range [1..1,000,000,000];
        ///X ≤ Y.
        ///Complexity:
        ///
        ///expected worst-case time complexity is O(1);
        ///expected worst-case space complexity is O(1).
        ///
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        private static int FrogJmp(int X, int Y, int D)
        {
            return (Y - X + (D - 1)) / D;

            //return (Y - X) % D > 0 ? (Y - X) / D + 1 : (Y - X) / D;

            //double x = X;
            //double y = Y;
            //return Convert.ToInt32(Math.Ceiling((y-x)/D));
        }

        /// <summary>
        /// Lesson 03 - Time Complexity
        /// A non-empty zero-indexed array A consisting of N integers is given. Array A represents numbers on a tape.
        ///
        ///Any integer P, such that 0 &lt; P &lt; N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
        ///
        ///The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
        ///
        ///In other words, it is the absolute difference between the sum of the first part and the sum of the second part.
        ///
        ///For example, consider array A such that:
        ///
        ///  A[0] = 3
        ///  A[1] = 1
        ///  A[2] = 2
        ///  A[3] = 4
        ///  A[4] = 3
        ///We can split this tape in four places:
        ///
        ///P = 1, difference = |3 − 10| = 7 
        ///P = 2, difference = |4 − 9| = 5 
        ///P = 3, difference = |6 − 7| = 1 
        ///P = 4, difference = |10 − 3| = 7 
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A of N integers, returns the minimal difference that can be achieved.
        ///
        ///For example, given:
        ///
        ///  A[0] = 3
        ///  A[1] = 1
        ///  A[2] = 2
        ///  A[3] = 4
        ///  A[4] = 3
        ///the function should return 1, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [2..100,000];
        ///each element of array A is an integer within the range [−1,000..1,000].
        ///Complexity:
        ///
        ///expected worst-case time complexity is O(N);
        ///expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int TapeEquilibrium(int[] A)
        {
            //int sum1 = 0;
            //int sum2 = A.Sum();
            //int minDiff = int.MaxValue;
            //for (int p = 0; p < A.Length - 1; p++)
            //{
            //    sum1 += A[p];
            //    sum2 -= A[p];
            //    int diff = sum2 - sum1;
            //    minDiff = Math.Min(minDiff, Math.Abs(diff));
            //}
            //return minDiff;

            var minimum = int.MaxValue;
            var lValue = 0;
            var rValue = 0;
            for (var P = 1; P < A.Length; P++)
            {
                var first = P == 1;
                lValue = lValue + A[P - 1];
                if (first)
                {
                    for (var i = P; i < A.Length; i++)
                    {
                        rValue = rValue + A[i];
                    }
                }
                else
                {
                    rValue = rValue - A[P - 1];
                }

                var minimumTemp = Math.Abs(lValue - rValue);
                if (minimum > minimumTemp)
                {
                    minimum = minimumTemp;
                }
            }

            return minimum;
        }



        /// <summary>
        /// Lesson 04 - Counting Elements
        /// This is a demo task.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
        ///
        ///For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
        ///
        ///For another example, given A = [1, 2, 3], the function should return 4.
        ///
        ///Given A = [−1, −3], the function should return 1.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [−1,000,000..1,000,00
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MissingInteger(int[] A)
        {
            Array.Sort(A);
            int minValue = 1;

            foreach (var minValueFor in A)
            {
                if (minValueFor == minValue)
                    minValue++;
            }

            return minValue;
        }

        /// <summary>
        /// Lesson 04 - Counting Elements
        /// A non-empty zero-indexed array A consisting of N integers is given.
        ///
        ///A permutation is a sequence containing each element from 1 to N once, and only once.
        ///
        ///For example, array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 1
        ///    A[2] = 3
        ///    A[3] = 2
        ///is a permutation, but array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 1
        ///    A[2] = 3
        ///is not a permutation, because value 2 is missing.
        ///
        ///The goal is to check whether array A is a permutation.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A, returns 1 if array A is a permutation and 0 if it is not.
        ///
        ///For example, given array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 1
        ///    A[2] = 3
        ///    A[3] = 2
        ///the function should return 1.
        ///
        ///Given array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 1
        ///    A[2] = 3
        ///the function should return 0.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [1..1,000,000,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int PermCheck(int[] A)
        {
            Array.Sort(A);

            for (var i = 0; i < A.Length; i++)
            {
                if (i + 1 != A[i])
                    return 0;
            }

            return 1;
        }

        /// <summary>
        /// Lesson 04 - Counting Elements
        /// A small frog wants to get to the other side of a river. The frog is initially located on one bank of the river (position 0) and wants to get to the opposite bank (position X+1). Leaves fall from a tree onto the surface of the river.
        ///
        ///You are given a zero-indexed array A consisting of N integers representing the falling leaves. A[K] represents the position where one leaf falls at time K, measured in seconds.
        ///
        ///The goal is to find the earliest time when the frog can jump to the other side of the river. The frog can cross only when leaves appear at every position across the river from 1 to X (that is, we want to find the earliest moment when all the positions from 1 to X are covered by leaves). You may assume that the speed of the current in the river is negligibly small, i.e. the leaves do not change their positions once they fall in the river.
        ///
        ///For example, you are given integer X = 5 and array A such that:
        ///
        ///  A[0] = 1
        ///  A[1] = 3
        ///  A[2] = 1
        ///  A[3] = 4
        ///  A[4] = 2
        ///  A[5] = 3
        ///  A[6] = 5
        ///  A[7] = 4
        ///In second 6, a leaf falls into position 5. This is the earliest time when leaves appear in every position across the river.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int X, int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers and integer X, returns the earliest time when the frog can jump to the other side of the river.
        ///
        ///If the frog is never able to jump to the other side of the river, the function should return −1.
        ///
        ///For example, given X = 5 and array A such that:
        ///
        ///  A[0] = 1
        ///  A[1] = 3
        ///  A[2] = 1
        ///  A[3] = 4
        ///  A[4] = 2
        ///  A[5] = 3
        ///  A[6] = 5
        ///  A[7] = 4
        ///the function should return 6, as explained above.
        ///
        ///Assume that:
        ///
        ///N and X are integers within the range [1..100,000];
        ///each element of array A is an integer within the range [1..X].
        /// </summary>
        /// <param name="X"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FrogRiverOne(int X, int[] A)
        {
            var result = -1;
            if (X > A.Length)
                return result;

            var B = new int[A.Length];
            var count = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] > X) continue;
                if (B[A[i] - 1] != 0) continue;
                B[A[i] - 1] = A[i];
                count++;

                if (count == X)
                {
                    return i;
                }
            }

            return result;
        }

        /// <summary>
        /// Lesson 04 - Counting Elements
        /// You are given N counters, initially set to 0, and you have two possible operations on them:
        ///
        ///increase(X) − counter X is increased by 1,
        ///max counter − all counters are set to the maximum value of any counter.
        ///A non-empty zero-indexed array A of M integers is given. This array represents consecutive operations:
        ///
        ///if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
        ///if A[K] = N + 1 then operation K is max counter.
        ///For example, given integer N = 5 and array A such that:
        ///
        ///    A[0] = 3
        ///    A[1] = 4
        ///    A[2] = 4
        ///    A[3] = 6
        ///    A[4] = 1
        ///    A[5] = 4
        ///    A[6] = 4
        ///the values of the counters after each consecutive operation will be:
        ///
        ///    (0, 0, 1, 0, 0)
        ///    (0, 0, 1, 1, 0)
        ///    (0, 0, 1, 2, 0)
        ///    (2, 2, 2, 2, 2)
        ///    (3, 2, 2, 2, 2)
        ///    (3, 2, 2, 3, 2)
        ///    (3, 2, 2, 4, 2)
        ///The goal is to calculate the value of every counter after all operations.
        ///
        ///Write a function:
        ///
        ///class Solution { public int[] solution(int N, int[] A); }
        ///that, given an integer N and a non-empty zero-indexed array A consisting of M integers, returns a sequence of integers representing the values of the counters.
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
        ///    A[1] = 4
        ///    A[2] = 4
        ///    A[3] = 6
        ///    A[4] = 1
        ///    A[5] = 4
        ///    A[6] = 4
        ///the function should return [3, 2, 2, 4, 2], as explained above.
        ///
        ///Assume that:
        ///
        ///N and M are integers within the range [1..100,000];
        ///each element of array A is an integer within the range [1..N + 1].
        /// </summary>
        /// <param name="N"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] MaxCounters(int N, int[] A)
        {
            var B = new int[N];
            var maxCounter = 0;
            var counter = 0;
            for (var i = 0; i < A.Length; i++) {
                if (A[i] < N + 1) {
                    B[A[i] - 1]++;
                    if (maxCounter < B[A[i] - 1]) {
                        maxCounter = B[A[i] - 1];
                    }
                
                }
                else if (maxCounter != counter) {
                    for (var j = 0; j < B.Length; j++) {
                        B[j] = maxCounter;
                    }
                
                    counter = maxCounter;
                }
            }
            return B;
        }
    }
}
