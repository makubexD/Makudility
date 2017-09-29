using System;
using System.Linq;

namespace Codility.Exams
{
    public class ExamBelaSecond
    {
        public static int ChainBreaker(int[] A)
        {
            //int len = A.Length;
            //int minCost = A[1]+A[3];
            //int cost;
            //for(int p=1; p<len-3; p++){
            //    for(int q = p+2; q<len-1; q++){
            //        cost = A[p]+A[q];
            //        if(cost < minCost){
            //            minCost = cost;
            //        }
            //    }
            //}
            //return minCost;

            int P = 1;
            int result = A.Max();
            for (int Q = 3; Q < A.Length - 1; Q++)
            {//Start the loop with Q = 3
                result = Math.Min(result, A[Q] + A[P]);
                //if (A[P] > A[Q - 1])
                //{
                //    //Update min only with the last element to maintain the constraint P - Q > 1
                //    P = Q - 1;
                //}

            }
            return result;
        }
    }
}
