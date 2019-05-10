using System;
using System.IO;
using NLog;

namespace ExceptionsDemo
{
    class MyException:ApplicationException
    {
        public MyException(string message):base(message)
        {
            Console.WriteLine("my custom exception");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            //vulnerable Line of code place in the Try block
            try
            {
                TestException();
            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.StackTrace);
            }
        }
        static void TestException()
        {
            string path = @"C:\Revature\tst.txt";
            StreamReader sr = null;
            try
            {
                throw new MyException("Raised the user defined exception");
                sr = new StreamReader(path);
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (MyException)
            {

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Please check if the Directory exists!! - {ex.Message} ");
            }
            /*catch (FileNotFoundException ex)
            {
                Console.WriteLine("File name is incorrect !! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }*/
            finally
            {
                sr?.Close();
            }
        }
    }
}
