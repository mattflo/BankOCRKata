using System;

namespace BankOCR.cli
{
    class Program
    {
        static void Main(string[] args)
        {
	    if (args.Length == 0)
	    {
	        ShowUsage();
	        return;
	    }
	    var accounts = BankOCR.ReadAccountLines(args[0]);

	    accounts.ForEach(Show);
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
