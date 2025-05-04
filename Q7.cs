//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Class7
//    {
//        static public void Main(string[] args)
//        {
//            int[,] arr =
//            {
//                {1,2,3,4,5 },
//                {6,7,8,9,10},
//                {11,12,13,14,15},
//                {16,17,18,19,20 },
//                {21,22,23,24,25 }
//            };

//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                if (i == 0 || i == 2 || i == 4)
//                {

//                    for (int j = 0; j < arr.GetLength(1); j++)
//                    {
//                        Console.Write(arr[i,j]+" ");
//                    }
//                }

//                if((i==1 || i==3))
//                {
//                    for(int j= arr.GetLength(1)-1; j>=0; j--)
//                    {
//                        Console.Write(arr[i,j]+" ");
//                    }
//                }

//                Console.WriteLine();
//            }

//        }




//    }
//}




