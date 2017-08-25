using System;
using System.Collections.Generic;

namespace Codility.Exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            var methodBinayGap = BinaryGap(20); // Lesson 01 - Iterations

            var methodOddOccurrencesInArray = OddOccurrencesInArray(new[] {9, 3, 9, 3, 9, 7, 9, 7}); // Lesson 02 - Arrays
            var methodCyclicRotation = CyclicRotation(new[] {3, 8, 9, 7, 6}, 0); // Lesson 02 - Arrays

            var methodPermMissingElem = PermMissingElem(new[] {2, 3, 1, 5}); // Lesson 03 - Time Complexity
            var methodFrogJmp = FrogJmp(10, 69, 20); // Lesson 03 - Time Complexity
            var methodTapeEquilibrium = TapeEquilibrium(new[] {3, 1, 2, 4, 3}); // Lesson 03 - Time Complexity

            var methodMissingInteger = MissingInteger(new[] {-1, -2, 0, 1, 2, 4, 5, 13}); // Lesson 04 - Counting Elements
            var methodPermCheck = PermCheck(new[] {4, 1, 3}); // Lesson 04 - Counting Elements
            var methodFrogRiverOne = FrogRiverOne(5, new[] {1, 3, 1, 4, 2, 3, 5, 4}); // Lesson 04 - Counting Elements
            var methodMaxCounters = MaxCounters(5, new[] {3, 4, 4, 6, 1, 4, 4}); // Lesson 04 - Counting Elements

            var methodPassingCars = PassingCars(new[] {0, 1, 0, 1, 1}); //Lesson 05 - Prefix Sums
            var methodCountDiv = CountDiv(6, 11, 2); //Lesson 05 - Prefix Sums
            var methodMinAvgTwoSlice = MinAvgTwoSlice(new[] {4, 2, 2, 5, 1, 5, 8}); //Lesson 05 - Prefix Sums
            var methodGenomicRangeQuery = GenomicRangeQuery("CAGCCTA", new[] {2, 5, 0}, new[] {4, 5, 6}); //Lesson 05 - Prefix Sums

            var methodDistinct = Distinct(new[] {2, 1, 1, 2, 3, 1}); // Lesson 06 - Sorting
            var methodTriangle = Triangle(new[] {10, 2, 5, 1, 8, 20}); // Lesson 06 - Sorting
            var methodMaxProductOfThree = MaxProductOfThree(new[] {-3, 1, 2, -2, 5, 6}); // Lesson 06 - Sorting
            var methodNumberOfDiscIntersections = NumberOfDiscIntersections(new[] {1, 5, 2, 1, 4, 0}); // Lesson 06 - Sorting

            var methodBrackets = Brackets("([)()]"); // Lesson 07 Stacks and Queues --> using System.Collections.Generic;
            var methodFish = Fish(new[] {4, 3, 2, 1, 5}, new[] {0, 1, 0, 0, 0}); // Lesson 07 Stacks and Queues --> using System.Collections.Generic;
            var methodStoneWall = StoneWall(new[] {8, 8, 5, 7, 9, 8, 7, 4, 8}); // Lesson 07 Stacks and Queues --> using System.Collections.Generic;
            var methodNesting = Nesting("(()(())())"); // Lesson 07 Stacks and Queues

            var methodEquiLeader = EquiLeader(new[] {4, 3, 4, 4, 4, 2}); // Lesson 08 - Leader 
            var methodDominator = Dominator(new[] {3, 4, 3, 2, 3, -1, 3, 3}); // Lesson 08 - Leader 

            var methodMaxSliceSum = MaxSliceSum(new[] {3, 2, -6, 4, 0}); // Lesson 09 - Maximum slice problem
            var methodMaxDoubleSliceSum = MaxDoubleSliceSum(new[] {3, 2, 6, -1, 4, 5, -1, 2}); // Lesson 09 - Maximum slice problem
            var methodMaxProfit = MaxProfit(new[] {23171, 21011, 21123, 21366, 21013, 21367}); // Lesson 09 - Maximum slice problem

            var methodMinPerimeterRectangle = MinPerimeterRectangle(30); // Lesson 10 - Prime and composite numbers
            var methodCountFactors = CountFactors(24); // Lesson 10 - Prime and composite numbers
            var methodPeaks = Peaks(new[] {1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2}); // Lesson 10 - Prime and composite numbers
            var methodFlags = Flags(new[] {1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2}); // Lesson 10 - Prime and composite numbers

            var methodCountSemiprimes = Lesson11.CountSemiprimes(26, new[] {1, 4, 16}, new[] {26, 10, 20});
            var methodCountNonDivisible = Lesson11.CountNonDivisible(new[] {3, 1, 2, 3, 6});

            var methodChocolatesByNumbers = Lesson12.ChocolatesByNumbers(10, 4);
            var methodCommonPrimeDivisors = Lesson12.CommonPrimeDivisors(new[] {15, 10, 3}, new[] {75, 30, 5});

            var methodFibFrog = Lesson13.FibFrog(new[] {0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0});
            var methodLadder = Lesson13.Ladder(new[] {4, 4, 5, 5, 1}, new[] {3, 2, 4, 3, 1});

            var methodMinMaxDivision = Lesson14.MinMaxDivision(3, 5, new[] {2, 1, 5, 1, 2, 2, 2});
            var methodNailingPlanks = Lesson14.NailingPlanks(new[] {1, 4, 5, 8}, new[] {4, 5, 9, 10}, new[] {4, 6, 7, 10, 2});

            //Console.WriteLine(string.Join(",", methodLadder));
            Console.WriteLine(methodNailingPlanks);
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

            return (int) (PermSum(n + 1) - sum);
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
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] < N + 1)
                {
                    B[A[i] - 1]++;
                    if (maxCounter < B[A[i] - 1])
                    {
                        maxCounter = B[A[i] - 1];
                    }

                }
                else if (maxCounter != counter)
                {
                    for (var j = 0; j < B.Length; j++)
                    {
                        B[j] = maxCounter;
                    }

                    counter = maxCounter;
                }
            }
            return B;
        }



        /// <summary>
        /// Lesson 05 - Prefix Sums
        /// A non-empty zero-indexed array A consisting of N integers is given. The consecutive elements of array A represent consecutive cars on a road.
        ///
        ///Array A contains only 0s and/or 1s:
        ///
        ///0 represents a car traveling east,
        ///1 represents a car traveling west.
        ///The goal is to count passing cars. We say that a pair of cars (P, Q), where 0 ≤ P &lt; Q &lt; N, is passing when P is traveling to the east and Q is traveling to the west.
        ///
        ///For example, consider array A such that:
        ///
        ///  A[0] = 0
        ///  A[1] = 1
        ///  A[2] = 0
        ///  A[3] = 1
        ///  A[4] = 1
        ///We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A of N integers, returns the number of pairs of passing cars.
        ///
        ///The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.
        ///
        ///For example, given:
        ///
        ///  A[0] = 0
        ///  A[1] = 1
        ///  A[2] = 0
        ///  A[3] = 1
        ///  A[4] = 1
        ///the function should return 5, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer that can have one of the following values: 0, 1.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int PassingCars(int[] A)
        {
            long east = 0;
            long passingCars = 0;
            for (var i = 0; (i < A.Length); i++)
            {
                if (A[i] == 0)
                {
                    east++;
                }
                else
                {
                    passingCars += east;
                }

            }
            return passingCars > 1000000000 ? -1 : (int) passingCars;
        }

        /// <summary>
        /// Lesson 05 - Prefix Sum
        /// Write a function:
        ///
        ///class Solution { public int solution(int A, int B, int K); }
        ///that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:
        ///
        ///{ i : A ≤ i ≤ B, i mod K = 0 }
        ///For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.
        ///
        ///Assume that:
        ///
        ///A and B are integers within the range [0..2,000,000,000];
        ///K is an integer within the range [1..2,000,000,000];
        ///A ≤ B.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int CountDiv(int A, int B, int K)
        {
            return B / K - A / K + (A % K == 0 ? 1 : 0);
        }

        /// <summary>
        /// Lesson 05 - Prefix Sum
        /// A non-empty zero-indexed array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P &lt; Q &lt; N, is called a slice of array A (notice that the slice contains at least two elements). The average of a slice (P, Q) is the sum of A[P] + A[P + 1] + ... + A[Q] divided by the length of the slice. To be precise, the average equals (A[P] + A[P + 1] + ... + A[Q]) / (Q − P + 1).
        ///
        ///For example, array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 2
        ///    A[2] = 2
        ///    A[3] = 5
        ///    A[4] = 1
        ///    A[5] = 5
        ///    A[6] = 8
        ///contains the following example slices:
        ///
        ///slice (1, 2), whose average is (2 + 2) / 2 = 2;
        ///slice (3, 4), whose average is (5 + 1) / 2 = 3;
        ///slice (1, 4), whose average is (2 + 2 + 5 + 1) / 4 = 2.5.
        ///The goal is to find the starting position of a slice whose average is minimal.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns the starting position of the slice with the minimal average. If there is more than one slice with a minimal average, you should return the smallest starting position of such a slice.
        ///
        ///For example, given array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 2
        ///    A[2] = 2
        ///    A[3] = 5
        ///    A[4] = 1
        ///    A[5] = 5
        ///    A[6] = 8
        ///the function should return 1, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [2..100,000];
        ///each element of array A is an integer within the range [−10,000..10,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinAvgTwoSlice(int[] A)
        {
            var result = 0;
            if (A.Length == 1 || A.Length == 2) return result;

            var minAvg = Double.MaxValue;
            for (var i = 0; i < A.Length - 2; i++)
            {
                var currAvg = Math.Min((A[i] + A[i + 1]) / 2d, (A[i] + A[i + 1] + A[i + 2]) / 3d);
                if (!(currAvg < minAvg)) continue;
                minAvg = currAvg;
                result = i;
            }
            return (A[A.Length - 2] + A[A.Length - 1]) / 2d < minAvg ? A.Length - 2 : result;
        }

        /// <summary>
        /// Lesson 05 - Prefix Sum
        /// A DNA sequence can be represented as a string consisting of the letters A, C, G and T, which correspond to the types of successive nucleotides in the sequence. Each nucleotide has an impact factor, which is an integer. Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively. You are going to answer several queries of the form: What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?
        ///
        ///The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N-1] consisting of N characters. There are M queries, which are given in non-empty arrays P and Q, each consisting of M integers. The K-th query (0 ≤ K &lt; M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence between positions P[K] and Q[K] (inclusive).
        ///
        ///For example, consider string S = CAGCCTA and arrays P, Q such that:
        ///
        ///    P[0] = 2    Q[0] = 4
        ///    P[1] = 5    Q[1] = 5
        ///    P[2] = 0    Q[2] = 6
        ///The answers to these M = 3 queries are as follows:
        ///
        ///The part of the DNA between positions 2 and 4 contains nucleotides G and C (twice), whose impact factors are 3 and 2 respectively, so the answer is 2.
        ///The part between positions 5 and 5 contains a single nucleotide T, whose impact factor is 4, so the answer is 4.
        ///The part between positions 0 and 6 (the whole string) contains all nucleotides, in particular nucleotide A whose impact factor is 1, so the answer is 1.
        ///Write a function:
        ///
        ///class Solution { public int[] solution(string S, int[] P, int[] Q); }
        ///that, given a non-empty zero-indexed string S consisting of N characters and two non-empty zero-indexed arrays P and Q consisting of M integers, returns an array consisting of M integers specifying the consecutive answers to all queries.
        ///
        ///The sequence should be returned as:
        ///
        ///a Results structure (in C), or
        ///a vector of integers (in C++), or
        ///a Results record (in Pascal), or
        ///an array of integers (in any other programming language).
        ///For example, given the string S = CAGCCTA and arrays P, Q such that:
        ///
        ///    P[0] = 2    Q[0] = 4
        ///    P[1] = 5    Q[1] = 5
        ///    P[2] = 0    Q[2] = 6
        ///the function should return the values [2, 4, 1], as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///M is an integer within the range [1..50,000];
        ///each element of arrays P, Q is an integer within the range [0..N − 1];
        ///P[K] ≤ Q[K], where 0 ≤ K &lt; M;
        ///string S consists only of upper-case English letters A, C, G, T.
        /// </summary>
        /// <param name="S"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public static int[] GenomicRangeQuery(string S, int[] P, int[] Q)
        {
            int aLen = S.Length;
            char[] sAsCharArray = S
                .Replace('A', '1')
                .Replace('C', '2')
                .Replace('G', '3')
                .Replace('T', '4')
                .ToCharArray();

            var A = new int[aLen];
            for (var i = 0; i < aLen; i++)
            {
                A[i] = (int) char.GetNumericValue(sAsCharArray[i]);
            }

            var M = P.Length;
            var result = new int[M];
            var F = new int[aLen + 1, 4];
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;

            for (var i = 0; i < aLen; i++)
            {
                switch (A[i])
                {
                    case 1:
                        sum1 += 1;
                        break;
                    case 2:
                        sum2 += 1;
                        break;
                    case 3:
                        sum3 += 1;
                        break;
                    case 4:
                        sum4 += 1;
                        break;
                }

                F[i + 1, 0] = sum1;
                F[i + 1, 1] = sum2;
                F[i + 1, 2] = sum3;
                F[i + 1, 3] = sum4;
            }

            for (var i = 0; i < M; i++)
            {
                var rangeLow = P[i];
                var rangeHigh = Q[i];

                for (var j = 0; j < 4; j++)
                {
                    if (F[rangeHigh + 1, j] - F[rangeLow, j] <= 0) continue;
                    result[i] = j + 1;
                    break;
                }
            }

            return result;

        }



        /// <summary>
        /// Lesson 06 - Sorting
        /// Write a function
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A consisting of N integers, returns the number of distinct values in array A.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..100,000];
        ///each element of array A is an integer within the range [−1,000,000..1,000,000].
        ///For example, given array A consisting of six elements such that:
        ///
        /// A[0] = 2    A[1] = 1    A[2] = 1
        /// A[3] = 2    A[4] = 3    A[5] = 1
        ///the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Distinct(int[] A)
        {
            var result = 1;

            if (A.Length == 0) return 0;

            Array.Sort(A);

            for (var i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1]) result++;
            }

            return result;
        }

        /// <summary>
        /// Lesson 06 - Sorting
        /// A zero-indexed array A consisting of N integers is given. A triplet (P, Q, R) is triangular if 0 ≤ P &lt; Q &lt; R &lt; N and:
        ///
        ///A[P] + A[Q] &gt; A[R],
        ///A[Q] + A[R] &gt; A[P],
        ///A[R] + A[P] &gt; A[Q].
        ///For example, consider array A such that:
        ///
        ///  A[0] = 10    A[1] = 2    A[2] = 5
        ///  A[3] = 1     A[4] = 8    A[5] = 20
        ///Triplet (0, 2, 4) is triangular.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A consisting of N integers, returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.
        ///
        ///For example, given array A such that:
        ///
        ///  A[0] = 10    A[1] = 2    A[2] = 5
        ///  A[3] = 1     A[4] = 8    A[5] = 20
        ///the function should return 1, as explained above. Given array A such that:
        ///
        ///  A[0] = 10    A[1] = 50    A[2] = 5
        ///  A[3] = 1
        ///the function should return 0.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..100,000];
        ///each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Triangle(int[] A)
        {
            if (A.Length < 3)
                return 0;

            Array.Sort(A);

            for (var i = 0; i < A.Length - 2; i++)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                    return 1;
            }

            return 0;
        }

        /// <summary>
        /// Lesson 06 - Sorting
        /// A non-empty zero-indexed array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P &lt; Q &lt; R &lt; N).
        ///
        ///For example, array A such that:
        ///
        ///  A[0] = -3
        ///  A[1] = 1
        ///  A[2] = 2
        ///  A[3] = -2
        ///  A[4] = 5
        ///  A[5] = 6
        ///contains the following example triplets:
        ///
        ///(0, 1, 2), product is −3 * 1 * 2 = −6
        ///(1, 2, 4), product is 1 * 2 * 5 = 10
        ///(2, 4, 5), product is 2 * 5 * 6 = 60
        ///Your goal is to find the maximal product of any triplet.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A, returns the value of the maximal product of any triplet.
        ///
        ///For example, given array A such that:
        ///
        ///  A[0] = -3
        ///  A[1] = 1
        ///  A[2] = 2
        ///  A[3] = -2
        ///  A[4] = 5
        ///  A[5] = 6
        ///the function should return 60, as the product of triplet (2, 4, 5) is maximal.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [3..100,000];
        ///each element of array A is an integer within the range [−1,000..1,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxProductOfThree(int[] A)
        {
            Array.Sort(A);
            return Math.Max(A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3], A[0] * A[1] * A[A.Length - 1]);
        }

        /// <summary>
        /// Lesson 06 - Sorting
        /// We draw N discs on a plane. The discs are numbered from 0 to N − 1. A zero-indexed array A of N non-negative integers, specifying the radiuses of the discs, is given. The J-th disc is drawn with its center at (J, 0) and radius A[J].
        ///
        ///We say that the J-th disc and K-th disc intersect if J ≠ K and the J-th and K-th discs have at least one common point (assuming that the discs contain their borders).
        ///
        ///The figure below shows discs drawn for N = 6 and A as follows:
        ///
        ///  A[0] = 1
        ///  A[1] = 5
        ///  A[2] = 2
        ///  A[3] = 1
        ///  A[4] = 4
        ///  A[5] = 0
        /// 
        /// There are eleven (unordered) pairs of discs that intersect, namely:
        ///
        ///discs 1 and 4 intersect, and both intersect with all the other discs;
        ///disc 2 also intersects with discs 0 and 3.
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given an array A describing N discs as explained above, returns the number of (unordered) pairs of intersecting discs. The function should return −1 if the number of intersecting pairs exceeds 10,000,000.
        ///
        ///Given array A shown above, the function should return 11, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..100,000];
        ///each element of array A is an integer within the range [0..2,147,483,647].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int NumberOfDiscIntersections(int[] A)
        {
            var right = new long[A.Length];
            var left = new long[A.Length];
            for (var i = 0; i < A.Length; ++i)
            {
                right[i] = (long) i + A[i];
                left[i] = (long) i - A[i];
            }
            Array.Sort(right);
            Array.Sort(left);

            long nonintersect = 0;
            var iright = A.Length - 1;
            var ileft = A.Length - 1;
            while (iright >= 0 && ileft >= 0)
            {
                if (left[ileft] > right[iright])
                {
                    nonintersect += iright + 1;
                    ileft--;
                }
                else
                {
                    iright--;
                }
            }

            var intersect = (long) A.Length * (A.Length - 1) / 2 - nonintersect;
            if (intersect > 1e7) return -1;
            return (int) intersect;
        }



        /// <summary>
        /// Lesson 07 - Stacks and Queues
        /// A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:
        ///
        ///S is empty;
        ///S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
        ///S has the form "VW" where V and W are properly nested strings.
        ///For example, the string "{[()()]}" is properly nested but "([)()]" is not.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(string S); }
        ///that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.
        ///
        ///For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..200,000];
        ///string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int Brackets(string S)
        {
            if (S == null || S.Length == 1)
                return 0;
            if (S.Length == 0)
                return 1;

            var stack = new Stack<char>();

            foreach (char bracket in S)
                if (stack.Count > 0)
                {
                    if (IsReversedBracket(stack.Peek(), bracket))
                        stack.Pop();
                    else
                        stack.Push(bracket);
                }
                else
                    stack.Push(bracket);

            return stack.Count > 0 ? 0 : 1;
        }
        public static bool IsReversedBracket(char left, char right)
        {
            switch (left)
            {
                case '{':
                    return right == '}';
                case '(':
                    return right == ')';
                case '[':
                    return right == ']';
                default:
                    return false;
            }
        }

        /// <summary>
        /// Lesson 07 - Stacks and Queues
        /// You are given two non-empty zero-indexed arrays A and B consisting of N integers. Arrays A and B represent N voracious fish in a river, ordered downstream along the flow of the river.
        ///
        ///The fish are numbered from 0 to N − 1. If P and Q are two fish and P &lt; Q, then fish P is initially upstream of fish Q. Initially, each fish has a unique position.
        ///
        ///Fish number P is represented by A[P] and B[P]. Array A contains the sizes of the fish. All its elements are unique. Array B contains the directions of the fish. It contains only 0s and/or 1s, where:
        ///
        ///0 represents a fish flowing upstream,
        ///1 represents a fish flowing downstream.
        ///If two fish move in opposite directions and there are no other (living) fish between them, they will eventually meet each other. Then only one fish can stay alive − the larger fish eats the smaller one. More precisely, we say that two fish P and Q meet each other when P &lt; Q, B[P] = 1 and B[Q] = 0, and there are no living fish between them. After they meet:
        ///
        ///If A[P] &gt; A[Q] then P eats Q, and P will still be flowing downstream,
        ///If A[Q] &gt; A[P] then Q eats P, and Q will still be flowing upstream.
        ///We assume that all the fish are flowing at the same speed. That is, fish moving in the same direction never meet. The goal is to calculate the number of fish that will stay alive.
        ///
        ///For example, consider arrays A and B such that:
        ///
        ///  A[0] = 4    B[0] = 0
        ///  A[1] = 3    B[1] = 1
        ///  A[2] = 2    B[2] = 0
        ///  A[3] = 1    B[3] = 0
        ///  A[4] = 5    B[4] = 0
        ///Initially all the fish are alive and all except fish number 1 are moving upstream. Fish number 1 meets fish number 2 and eats it, then it meets fish number 3 and eats it too. Finally, it meets fish number 4 and is eaten by it. The remaining two fish, number 0 and 4, never meet and therefore stay alive.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A, int[] B); }
        ///that, given two non-empty zero-indexed arrays A and B consisting of N integers, returns the number of fish that will stay alive.
        ///
        ///For example, given the arrays shown above, the function should return 2, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [0..1,000,000,000];
        ///each element of array B is an integer that can have one of the following values: 0, 1;
        ///the elements of A are all distinct.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int Fish(int[] A, int[] B)
        {
            var count = A.Length;
        
            var upStream = new Stack<int>();
        
            for(int i = 0, len = count; i < len; i++)
            {
                if(B[i] == 1)
                    upStream.Push(A[i]);
                else
                {
                    while(upStream.Count > 0)
                    {
                        count--;
                        if(upStream.Peek() > A[i])
                        {
                            break;
                        }
                        upStream.Pop();
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Lesson 07 - Stacks and Queues
        /// You are going to build a stone wall. The wall should be straight and N meters long, and its thickness should be constant; however, it should have different heights in different places. The height of the wall is specified by a zero-indexed array H of N positive integers. H[I] is the height of the wall from I to I+1 meters to the right of its left end. In particular, H[0] is the height of the wall's left end and H[N−1] is the height of the wall's right end.
        ///
        ///The wall should be built of cuboid stone blocks (that is, all sides of such blocks are rectangular). Your task is to compute the minimum number of blocks needed to build the wall.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] H); }
        ///that, given a zero-indexed array H of N positive integers specifying the height of the wall, returns the minimum number of blocks needed to build it.
        ///
        ///For example, given array H containing N = 9 integers:
        ///
        ///  H[0] = 8    H[1] = 8    H[2] = 5
        ///  H[3] = 7    H[4] = 9    H[5] = 8
        ///  H[6] = 7    H[7] = 4    H[8] = 8
        ///the function should return 7. The figure shows one possible arrangement of seven blocks.
        /// </summary>
        /// <param name="H"></param>
        /// <returns></returns>
        public static int StoneWall(int[] H)
        {
            var blocksCount = 0;
            var blocks = new Stack<int>();
        
            for(int i = 0, len = H.Length; i < len; i++)
            {
                var height = H[i];
                var block = 0;
            
                while(blocks.Count > 0)
                {
                    block = blocks.Peek();
                    if(block > height)
                    {
                        blocks.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                if (block == height) continue;
                blocks.Push(height);
                blocksCount++;
            }
        
            return blocksCount;
        }

        /// <summary>
        /// Lesson07 - Stacks and Queues
        /// A string S consisting of N characters is called properly nested if:
        ///
        ///S is empty;
        ///S has the form "(U)" where U is a properly nested string;
        ///S has the form "VW" where V and W are properly nested strings.
        ///For example, string "(()(())())" is properly nested but string "())" isn't.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(string S); }
        ///that, given a string S consisting of N characters, returns 1 if string S is properly nested and 0 otherwise.
        ///
        ///For example, given S = "(()(())())", the function should return 1 and given S = "())", the function should return 0, as explained above.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int Nesting(string S)
        {
            var nestCount = 0;
        
            for (int i = 0, len = S.Length; i < len; i++)
            {
                if(S[i] == '(')
                    nestCount++;
                else
                    nestCount--;
            
                if(nestCount < 0 || nestCount > len - i - 1) return 0;
            }
        
            return nestCount == 0 ? 1 : 0;
        }



        /// <summary>
        /// Lesson 08 - Leader
        /// A non-empty zero-indexed array A consisting of N integers is given.
        ///
        ///The leader of this array is the value that occurs in more than half of the elements of A.
        ///
        ///An equi leader is an index S such that 0 ≤ S &lt; N − 1 and two sequences A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N − 1] have leaders of the same value.
        ///
        ///For example, given array A such that:
        ///
        ///    A[0] = 4
        ///    A[1] = 3
        ///    A[2] = 4
        ///    A[3] = 4
        ///    A[4] = 4
        ///    A[5] = 2
        ///we can find two equi leaders:
        ///
        ///0, because sequences: (4) and (3, 4, 4, 4, 2) have the same leader, whose value is 4.
        ///2, because sequences: (4, 3, 4) and (4, 4, 2) have the same leader, whose value is 4.
        ///The goal is to count the number of equi leaders.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns the number of equi leaders.
        ///
        ///For example, given:
        ///
        ///    A[0] = 4
        ///    A[1] = 3
        ///    A[2] = 4
        ///    A[3] = 4
        ///    A[4] = 4
        ///    A[5] = 2
        ///the function should return 2, as explained above.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int EquiLeader(int[] A)
        {
            if(A.Length == 1) return 0;
            
            var candidateValue = 0;
            var candidateValueCount = 0;
        
            for(int i = 0, len = A.Length; i < len; i++)
            {
                if(candidateValueCount == 0)
                {
                    candidateValue = A[i];
                    candidateValueCount++;
                }
                else
                {
                    if(candidateValue != A[i])
                        candidateValueCount--;
                    else
                        candidateValueCount++;
                }
            }
        
            if(candidateValueCount == 0)
                return 0;
            
            int leader;
            var leadersTotalCount = 0; 
            //leadersTotalCount = A.Count(c => c == candidateValue);

            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == candidateValue)
                    leadersTotalCount++;
            }

        
            if(leadersTotalCount > A.Length / 2)
                leader = candidateValue;
            else
                return 0;
            
            var equiLeadersCount = 0;
            var leftSequenceLeadersCount = 0;
        
            for(int i = 0, len = A.Length; i < len; i++)
            {
                if(A[i] == leader)
                    leftSequenceLeadersCount++;
                
                var leftSequenceLength = i + 1;
                if (leftSequenceLeadersCount <= leftSequenceLength / 2) continue;
                var rightSequenceLength = len - leftSequenceLength;
                if(leadersTotalCount - leftSequenceLeadersCount > rightSequenceLength / 2)
                    equiLeadersCount++;
            }
        
            return equiLeadersCount;
        }

        /// <summary>
        /// Lesson 08 - Leader
        /// A zero-indexed array A consisting of N integers is given. The dominator of array A is the value that occurs in more than half of the elements of A.
        ///
        ///For example, consider array A such that
        ///
        /// A[0] = 3    A[1] = 4    A[2] =  3
        /// A[3] = 2    A[4] = 3    A[5] = -1
        /// A[6] = 3    A[7] = 3
        ///The dominator of A is 3 because it occurs in 5 out of 8 elements of A (namely in those with indices 0, 2, 4, 6 and 7) and 5 is more than a half of 8.
        ///
        ///Write a function
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A consisting of N integers, returns index of any element of array A in which the dominator of A occurs. The function should return −1 if array A does not have a dominator.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..100,000];
        ///each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
        ///For example, given array A such that
        ///
        /// A[0] = 3    A[1] = 4    A[2] =  3
        /// A[3] = 2    A[4] = 3    A[5] = -1
        /// A[6] = 3    A[7] = 3
        ///the function may return 0, 2, 4, 6 or 7, as explained above.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Dominator(int[] A)
        {
            var candidateValue = 0;
            var candidateValueCount = 0;
        
            for(int i = 0, len = A.Length; i < len; i++)
            {
                if(candidateValueCount == 0)
                {
                    candidateValue = A[i];
                    candidateValueCount++;
                }
                else
                {
                    if(candidateValue == A[i])
                        candidateValueCount++;
                    else
                        candidateValueCount--;
                }
            }
        
            if(candidateValueCount <= 0)
                return -1;
        
            var dominatorIndex = -1;
            var dominatorTotalCount = 0;
        
            for(int i = 0, len = A.Length; i < len; i++)
            {
                if (A[i] != candidateValue) continue;
                dominatorTotalCount++;
                dominatorIndex = i;
            }
        
            if(dominatorTotalCount > A.Length / 2)
            {
                return dominatorIndex;
            }
            return -1;
        }



        /// <summary>
        /// Lesson 09 - Maximum slice problem
        /// A non-empty zero-indexed array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P ≤ Q &lt; N, is called a slice of array A. The sum of a slice (P, Q) is the total of A[P] + A[P+1] + ... + A[Q].
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given an array A consisting of N integers, returns the maximum sum of any slice of A.
        ///
        ///For example, given array A such that:
        ///
        ///A[0] = 3  A[1] = 2  A[2] = -6
        ///A[3] = 4  A[4] = 0
        ///the function should return 5 because:
        ///
        ///(3, 4) is a slice of A that has sum 4,
        ///(2, 2) is a slice of A that has sum −6,
        ///(0, 1) is a slice of A that has sum 5,
        ///no other slice of A has sum greater than (0, 1).
        ///Assume that:
        ///
        ///N is an integer within the range [1..1,000,000];
        ///each element of array A is an integer within the range [−1,000,000..1,000,000];
        ///the result will be an integer within the range [−2,147,483,648..2,147,483,647].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxSliceSum(int[] A)
        {
            long maxSlice = int.MinValue;
            long slice = maxSlice;
        
            foreach(var a in A)
            {
                slice = Math.Max(a, a + slice);
                maxSlice = Math.Max(maxSlice, slice);
            }
        
            return (int)maxSlice;
        }
        
        /// <summary>
        /// Lesson 09 - Maximum slice problem
        /// A non-empty zero-indexed array A consisting of N integers is given.
        ///
        ///A triplet (X, Y, Z), such that 0 ≤ X &lt; Y &lt; Z &lt; N, is called a double slice.
        ///
        ///The sum of double slice (X, Y, Z) is the total of A[X + 1] + A[X + 2] + ... + A[Y − 1] + A[Y + 1] + A[Y + 2] + ... + A[Z − 1].
        ///
        ///For example, array A such that:
        ///
        ///    A[0] = 3
        ///    A[1] = 2
        ///    A[2] = 6
        ///    A[3] = -1
        ///    A[4] = 4
        ///    A[5] = 5
        ///    A[6] = -1
        ///    A[7] = 2
        ///contains the following example double slices:
        ///
        ///double slice (0, 3, 6), sum is 2 + 6 + 4 + 5 = 17,
        ///double slice (0, 3, 7), sum is 2 + 6 + 4 + 5 − 1 = 16,
        ///double slice (3, 4, 5), sum is 0.
        ///The goal is to find the maximal sum of any double slice.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns the maximal sum of any double slice.
        ///
        ///For example, given:
        ///
        ///    A[0] = 3
        ///    A[1] = 2
        ///    A[2] = 6
        ///    A[3] = -1
        ///    A[4] = 4
        ///    A[5] = 5
        ///    A[6] = -1
        ///    A[7] = 2
        ///the function should return 17, because no double slice of array A has a sum of greater than 17.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [3..100,000];
        ///each element of array A is an integer within the range [−10,000..10,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxDoubleSliceSum(int[] A)
        {
            var N = A.Length - 2;

            var leftSums = new int[N];
            var rightSums = new int[N];

            for (int i = 0, length = N - 1; i < length; i++)
            {
                leftSums[i + 1] = Math.Max(0, leftSums[i] + A[i + 1]);
                rightSums[length - i - 1] = Math.Max(0, rightSums[length - i] + A[length - i + 1]);
            }
        
            var maxSum = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                maxSum = Math.Max(maxSum, leftSums[i] + rightSums[i]);
            }

            return maxSum;
        }
        
        /// <summary>
        /// Lesson 09 - Maximum slice problem
        /// A zero-indexed array A consisting of N integers is given. It contains daily prices of a stock share for a period of N consecutive days. If a single share was bought on day P and sold on day Q, where 0 ≤ P ≤ Q &lt; N, then the profit of such transaction is equal to A[Q] − A[P], provided that A[Q] ≥ A[P]. Otherwise, the transaction brings loss of A[P] − A[Q].
        ///
        ///For example, consider the following array A consisting of six elements such that:
        ///
        ///  A[0] = 23171
        ///  A[1] = 21011
        ///  A[2] = 21123
        ///  A[3] = 21366
        ///  A[4] = 21013
        ///  A[5] = 21367
        ///If a share was bought on day 0 and sold on day 2, a loss of 2048 would occur because A[2] − A[0] = 21123 − 23171 = −2048. If a share was bought on day 4 and sold on day 5, a profit of 354 would occur because A[5] − A[4] = 21367 − 21013 = 354. Maximum possible profit was 356. It would occur if a share was bought on day 1 and sold on day 5.
        ///
        ///Write a function,
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a zero-indexed array A consisting of N integers containing daily prices of a stock share for a period of N consecutive days, returns the maximum possible profit from one transaction during this period. The function should return 0 if it was impossible to gain any profit.
        ///
        ///For example, given array A consisting of six elements such that:
        ///
        ///  A[0] = 23171
        ///  A[1] = 21011
        ///  A[2] = 21123
        ///  A[3] = 21366
        ///  A[4] = 21013
        ///  A[5] = 21367
        ///the function should return 356, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [0..400,000];
        ///each element of array A is an integer within the range [0..200,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] A)
        {
            //if (A.Length < 2) {
            //    return 0;
            //}

            //var msf = 0;
            //var meh = 0;
            //for (int i = 1; i < A.Length; i++) {
            //    meh = Math.Max(0, meh + A[i] - A[i - 1]);
            //    msf = Math.Max(msf, meh);
            //}
            //return msf > 0 ? msf : 0;

            // 100 -100
            var maxValue = int.MaxValue;
            var maxProfit = 0;

            for (var i = 1; i < A.Length; i++)
            {
                if (maxValue > A[i - 1])
                    maxValue = A[i - 1];

                if (A[i] - maxValue > maxProfit)
                    maxProfit = A[i] - maxValue;
            }

            return maxProfit;
        }
        


        /// <summary>
        /// Lesson 10 - Prime and composite numbers
        /// An integer N is given, representing the area of some rectangle.
        ///
        ///The area of a rectangle whose sides are of length A and B is A * B, and the perimeter is 2 * (A + B).
        ///
        ///The goal is to find the minimal perimeter of any rectangle whose area equals N. The sides of this rectangle should be only integers.
        ///
        ///For example, given integer N = 30, rectangles of area 30 are:
        ///
        ///(1, 30), with a perimeter of 62,
        ///(2, 15), with a perimeter of 34,
        ///(3, 10), with a perimeter of 26,
        ///(5, 6), with a perimeter of 22.
        ///Write a function:
        ///
        ///class Solution { public int solution(int N); }
        ///that, given an integer N, returns the minimal perimeter of any rectangle whose area is exactly equal to N.
        ///
        ///For example, given an integer N = 30, the function should return 22, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..1,000,000,000].
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int MinPerimeterRectangle(int N)
        {
            var minp = 2*(N+1);
            for(var i = 2; i*i <= N; i++){
                if(N%i == 0)
                    minp = Math.Min(minp, 2*(i+N/i));
            }
            return minp;
        }

        /// <summary>
        /// Lesson 10 - Prime and composite numbers
        /// A positive integer D is a factor of a positive integer N if there exists an integer M such that N = D * M.
        ///
        ///For example, 6 is a factor of 24, because M = 4 satisfies the above condition (24 = 6 * 4).
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int N); }
        ///that, given a positive integer N, returns the number of its factors.
        ///
        ///For example, given N = 24, the function should return 8, because 24 has 8 factors, namely 1, 2, 3, 4, 6, 8, 12, 24. There are no other factors of 24.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..2,147,483,647].
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int CountFactors(int N)
        {
            var result = 0;
            var sqrt = (int)Math.Sqrt(N);
            for (var i = 1; i <= sqrt; i++) {
                if (N % i == 0)
                    result += 2;
            }

            if(sqrt * sqrt == N)
                result -= 1;

            return result;
        }

        /// <summary>
        /// Lesson 10 - Prime and composite numbers
        /// A non-empty zero-indexed array A consisting of N integers is given.
        ///
        ///A peak is an array element which is larger than its neighbors. More precisely, it is an index P such that 0 &lt; P &lt; N − 1,  A[P − 1] &lt; A[P] and A[P] &gt; A[P + 1].
        ///
        ///For example, the following array A:
        ///
        ///    A[0] = 1
        ///    A[1] = 2
        ///    A[2] = 3
        ///    A[3] = 4
        ///    A[4] = 3
        ///    A[5] = 4
        ///    A[6] = 1
        ///    A[7] = 2
        ///    A[8] = 3
        ///    A[9] = 4
        ///    A[10] = 6
        ///    A[11] = 2
        ///has exactly three peaks: 3, 5, 10.
        ///
        ///We want to divide this array into blocks containing the same number of elements. More precisely, we want to choose a number K that will yield the following blocks:
        ///
        ///A[0], A[1], ..., A[K − 1],
        ///A[K], A[K + 1], ..., A[2K − 1],
        ///...
        ///A[N − K], A[N − K + 1], ..., A[N − 1].
        ///What's more, every block should contain at least one peak. Notice that extreme elements of the blocks (for example A[K − 1] or A[K]) can also be peaks, but only if they have both neighbors (including one in an adjacent blocks).
        ///
        ///The goal is to find the maximum number of blocks into which the array A can be divided.
        ///
        ///Array A can be divided into blocks as follows:
        ///
        ///one block (1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2). This block contains three peaks.
        ///two blocks (1, 2, 3, 4, 3, 4) and (1, 2, 3, 4, 6, 2). Every block has a peak.
        ///three blocks (1, 2, 3, 4), (3, 4, 1, 2), (3, 4, 6, 2). Every block has a peak. Notice in particular that the first block (1, 2, 3, 4) has a peak at A[3], because A[2] &lt; A[3] &gt; A[4], even though A[4] is in the adjacent block.
        ///However, array A cannot be divided into four blocks, (1, 2, 3), (4, 3, 4), (1, 2, 3) and (4, 6, 2), because the (1, 2, 3) blocks do not contain a peak. Notice in particular that the (4, 3, 4) block contains two peaks: A[3] and A[5].
        ///
        ///The maximum number of blocks that array A can be divided into is three.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns the maximum number of blocks into which A can be divided.
        ///
        ///If A cannot be divided into some number of blocks, the function should return 0.
        ///
        ///For example, given:
        ///
        ///    A[0] = 1
        ///    A[1] = 2
        ///    A[2] = 3
        ///    A[3] = 4
        ///    A[4] = 3
        ///    A[5] = 4
        ///    A[6] = 1
        ///    A[7] = 2
        ///    A[8] = 3
        ///    A[9] = 4
        ///    A[10] = 6
        ///    A[11] = 2
        ///the function should return 3, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [0..1,000,000,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Peaks(int[] A)
        {
            var n = A.Length;
            var peaks = new List<int>();
            for (var i = 1; i < n - 1; i++) {
                if (A[i - 1] < A[i] && A[i] > A[i + 1]) {
                    peaks.Add(i);
                }
            }

            var max = 0;
            for (var i = 1; i < n; i++) {
                if (n % i != 0) continue;
                var bi = 0;
                var block = (n / i);
                foreach (var p in peaks) {
                    if (bi * block <= p && p < (bi + 1) * block) {
                        bi++;
                    }
                }
        
                if (bi == i) {
                    max = i;
                }
            }

            return max;
        }

        /// <summary>
        /// Lesson 10 - Prime and composite numbers
        /// A non-empty zero-indexed array A consisting of N integers is given.
        ///
        ///A peak is an array element which is larger than its neighbours. More precisely, it is an index P such that 0 &lt; P &lt; N − 1 and A[P − 1] &lt; A[P] &gt; A[P + 1].
        ///
        ///For example, the following array A:
        ///
        ///    A[0] = 1
        ///    A[1] = 5
        ///    A[2] = 3
        ///    A[3] = 4
        ///    A[4] = 3
        ///    A[5] = 4
        ///    A[6] = 1
        ///    A[7] = 2
        ///    A[8] = 3
        ///    A[9] = 4
        ///    A[10] = 6
        ///    A[11] = 2
        ///has exactly four peaks: elements 1, 3, 5 and 10.
        ///
        ///You are going on a trip to a range of mountains whose relative heights are represented by array A, as shown in a figure below. You have to choose how many flags you should take with you. The goal is to set the maximum number of flags on the peaks, according to certain rules.
        /// Flags can only be set on peaks. What's more, if you take K flags, then the distance between any two flags should be greater than or equal to K. The distance between indices P and Q is the absolute value |P − Q|.
        ///
        ///For example, given the mountain range represented by array A, above, with N = 12, if you take:
        ///
        ///two flags, you can set them on peaks 1 and 5;
        ///three flags, you can set them on peaks 1, 5 and 10;
        ///four flags, you can set only three flags, on peaks 1, 5 and 10.
        ///You can therefore set a maximum of three flags in this case.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A of N integers, returns the maximum number of flags that can be set on the peaks of the array.
        ///
        ///For example, the following array A:
        ///
        ///    A[0] = 1
        ///    A[1] = 5
        ///    A[2] = 3
        ///    A[3] = 4
        ///    A[4] = 3
        ///    A[5] = 4
        ///    A[6] = 1
        ///    A[7] = 2
        ///    A[8] = 3
        ///    A[9] = 4
        ///    A[10] = 6
        ///    A[11] = 2
        ///the function should return 3, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..400,000];
        ///each element of array A is an integer within the range [0..1,000,000,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Flags(int[] A)
        {
            if (A.Length == 1) return 0;

            List<int> al = new List<int>();

            for (var i = 1; i < A.Length - 1; i++)
            {
                if(A[i] > A[i - 1] && A[i] > A[i + 1])
                    al.Add(i);
            }

            var s = al.Count;
            if (s == 1)
                return 1;
            if (s == 0)
                return 0;
            

            s = (int) Math.Ceiling(Math.Sqrt(A.Length));

            while (s >= 0)
            {
                var lp = al[0];
                var c = 1;
                for (var i = 1; i < al.Count; i++)
                {
                    var d = Math.Abs(al[i] - lp);
                    if (d < s) continue;
                    lp = al[i];
                    c++;
                    if (c == s)
                        return c;
                }
                s--;
            }
            return 0;

        }
    }
}
