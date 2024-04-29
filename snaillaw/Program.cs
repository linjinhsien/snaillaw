using System;

namespace RefractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 常量
            const double Pi = Math.PI;

            // 變量
            double n1 = 1.0; // 折射率（入射）
            double n2 = 1.7; // 折射率（折射）
            double angle1Degrees = 45.0; // 入射角度（度）

            // Case 1
            Console.WriteLine("Case 1:");
            CalculateRefraction(n1, n2, angle1Degrees);

            // Case 2
            Console.WriteLine("Case 2:");
            n1 = 1.7;
            n2 = 1.0;
            angle1Degrees = 45.0;
            CalculateRefraction(n1, n2, angle1Degrees);
       

        static void CalculateRefraction(double n1, double n2, double angle1Degrees)
        {
            // 將角度轉換為弧度
            double angle1Radians = angle1Degrees * Pi / 180.0;

            // 計算公式 n1 * sin(θ1) / n2
            double formulaA = n1 * Math.Sin(angle1Radians) / n2;

            // 判斷是否有實解
            if (formulaA > 1.0)
            {
                // 判斷入射介質和折射介質
                if (n1 > n2)
                {
                    Console.WriteLine("(formula > 1) 無實解，光線無法穿透！");
                }
                else
                {
                    Console.WriteLine("(formula > 1) 無實解，光線發生全反射！");
                }
            }
            else
            {
                // 計算折射角
                double angle2Radians = Math.Asin(formulaA);

                // 將弧度轉換為度
                double angle2Degrees = angle2Radians * 180.0 / Pi;

                // 輸出結果
                Console.WriteLine($"結論：角度1 = {angle1Degrees} 度時，得到角度2 = {angle2Degrees} 度");
            }
            }
        }
    }
}