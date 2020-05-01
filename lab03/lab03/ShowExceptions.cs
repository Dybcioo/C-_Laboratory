using System;
using System.Collections.Generic;
using System.Text;

namespace lab03
{
    static class ShowExceptions
    {
        public static void information(Exception exception)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                if (exception is SystemException)
                {
                    Console.WriteLine("System Exception");
                }
                else if (exception is ApplicationException)
                {
                    Console.WriteLine("Application Exception");
                }

                Console.WriteLine("Type: " + exception.GetType());
                Console.WriteLine("Message: " + exception.Message);
                Console.WriteLine("TargetSite: " + exception.TargetSite);
                Console.WriteLine("StackTrace: " + exception.StackTrace);
                Console.WriteLine("HelpLink: " + exception.HelpLink);
                Console.WriteLine("Data: " + exception.Data);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (Exception e)
            {
                ShowExceptions.information(e);
            }
        }
    }
}
