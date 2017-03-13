using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //int[] A = { 4,1,3,2 };
            int[] A = { 4,1,3 };
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int N = A.Length;
            int check = 1;
            for (int i = 0; i < N; i++)
            {
                if (A[i] != i+1) check=0;
            }
            return check;
        }
    }
}
