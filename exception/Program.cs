using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = null;
            try
            {

                 str = new StreamReader(@"C:\softwares\SQL software\excep1.txt");
                Console.WriteLine(str.ReadToEnd());
                str.Close();
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please enter the correct filename {0}", ex.Message);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
                {
                if(str!=null)
                {
                    str.Close();

                }
            }
        }
        
    }
}
