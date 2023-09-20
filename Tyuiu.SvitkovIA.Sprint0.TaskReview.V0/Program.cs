using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SvitkovIA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SvitkovIA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Находит значение данного выражения, по формуле (x + y + z) * 5 получаем = " + DataService.Calc(3, 5, 7));
            Console.ReadKey();
        }
    }
}
