using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(new DbLog());
        }
    }
    class Test {
        ILog _logger;
        public Test(ILog log)// Constructor dependency
        {
            _logger = log;
        }
        public void Method() {
            try
            {
                //some code
                throw new ArgumentException();
            }
            catch (ArgumentException e)
            {
                //Logs the value 
                _logger.Log(e.Message);
            }
        }
    }
    interface ILog
    {
        void Log(string message);
    }
    class TextLog: ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("Log"+message);
        }
    }
    class DbLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("Log "+message);
        }
    }
   
}
