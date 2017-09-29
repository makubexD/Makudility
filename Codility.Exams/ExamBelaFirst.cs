using System.Collections.Generic;
using System.Text;

namespace Codility.Exams
{
    public class ExamBelaFirst
    {
        public static string MaxTime(int inFirst, int inSecond, int inThird, int inFour)
        {
            if (inFirst == 0 && inSecond == 0 && inThird == 0 && inFour == 0)
            {
                return "00:00";
            }

            var list = new List<int> { inFirst, inSecond, inThird, inFour };

            var first = -1;
            var second = -1;
            var third = -1;

            foreach (var h1 in list)
            {
                if (h1 <= 2 && h1 > first)
                {
                    first = h1;
                }
            }

            list.Remove(first);

            foreach (var h2 in list)
            {
                if (first == 2 && h2 <= 3 && h2 > second)
                {
                    second = h2;
                }
            }
            if (second == -1)
            {
                foreach (var h2 in list)
                {
                    if (h2 > second)
                    {
                        second = h2;
                    }
                }
            }
            list.Remove(second);

            foreach (var m1 in list)
            {
                if (m1 <= 5 && m1 > third)
                {
                    third = m1;
                }
            }
            list.Remove(third);

            var fourth = list[0];

            var validationLessThanZero = first < 0 || second < 0 || third < 0 || fourth < 0;
            if (validationLessThanZero)
            {
                return "No solution";
            }

            var hasValidHours = int.Parse($"{first}{second}") <= 23;
            var hasValidMinutes = int.Parse($"{third}{fourth}") <= 59;

            if (!hasValidHours || !hasValidMinutes) return "No solution";
            var sb = new StringBuilder(5);
            sb.Append(first);
            sb.Append(second);
            sb.Append(':');
            sb.Append(third);
            sb.Append(fourth);

            return sb.ToString();
        }
    }
}
