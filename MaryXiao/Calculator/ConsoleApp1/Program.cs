using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入所需题数：");
            int m =Convert.ToInt32( Console.ReadLine());
            Random n = new Random();
            int len = 2 * m;
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {                
                a[i] = n.Next(1, 101);
            }
            for (int i = 0; i < m; i++)
            {
                string c = "+";
                string f = "+";
                double ans=0;
                double h = a[i] + a[i + m];
                double e = a[i + m] + a[i + m/2];
                if (h <= 50 && e<=50 && a[i]%a[i+m]==0)
                {
                    c = "/";f = "*"; ans = a[i] / a[i + m]*a[i+m/2]; 
                }
                if (h <= 50 && e <= 50 && a[i] % a[i + m] != 0)
                {
                    c = "*"; f = "*"; ans = a[i] * a[i + m] * a[i + m / 2];
                }
                if (h <= 50 && e > 50 && e<=100 && a[i] % a[i + m] == 0)
                {
                    c = "/"; f = "+"; ans = a[i] / a[i + m] + a[i + m / 2];
                }
                if (h <= 50 && e > 50 && e <= 100 && a[i] % a[i + m] != 0)
                {
                    c = "*"; f = "+"; ans = a[i] * a[i + m] + a[i + m / 2];
                }
                if (h <= 50 && e > 100 && e<=150)
                {
                    c = "*"; f = "+"; ans = a[i] * a[i + m] + a[i + m / 2];
                }
                if (h <= 50 && e >150 && e<=200 && a[i+m]%a[i+m/2]==0)
                {
                    c = "*"; f = "/"; ans = a[i] * a[i + m] / a[i + m / 2];
                }
                if (h <= 50 && e > 150 && e <= 200 && a[i + m] % a[i + m / 2] != 0)
                {
                    c = "*"; f = "+"; ans = a[i] * a[i + m] + a[i + m / 2];
                }

                if (h > 50 && h <= 100 && e<50)
                {
                    c = "*";f = "+"; ans = a[i] * a[i + m]+a[i+m/2];
                }
                if (h > 50 && h <= 100 && e > 50 && e <= 100)
                {
                    c = "+"; f = "*"; ans = a[i] + a[i + m] * a[i + m / 2];
                }
                if (h > 50 && h <= 100 && e > 100 && e <= 150)
                {
                    c = "*"; f = "-"; ans = a[i] * a[i + m] - a[i + m / 2];
                }
                if (h > 50 && h <= 100 && e > 150 && e <= 200)
                {
                    c = "*"; f = "-"; ans = a[i] * a[i + m] - a[i + m / 2];
                }

                if (h > 100 && h <= 150 && a[i] % a[i + m] == 0 && e<50)
                {
                    c = "/"; f = "*"; ans = a[i] / a[i + m]*a[i+m/2];
                }
                if (h > 100 && h <= 150 && a[i] % a[i + m] == 0 && e > 50 && e <= 200)
                {
                    c = "/"; f = "+"; ans = a[i] / a[i + m] + a[i + m / 2];
                }

                if (h > 100 && h <= 150 && a[i] % a[i + m] != 0 && e<50)
                {
                    c = "*"; f = "-"; ans = a[i] * a[i + m]-a[i+m/2]; 
                }
                if (h > 100 && h <= 150 && a[i] % a[i + m] != 0 && e >= 50 && e<=200)
                {
                    c = "*"; f = "+"; ans = a[i] * a[i + m] + a[i + m / 2];
                }

                if (h > 150 && h <= 200 && a[i] > a[i + m] && e>50 && e<=200)
                {
                    c = "-";f = "+"; ans = a[i] - a[i + m]+a[i+m/2];
                }

                if (h > 150 && h <= 200 && a[i] <= a[i + m] && e>50 && e<=200)
                {
                    c = "+";f = "*"; ans = a[i] +a[i+m]*a[i+m/2];
                }
                Console.WriteLine(a[i].ToString() +(c)+a[i+m].ToString () +(f)+a[i+m/2].ToString()+ ("=")+ans.ToString()); 
            }
            Console.ReadKey();
        }
    }
}
