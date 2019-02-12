using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            // put your code here
            for (int i = 0; i < source.Length / 2; ++i)
            {
                if (source[i] != source[source.Length - 1 - i])
                {
                    return "No";
                }
            }
            return "Yes";
        }
    }
}
