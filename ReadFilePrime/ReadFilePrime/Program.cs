﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReadFilePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string ot = "";
            string text = System.IO.File.ReadAllText(@"C:\Users\a_kuanyshuly\Desktop\pp2lab\ReadFilePrime\PrimeIn.txt.txt");

            string[] arr = text.Split(' ');
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = int.Parse(arr[i]);
                if (sum == 1) continue;
                else
                {
                    int j = 0;
                    int cnt = 0;
                    for (j = 2; j <= Math.Sqrt(sum); j++)
                    {
                        if (sum % j == 0)
                        {
                            cnt = 1;
                            break;

                        }
                    }
                    if (cnt == 0)
                        ot = ot + arr[i] + " ";
                    cnt = 0;

                }
            }
            StreamWriter a = new StreamWriter(@"C:\Users\a_kuanyshuly\Desktop\pp2lab\ReadFilePrime\PrimeOut.txt.txt");
            a.Write(ot);
            a.Close();
        }
    }
}
