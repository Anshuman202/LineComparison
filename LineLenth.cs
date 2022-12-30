using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLenth
    {
        public static void Lenth()
        {
            /* A Length as 2 Points(x1, y1) and(x2, y2) - 
                 Length of a Line = sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
                 */
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double Lenth = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Lenth);
        }
    }
}
    

