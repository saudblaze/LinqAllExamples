using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTutorials
{
    public static class myLinQ
    {
        public static int myCount<T>(this IEnumerable<T> sequences)
        {
            int Count = 0;
            foreach (var item in sequences)
            {
                Count += 1;
            }
            return Count;
        }
    }
}
