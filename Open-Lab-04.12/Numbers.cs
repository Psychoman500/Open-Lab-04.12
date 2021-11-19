using System;
using System.Linq;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int n = 0;
            for (int i = 0; i < 11; i++)
            {
              if (!nums.Contains(i))
                {
                    n = i;
                }
            }
            return n;
        }
    }
}
