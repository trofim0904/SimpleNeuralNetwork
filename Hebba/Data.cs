using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebba
{
    public class Data
    {
        public Dictionary<int, int[]> TestData;
        public Data()
        {
            TestData = new Dictionary<int, int[]>
            {
           
                { 0, new int[] { 1, 1,-1,-1,
                                 1,-1, 1,-1,
                                 1,-1, 1,-1,
                                 1, 1,-1,-1 } },
                { 1, new int[] { 1, 1, 1,-1,
                                 1,-1, 1,-1,
                                 1,-1, 1,-1,
                                 1, 1,-1,-1 } },
                { 2, new int[] { 1,-1,-1,1,
                                 1, 1, 1,1,
                                 1,-1,-1,1,
                                 1,-1,-1,1 } },
                { 3, new int[] {  1,-1,-1, 1,
                                  1, 1, 1, 1,
                                  1,-1,-1, 1,
                                 -1,-1,-1,-1 } },
                { 4, new int[] { 1, 1, 1, 1,
                                -1, 1, 1,-1,
                                -1, 1, 1,-1,
                                -1, 1, 1,-1 } },
                { 5, new int[] { 1,  -1, 1, 1,
                                -1, 1, 1,-1,
                                -1, 1, 1,-1,
                                -1, 1, 1,-1 } },
                { 6, new int[] {-1, 1, 1,-1,
                                 1,-1,-1, 1,
                                 1,-1,-1, 1,
                                -1, 1, 1,-1 } },
                { 7, new int[] { 1, 1, 1, 1,
                                 1,-1,-1, 1,
                                 1,-1,-1, 1,
                                 1, 1, 1, 1 } },
                { 8, new int[] { 1, 1, 1, 1,
                                -1, 1, 1,-1,
                                -1, 1, 1,-1,
                                -1, -1, -1,-1 } },
            };

        }
    }
}
