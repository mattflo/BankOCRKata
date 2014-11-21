using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace BankOCR
{
    [TestFixture]
    public class BankOCRSpec
    {
        IEnumerable<Account> accounts;

        [SetUp]
        public void setup()
        {
            accounts = BankOCR.ReadAccountLines("./testFile1.ocr");
        }

        [Test]
        public void should_be_2_accounts()
        {
            Assert.AreEqual(2, accounts.Count());
        }

        [Test]
        public void first_account_digits_should_match()
        {
            FirstAccount().Digits().Should().Equal(new[] { 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        }

        [Test]
        public void second_account_digits_should_match()
        {
            SecondAccount().Digits().Should().Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        Account SecondAccount()
        {
            return accounts.Last();
        }

        Account FirstAccount()
        {
            return accounts.First();
        }
    }
}
