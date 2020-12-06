using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str=File.ReadAllText(@"C:\1.txt").Split(' ','\n');
            //int[] mas = new int[int.Parse(str[0])];
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = int.Parse(str[i + 1]);
            //}
            //foreach (var item in mas)
            //{
            //    Console.WriteLine(item);
            //}
            //int x;
            //while (true)
            //    if (int.TryParse(str[0], out x))
            //        break;
            //    else
            //    {
            //        if (int.TryParse(Console.ReadLine(), out x))
            //            break;
            //    }
            //    Console.WriteLine(x);
            string str2="";
            for (int i = 0; i < str.Length; i++)
            {
                str2 += str[i] + " ";
            }
            Regex re = new Regex(@"(a|b)*");
            Match m = re.Match(str2);
            int n=0;
            while (m.Success)
            {

                Console.WriteLine(m.Value);
                n += m.Length;
                m=m.NextMatch();
            }
            var result = Regex.Replace(str2, @"(a|b)", "123");
            Console.WriteLine(result);
            Console.WriteLine(n);
            //«LastName I.О. – Growth sm – weight kg»
            re = new Regex(@"[\w]*[\s][\w][\.][\w][\.][\s][\-][\s][\d]*[\s][\-][\s][\d]*");
            //Matches mat =re.Matches(str2);
            //foreach (var item in mat)
            //{
            //    Console.WriteLine(item);
            //}
            m = re.Match(str2);
            while (m.Success)
            {
                Console.WriteLine(m.Value);
                m = m.NextMatch();
            }
        }
    }
}
