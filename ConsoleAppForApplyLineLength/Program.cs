namespace ConsoleAppForApplyLineLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("两点直线距离计算器");

            // 输入第一个点a的x坐标
            Console.Write("请输入第一个点a的x坐标数值(x1)：");
            double x1 = ReadPositiveDouble();

            // 输入第一个点a的y坐标
            Console.Write("请输入第一个点a的y坐标数值(y1)：");
            double y1 = ReadPositiveDouble();

            // 输入第二个点b的x坐标
            Console.Write("请输入第二个点b的x坐标数值(x2)：");
            double x2 = ReadPositiveDouble();

            // 输入第二个点b的y坐标
            Console.Write("请输入第二个点b的y坐标数值(y2)：");
            double y2 = ReadPositiveDouble();

            var x = Math.Abs(x2 - x1);
            Console.WriteLine($"x2 - x1的数值(x)：{x:F2}");

            var y = Math.Abs(y2 - y1);
            Console.WriteLine($"y2 - y1的数值(y)：{y:F2}");

            // 计算斜边
            double c = Math.Sqrt(x.Square() + y.Square());

            Console.WriteLine($"\n根据勾股定理，两点直线距离（c）为：{c:F2}");
        }

        /// <summary>
        /// 读取用户输入的双精度整数并进行验证
        /// </summary>
        /// <returns>有效的双精度整数</returns>
        static double ReadPositiveDouble()
        {
            double value;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    return value;
                }
            }
        }
    }
}
