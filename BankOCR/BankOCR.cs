using System.Collections.Generic;
using System.IO;

namespace BankOCR
{
    public class BankOCR
    {
        public static IEnumerable<Account> ReadAccountLines(string inputFile)
        {
            using (var sr = new StreamReader(inputFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var account = new Account(line, sr.ReadLine(), sr.ReadLine());
                    sr.ReadLine();
                    yield return account;
                }
            }
        }
    }
}