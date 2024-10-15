namespace ConsoleAppForPythagorasTheorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("勾股定理计算器");

            // 输入第一条直角边
            Console.Write("请输入第一条直角边的长度（a）：");
            double a = ReadPositiveDouble();

            // 输入第二条直角边
            Console.Write("请输入第二条直角边的长度（b）：");
            double b = ReadPositiveDouble();

            // 计算斜边
            double c = Math.Sqrt(a.Square() + b.Square());

            Console.WriteLine($"\n根据勾股定理，斜边的长度（c）为：{c:F2}");
        }

        /// <summary>
        /// 读取用户输入的正数并进行验证
        /// </summary>
        /// <returns>有效的正数</returns>
        static double ReadPositiveDouble()
        {
            double value;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out value) && value > 0)
                {
                    return value;
                }
                else
                {
                    Console.Write("输入无效，请输入一个正数：");
                }
            }
        }
    }
}
