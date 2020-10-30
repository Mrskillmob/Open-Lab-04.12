using System;
using System.Diagnostics.CodeAnalysis;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int cis1 = 55;
            int nula = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nula = nula + nums[i];
            }return cis1 - nula;
        }
    }
}
