using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LiliyaBukhtik
{
    internal class PlayingWithStrings
    {
        
        
        public void Write1(string str1) 
        {
            string blok1, blok2;

            blok1 = str1.Substring(0,4);
            blok2 = str1.Substring(9, 4);
            Console.WriteLine(blok1 + " "+blok2);
        }
         public void Write2(string str2) 
         {
            for (int i = 0; i < str2.Length; i++)
                if ((Char.IsLetter(str2[i])==true)&&(i!=19)&&(i!=21))Console.Write("*");
            else Console.Write(str2[i]);
            Console.WriteLine();
        }
        public void Write3(string str2)
        {
            string str3 = "";
            for (int i = 0; i < str2.Length; i++)

                if (Char.IsLetter(str2[i]) == true)
                    str3 = str3.ToLower() + str2[i];

            for (int i = 0; i < 3; i++)
                Console.Write(str3[i]);
            Console.Write("/");
            for (int i = 3; i < 6; i++)
                Console.Write(str3[i]);
            Console.Write("/" + str3[6] + "/" + str3[7]);
            Console.WriteLine();


        }
        public string Write4(string str)
        {
            int k = 0;

            var str2 = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            
                if (Char.IsLetter(str[i]))

                     str2.Append(str[i]);

            str2.Insert(3,"/");
            str2.Insert(7, "/");
            str2.Insert(9, "/");

            str = str2.ToString();
            return str.ToUpper();

        }

        public string Write5(string str)
        {
            string str2 = "abc";
            string str3 = str2.ToUpper();

            for (int i = 0; i < str.Length; i++)
            {
                if (str.IndexOf(str2) == -1 && str.IndexOf(str3) == -1)
                    return "Does not contain the sequence abc";
            }
            
            return "Contains the sequence abc";
                          
        }
        public string Write6(string str)
        {
            if (str.StartsWith("555"))
                return "Document starts with 555";
            else return "Document does not start with 555";

        }
        public string Write7(string str)
        {
            if (str.EndsWith("1a2b"))
                return "Document ends with 1a2b";
            else return "Document does not end with 1a2b";

        }
    }
}
