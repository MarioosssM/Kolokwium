using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Program
    {
        public static int Fishes(int[] A, int[] B)
        {
            Stack<int> aliveFish = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (aliveFish.Count == 0)
                {
                    aliveFish.Push(i);
                }
                else
                {
                    while (aliveFish.Count !=0 && B[i] - B[aliveFish.Peek()] == -1 && A[i] > A[aliveFish.Peek()] )
                    {
                        aliveFish.Pop();
                        if(aliveFish.Count != 0)
                        {
                            if(B[i] - B[aliveFish.Count] != -1)
                            {

                                aliveFish.Push(i);
                            }
                        }
                        else
                        {
                            aliveFish.Push(i);
                        }
                    }
                }
            }

            return aliveFish.Count;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 4, 3, 2, 1, 5 };
            int[] b = new int[] { 0, 1, 0, 0, 0 };
            Console.WriteLine(Fishes(a, b));
            Console.ReadKey();
        }
    }
}
