using Object.Figure;
using System;
using System.Collections.Generic;

namespace Object.FigureComparer
{
    public class PerimeterComparer : IComparer<BaseFigure>
    {
        public int Compare(BaseFigure first, BaseFigure second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("argument null");
            }
            else
            {
                double firstPyrimeter = first.GetPerimeter();
                double secondPyrimeter = second.GetPerimeter();
                if (secondPyrimeter > firstPyrimeter)
                {
                    return -1;
                }
                else if (secondPyrimeter == firstPyrimeter)
                {
                    return 0;
                }
                else return 1;
            }
        }
    }
}
