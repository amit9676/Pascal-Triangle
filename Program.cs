using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter number");
                int baseNum = int.Parse(Console.ReadLine());

                baseNum = baseNum * 2;
                
                List<int[]> arrList = new List<int[]>();
                int x = 0;
                for (int i = 1; i <= baseNum; i += 2)
                {
                    int[] arr = new int[i];
                    arrList.Add(arr);
                    arr[0] = 1;
                    arr[i - 1] = 1;
                    for (int j = baseNum - i; j > 1; j -= 2)
                    {
                        Console.Write(" ");
                    }
                    
                    for (int k = 1; k <= i; k++)
                    {
                        
                        if (k % 2 != 0)
                        {
                            if ((k - 1 != 0) && (k != arr.Length))
                            {
                                arrList[x][k - 1] = arrList[x - 1][k - 1] + arrList[x - 1][k - 3];
                            }
                            Console.Write(arrList[x][k - 1]);
                        }
                        else
                            Console.Write(" ");
                    }
                    x++;
                    Console.WriteLine();
                }
            }
        }
    }
}
