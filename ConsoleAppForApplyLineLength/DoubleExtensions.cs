using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForApplyLineLength
{
    // 定义扩展方法的静态类
    public static class DoubleExtensions
    {
        /// <summary>
        /// 计算双精度数的平方
        /// </summary>
        /// <param name="number">输入数</param>
        /// <returns>平方值</returns>
        public static double Square(this double number)
        {
            return number * number;
        }
    }
}
