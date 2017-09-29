using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Exams
{
    /// <summary>
    /// Tasks from Indeed Prime 2016 challenge
    /// </summary>
    public class Lesson91
    {
        /// <summary>
        /// A company of dwarfs is travelling across the New Zealand. On reaching the Clutha River the dwarfs need to get across, but recent storms have washed away the bridge. Luckily, a small ferry, in the form of a square raft, is operating.
        ///
        ///The raft is square and has N rows of seats, numbered from 1 to N. Each row contains N seats, labeled with consecutive letters (A, B, C, etc.). Each seat is identified by a string composed of its row number followed by its column number; for example, "9C" denotes the third seat in the 9th row.
        ///
        ///The raft has already been loaded with barrels in some seat positions, and other seats are already occupied by dwarfs. Our company of dwarfs may only take the remaining unoccupied seats. The ferryman wants to accommodate as many dwarfs as possible, but the raft needs to be stable when making the crossing. That is, the following conditions must be satisfied:
        ///
        ///the front and back halves of the raft (in terms of the rows of seats) must each contain the same number of dwarfs;
        ///similarly, the left and right sides of the raft (in terms of the columns of seats) must each contain the same number of dwarfs.
        ///You do not have to worry about balancing the barrels; you can assume that their weights are negligible.
        ///
        ///For example, a raft of size N = 4 is shown in the following illustration:
        ///
        ///
        ///
        ///Barrels are marked as brown squares, and seats that are already occupied by dwarfs are labeled d.
        ///
        ///The positions of the barrels are given in string S. The occupied seat numbers are given in string T. The contents of the strings are separated by single spaces and may appear in any order. For example, in the diagram above, S = "1B 1C 4B 1D 2A" and T = "3B 2D".
        ///
        ///In this example, the ferryman can accommodate at most six more dwarfs, as indicated by the green squares in the following diagram:
        ///
        ///
        ///
        ///The raft is then balanced: both left and right halves have the same number of dwarfs (four), and both front and back halves have the same number of dwarfs (also four).
        ///
        ///Write a function:
        ///
        ///class Solution { public int solution(int N, string S, string T); }
        ///that, given the size of the raft N and two strings S, T that describes the positions of barrels and occupied seats, respectively, returns the maximum number of dwarfs that can fit on the raft. If it is not possible to balance the raft with dwarfs, your function should return -1.
        ///
        ///For instance, given N = 4, S = "1B 1C 4B 1D 2A" and T = "3B 2D", your function should return 6, as explained above.
        ///
        ///Assume that:
        ///
        ///N is an even integer within the range [2..26];
        ///strings S, T consist of valid seat numbers, separated with spaces;
        ///each seat number can appear no more than once in the strings;
        ///no seat number can appear in both S and T simultaneously.
        /// </summary>
        /// <param name="N"></param>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public static int DwarfsRafting(int N, string S, string T)
        {
            //int sum = 0;
            //int qua = (N 
            //           * (N / 4));
            //int[] parts = new int[4];
            //int maxtopleft = 0;
            //int maxbuttonright = 0;
            //if ((S.Length == 0)) {
            //    parts[3] = 0;
            //    parts[2] = 0;
            //    parts[1] = 0;
            //    parts[0] = 0;
            //}
            //else {
            //    foreach (var locaIn in S.ToCharArray())
            //    {
            //        var loca = locaIn.ToString();
            //        int locanum = loca.Length;
            //        int loc = int.Parse(loca.Substring(0, locanum - 1));
            //        char locat = S.ToCharArray()[locanum - 1];
            //        int locatt = locat - 'A' + 1;
            //        if (loc <= N / 2) {
            //            if (locatt <= N / 2) {
            //                parts[0]++;
            //            }
            //            else {
            //                parts[1]++;
            //            }
                    
            //        }
            //        else if (locatt <= N / 2) {
            //            parts[2]++;
            //        }
            //        else {
            //            parts[3]++;
            //        }
                
            //    }
            
            //    if ((parts[0] > parts[3])) {
            //        maxtopleft = parts[0];
            //    }
            //    else {
            //        maxtopleft = parts[3];
            //    }
            
            //    if ((parts[1] > parts[2])) {
            //        maxbuttonright = parts[1];
            //    }
            //    else {
            //        maxbuttonright = parts[2];
            //    }
            
            //}
        
            //int people1 = 0;
            //int people2 = 0;
            //int people3 = 0;
            //int people4 = 0;
            //if ((T.Length != 0)) {
            //    foreach (var ppIn in T.ToCharArray() )
            //    {
            //        var pp = ppIn.ToString();
            //        int locanumt = pp.Length;
            //        int loct = int.Parse(pp.Substring(0, locanumt - 1));
            //        char locatt = T.ToCharArray()[locanumt - 1];
            //        int locattt = (locatt - 'A' + 1);
            //        if (loct <= N / 2) {
            //            if ((locattt <= N / 2)) {
            //                people1++;
            //            }
            //            else {
            //                people2++;
            //            }
                    
            //        }
            //        else if (locattt <= (N / 2)) {
            //            people3++;
            //        }
            //        else {
            //            people4++;
            //        }
                
            //    }
            
            //}
        
            //if (qua - maxtopleft 
            //    < people1 
            //    || ((qua - maxtopleft) 
            //        < people4)) {
            //    return -1;
            //}
        
            //if ((((qua - maxbuttonright) 
            //      < people2) 
            //     || ((qua - maxbuttonright) 
            //         < people3))) {
            //    return -1;
            //}
        
            //sum = ((((2 * qua) 
            //         - (maxtopleft - maxbuttonright)) 
            //        * 2) 
            //       - (people1 
            //          - (people2 
            //             - (people3 - people4))));
            //return sum;
            return 1;
        }
    }
}
