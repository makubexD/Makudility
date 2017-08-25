namespace Codility.Exams
{
    /// <summary>
    /// Euclidean algorithm
    /// </summary>
    public class Lesson12
    {
        /// <summary>
        /// Two positive integers N and M are given. Integer N represents the number of chocolates arranged in a circle, numbered from 0 to N − 1.
        ///
        ///You start to eat the chocolates. After eating a chocolate you leave only a wrapper.
        ///
        ///You begin with eating chocolate number 0. Then you omit the next M − 1 chocolates or wrappers on the circle, and eat the following one.
        ///
        ///More precisely, if you ate chocolate number X, then you will next eat the chocolate with number (X + M) modulo N (remainder of division).
        ///
        ///You stop eating when you encounter an empty wrapper.
        ///
        ///For example, given integers N = 10 and M = 4. You will eat the following chocolates: 0, 4, 8, 2, 6.
        ///
        ///The goal is to count the number of chocolates that you will eat, following the above rules.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int N, int M); }
        ///that, given two positive integers N and M, returns the number of chocolates that you will eat.
        ///
        ///For example, given integers N = 10 and M = 4. the function should return 5, as explained above.
        ///
        ///Assume that:
        ///
        ///N and M are integers within the range [1..1,000,000,000].
        /// </summary>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int ChocolatesByNumbers(int N, int M)
        {
            if (N % M == 0)
                return N / M;
            
            return N / ChocolatesByNumbersSub(N, M);
        }

        private static int ChocolatesByNumbersSub(int N, int M)
        {
            if (M == 0)
                return N;

            return N == 0 ? M : ChocolatesByNumbersSub(M, N % M);
        }

        /// <summary>
        /// A prime is a positive integer X that has exactly two distinct divisors: 1 and X. The first few prime integers are 2, 3, 5, 7, 11 and 13.
        ///
        ///A prime D is called a prime divisor of a positive integer P if there exists a positive integer K such that D * K = P. For example, 2 and 5 are prime divisors of 20.
        ///
        ///You are given two positive integers N and M. The goal is to check whether the sets of prime divisors of integers N and M are exactly the same.
        ///
        ///For example, given:
        ///
        ///N = 15 and M = 75, the prime divisors are the same: {3, 5};
        ///N = 10 and M = 30, the prime divisors aren't the same: {2, 5} is not equal to {2, 3, 5};
        ///N = 9 and M = 5, the prime divisors aren't the same: {3} is not equal to {5}.
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A, int[] B); }
        ///that, given two non-empty zero-indexed arrays A and B of Z integers, returns the number of positions K for which the prime divisors of A[K] and B[K] are exactly the same.
        ///
        ///For example, given:
        ///
        ///    A[0] = 15   B[0] = 75
        ///    A[1] = 10   B[1] = 30
        ///    A[2] = 3    B[2] = 5
        ///the function should return 1, because only one pair (15, 75) has the same set of prime divisors.
        ///
        ///Assume that:
        ///
        ///Z is an integer within the range [1..6,000];
        ///each element of arrays A, B is an integer within the range [1..2,147,483,647].
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int CommonPrimeDivisors(int[] A, int[] B)
        {
            var res = 0;
            for (var i = 0; i < A.Length; i++) {
                var a = A[i];
                var b = B[i];
                var gcd = CommonPrimeDivisorsSub(a, b);
                for (int c; (c = CommonPrimeDivisorsSub(b, gcd)) > 1; b = b / c)
                {
                }
                for (int c; (c = CommonPrimeDivisorsSub(a, gcd)) > 1; a = a / c)
                {
                }
                
                if (a == b) {
                    res++;
                }
            }
            return res;
        }

        public static int CommonPrimeDivisorsSub(int a, int b) {
            if (a == 0 || b == 0) {
                return a+b;
            }
            return CommonPrimeDivisorsSub(b, a % b);
        }
    }
}
