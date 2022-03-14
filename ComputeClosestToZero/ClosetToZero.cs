using System;
using System.Linq;

namespace ComputeClosestToZero
{
    public class ClosetToZero
    {
        public static int ComputeClosestToZero(int[] ts)
        {
            if (ts.Length == 0)
                return 0;
            int closest = ts[0];
            for (int i = 0; i < ts.Length; i++)
            {
                if (Math.Abs(closest) >= Math.Abs(ts[i]))
                    closest = ts[i];
            }
            if (closest < 0)
            {
                if (ts.Contains(Math.Abs(closest)))
                    return Math.Abs(closest);
            }
            return closest;
        }
    }
}
