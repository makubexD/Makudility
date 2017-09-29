using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Exams
{
    /// <summary>
    /// Tasks from Indeed Prime 2015 challenge
    /// </summary>
    public class Lesson90
    {
        /// <summary>
        /// You would like to set a password for a bank account. However, there are three restrictions on the format of the password:
        ///
        ///it has to contain only alphanumerical characters (a−z, A−Z, 0−9);
        ///there should be an even number of letters;
        ///there should be an odd number of digits.
        ///You are given a string S consisting of N characters. String S can be divided into words by splitting it at, and removing, the spaces. The goal is to choose the longest word that is a valid password. You can assume that if there are K spaces in string S then there are exactly K + 1 words.
        ///
        ///For example, given "test 5 a0A pass007 ?xy1", there are five words and three of them are valid passwords: "5", "a0A" and "pass007". Thus the longest password is "pass007" and its length is 7. Note that neither "test" nor "?xy1" is a valid password, because "?" is not an alphanumerical character and "test" contains an even number of digits (zero).
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(string S); }
        ///that, given a non-empty string S consisting of N characters, returns the length of the longest word from the string that is a valid password. If there is no such word, your function should return −1.
        ///
        ///For example, given S = "test 5 a0A pass007 ?xy1", your function should return 7, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..200];
        ///string S consists only of printable ASCII characters and spaces.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int LongestPassword(string S)
        {
            return 0;
        }

        /// <summary>
        /// You are helping a geologist friend investigate an area with mountain lakes. A recent heavy rainfall has flooded these lakes and their water levels have reached the highest possible point. Your friend is interested to know the maximum depth in the deepest part of these lakes.
        ///
        ///We simplify the problem in 2-D dimensions. The whole landscape can be divided into small blocks and described by an array A of length N. Each element of A is the altitude of the rock floor of a block (i.e. the height of this block when there is no water at all). After the rainfall, all the low-lying areas (i.e. blocks that have higher blocks on both sides) are holding as much water as possible. You would like to know the maximum depth of water after this entire area is flooded. You can assume that the altitude outside this area is zero and the outside area can accommodate infinite amount of water.
        ///
        ///For example, consider array A such that:
        ///
        ///    A[0] = 1
        ///    A[1] = 3
        ///    A[2] = 2
        ///    A[3] = 1
        ///    A[4] = 2
        ///    A[5] = 1
        ///    A[6] = 5
        ///    A[7] = 3
        ///    A[8] = 3
        ///    A[9] = 4
        ///    A[10] = 2
        ///The following picture illustrates the landscape after it has flooded:
        ///
        ///
        ///
        ///The gray area is the rock floor described by the array A above and the blue area with dashed lines represents the water filling the low-lying areas with maximum possible volume. Thus, blocks 3 and 5 have a water depth of 2 while blocks 2, 4, 7 and 8 have a water depth of 1. Therefore, the maximum water depth of this area is 2.
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int[] A); }
        ///that, given a non-empty zero-indexed array A consisting of N integers, returns the maximum depth of water.
        ///
        ///Given array A shown above, the function should return 2, as explained above.
        ///
        ///For the following array:
        ///
        ///    A[0] = 5
        ///    A[1] = 8
        ///the function should return 0, because this landscape cannot hold any water.
        ///
        ///Assume that:
        ///
        ///N is an integer within the range [1..100,000];
        ///each element of array A is an integer within the range [1..100,000,000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FloodDepth(int[] A)
        {
            int result = 0;
            int highest = 0;
            int lowest = 0;
            foreach (int i in A) {
                if (i >= highest) {
                    result = Math.Max(result, highest - lowest);
                    lowest = highest = i;
                } else if (i < lowest) {
                    lowest = i;
                } else if (i > lowest) {
                    result = Math.Max(result, i - lowest);
                }
            }
            return result;
        }

        public static int SlalomSkiing(int[] A)
        {
            return 0;

        }
        
    }
}
