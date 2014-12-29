using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extra
{
    public class MathFunctions
    {

        public double CalcPagesPerMinute(int pages, double time)
        {
            return 60*pages/time;
        }

        public double CalcImagesPerMinute(int pages, double time)
        {
            return 2 * 60 * pages / time;
        }

    }
}
