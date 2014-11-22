using System.Collections.Generic;
using System.Linq;

namespace BankOCR
{
    public class Account
    {
        string line1, line2, line3;

        public Account(string line1, string line2, string line3)
        {
            this.line1 = line1;
            this.line2 = line2;
            this.line3 = line3;
        }

        public IEnumerable<string> UnMaskedBits()
        {
            return Enumerable.Range(1, 9).Select(i =>
		line1.Skip((i - 1) * 3).Take(3).AsString(rightPadding: 3) +
		line2.Skip((i - 1) * 3).Take(3).AsString(rightPadding: 3) +
		line3.Skip((i - 1) * 3).Take(3).AsString(rightPadding: 3)
            );
        }

        public string Report()
        {
            var warn = string.Empty;

            if (false == Legible())
                warn = " ILL";
            else if (false == IsValid())
                warn = " ERR";

            return AsString() + warn;
        }

        public string AsString()
        {
            var chars = Digits().Select(d =>
                {
                    if (d < 0) return "?";

                    return d.ToString();
                });

            return string.Join("", chars);
        }
        public IEnumerable<int> Digits()
        {
            return UnMaskedBits().Select(s =>
                {
                    if (s == " _ | ||_|") return 0;
                    if (s == "     |  |") return 1;
                    if (s == " _  _||_ ") return 2;
                    if (s == " _  _| _|") return 3;
                    if (s == "   |_|  |") return 4;
                    if (s == " _ |_  _|") return 5;
                    if (s == " _ |_ |_|") return 6;
                    if (s == " _   |  |") return 7;
                    if (s == " _ |_||_|") return 8;
                    if (s == " _ |_| _|") return 9;
                    return -1;
                });
        }

        public int Checksum()
        {
            return Enumerable.Range(0, 9).Select(i => Digits().Skip(i).First() * (9 - i)).Sum();
        }

        public bool Legible()
        {
            return false == AsString().Contains("?");
        }

        public bool IsValid()
        {
            return Checksum() % 11 == 0;
        }
    }
}