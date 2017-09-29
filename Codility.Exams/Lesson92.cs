using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Exams
{
    /// <summary>
    /// Tasks from Indeed Prime 2016 College Coders challenge
    /// </summary>
    public static class Lesson92
    {
        public static int TennisTournament(int P, int C)
        {
            return C*2 < P ? C : P/2;
            //int match = 0;

            //if ((P / 2) > C)
            //{
            //    match = C;
            //}
            //else
            //{
            //    match = P / 2;
            //}
            //return match;

            //if(P==1){
            //    return 0;    
            //}
            //if(C==1 || P ==2){
            //    return 1;    
            //}
            //var V = Math.Floor((decimal) (P/2));
            //if(V<=C){
            //    return (int)V;    
            //}
            //return C;
        }

        public static int SocksLaundering(int K, int[] C, int[] D)
        {
            return 1;
        }
    }
}
