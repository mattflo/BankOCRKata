using System;

namespace BankOCR.cli
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                if (args.Length == 0)
                {
                    ShowUsage();
                    return;
                }
                var accounts = BankOCR.ReadAccountLines(args[0]);

                accounts.ForEach(Show);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void ShowUsage()
        {
            Console.WriteLine("Please supply a file to parse e.g.  .\\BankOCR.cli.exe .\\testFile1.ocr");
        }

        private static void Show(Account account)
        {
            Console.WriteLine(account.ToString());
        }
    }
}
