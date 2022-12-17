using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMinesOfTwoStrings
{
    class Program
    {
        public static int Mycompare(string s1,string s2)
        {
            int output=0;
            if (s1 == s2)
                output = 0;
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if ((int)s1[i] > (int)s2[i])
                    {
                        output = 1;
                        break;
                    }
                        
                    else if ((int)s1[i] < (int)s2[i])
                    {
                        output = -1;
                        break;
                    }
                        
                }
            }
            return output;
        }
        public static string Myreverse(string s)
        {
            string output = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                output += s[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            int i, x, y=0,j;
            string sign = "+";
            string s1, s2, s3="";
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
           // char[] rev;
           // rev = s1.Reverse().ToArray();
           // s1 = new string(rev);

            //   rev = s2.Reverse().ToArray();
            // s2 = new string(rev);
          //  s2 = Myreverse(s2);

            int max = Math.Max(s1.Length, s2.Length);
            if (s1.Length == s2.Length)
            {
               
                int result = Mycompare(s1, s2);
                if (result > 0)
                {
                    char[] rev;
                    rev = s1.Reverse().ToArray();
                    s1 = new string(rev);
                    s2 = Myreverse(s2);
                    sign = "+";
                    for (i = 0; i < s1.Length; i++)
                    {

                        int d = ((int)s1[i] - 48);
                        int c = ((int)s2[i] - 48);
                        if (d >= c)
                        {
                            s3 += ((char)(d - c + 48)).ToString();
                        }
                       
                        else
                        {
                            s3 += ((char)(d + 10 - c + 48)).ToString();
                            d = ((int)s1[i + 1] - 48);
                            if (d != 0)
                                s1 = s1.Substring(0, i + 1) + ((char)(d - 1 + 48)).ToString() + s1.Substring(i + 2);
                            else
                            {
                                j = i + 1;
                                while (s1.Substring(j, 1) == "0")
                                {
                                    s1 = s1.Substring(0, j) + "9" + s1.Substring(j + 1);
                                    j++;
                                }
               
                                s1 = s1.Substring(0, j) + ((char)((int)s1[j] - 1)).ToString() + s1.Substring(j + 1);
                            }
                        }
                    }
                    s3 += sign;
                    s3 = Myreverse(s3);
                    Console.WriteLine(s3);
                }
                else if (result < 0)
                {
                    char[] rev;
                    rev = s1.Reverse().ToArray();
                    s1 = new string(rev);
                    s2 = Myreverse(s2);
                    string t;
                    t = s1;
                    s1 = s2;
                    s2 = t;
                    sign = "-";
                    for (i = 0; i < s1.Length; i++)
                    {
                       // if (i < s2.Length)
                       // {
                            int d = ((int)s1[i] - 48);
                            int c = ((int)s2[i] - 48);
                            if (d >= c)
                            {
                                s3 += ((char)(d - c + 48)).ToString();
                            }
                            else
                            {
                                s3 += ((char)(d + 10 - c + 48)).ToString();
                                d = ((int)s1[i + 1] - 48);
                                if (d != 0)
                                    s1 = s1.Substring(0, i + 1) + ((char)(d - 1 + 48)).ToString() + s1.Substring(i + 2);
                                else
                                {
                                    j = i + 1;
                                    while (s1.Substring(j, 1) == "0")
                                    {
                                        s1 = s1.Substring(0, j) + "9" + s1.Substring(j + 1);
                                        j++;
                                    }
                                    s1 = s1.Substring(0, j) + ((char)((int)s1[j] - 1)).ToString() + s1.Substring(j + 1);
                                }
                            }
                       // }
                    }
                    s3 += sign;
                    s3 = Myreverse(s3);
                   
                }
                else
                    Console.Write("0");
            }
            else
            {
                char[] rev;
                rev = s1.Reverse().ToArray();
                s1 = new string(rev);
                s2 = Myreverse(s2);
                if (s1.Length < s2.Length)
                {
                   
                    string t;
                    t = s1;
                    s1 = s2;
                    s2 = t;
                    sign = "-";
                }
                //s3 = new string((char)0, max);
                for (i = 0; i < s1.Length; i++)
                {
                    if (i < s2.Length)
                    {
                        int d = ((int)s1[i] - 48);
                        int c = ((int)s2[i] - 48);
                        if (d >= c)
                        {
                            s3 += ((char)(d - c + 48)).ToString();
                        }
                        else
                        {
                            s3 += ((char)(d + 10 - c + 48)).ToString();
                            d = ((int)s1[i + 1] - 48);
                            if (d != 0)
                                s1 = s1.Substring(0, i + 1) + ((char)(d - 1 + 48)).ToString() + s1.Substring(i + 2);
                            else
                            {
                                j = i + 1;
                                while (s1.Substring(j, 1) == "0")
                                {
                                    s1 = s1.Substring(0, j) + "9" + s1.Substring(j + 1);
                                    j++;
                                }
                                s1 = s1.Substring(0, j) + ((char)((int)s1[j] - 1)).ToString() + s1.Substring(j + 1);


                            }
                        }
                    }
                    else
                    {
                        s3 += s1.Substring(i);
                        break;
                    }
                }
                s3 += sign;
                s3 = Myreverse(s3);
            }
            Console.WriteLine(s3);
            Console.ReadKey();
                  
                    
        }
    }
}
