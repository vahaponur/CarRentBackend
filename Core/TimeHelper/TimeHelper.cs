using System;
using System.Collections.Generic;
using System.Text;

namespace Core.TimeHelper
{
    public static class TimeHelper
    {
        /// <summary>
        /// Returns True if Time Interval A, intersect with TimeInterval B
        /// </summary>
        /// <param name="startA"></param>
        /// <param name="endA"></param>
        /// <param name="startB"></param>
        /// <param name="endB"></param>
        /// <returns></returns>
        public static bool TimeIntersect(DateTime startA, DateTime endA, DateTime startB, DateTime endB)
        {
            return (startA.Date <= endB.Date) && (endA.Date >= startA.Date);
        }
    }
}
