using System;
using System.IO;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveFile
{
    class moveFile
    {
        public static void move(string src,string des)
        {
            try
            {
                File.Move(src, des);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you want to process a .csv or .txt file : Yes or No ");
                string ans = Console.ReadLine();
                string ans1 = ans.ToLower();
                if(ans1=="yes")
                {
                    Console.WriteLine("Enter Source Address of File :");
                    string src = Console.ReadLine();
                    string ext = Path.GetExtension(src);
                    if(ext == ".csv" || ext == ".txt")
                    {
                        Console.WriteLine("Enter the Destination of file :");
                        string des = Console.ReadLine();
                        move(src, des);
                        Console.WriteLine("Done");
                    }
                    else
                    {
                        Console.WriteLine("Not a .csv or .txt file");
                    }
                }
                else
                {
                    Console.WriteLine("Thank You For Using the App");
                    return;
                }
            }

        }
    }
}
