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
        public void should_be_3_accounts()
        {
            Assert.AreEqual(4, accounts.Count());
        }

        [Test]
        public void first_account_as_string_should_match()
        {
            FirstAccount().AsString().Should().Be("234567880");
        }

        [Test]
        public void first_account_digits_should_match()
        {
            FirstAccount().Digits().Should().Equal(new[] { 2, 3, 4, 5, 6, 7, 8, 8, 0 });
        }

        [Test]
        public void second_account_digits_should_match()
        {
            SecondAccount().Digits().Should().Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        [Test]
        public void it_considers_every_digit_in_the_checksum()
        {
            accounts.Last().Checksum().Should().Be(45);
        }

        [Test]
        public void first_account_checksum_should_be_200()
        {
            FirstAccount().Checksum().Should().Be(198);
        }

        [Test]
        public void first_two_accounts_are_legible()
        {
            FirstAccount().Legible().Should().BeTrue();
            SecondAccount().Legible().Should().BeTrue();
        }

        [Test]
        public void third_account_should_be_invalid()
        {
            ThirdAccount().Legible().Should().BeFalse();
        }

        [Test]
        public void third_account_as_string_should_match()
        {
            ThirdAccount().AsString().Should().Be("?23456789");
        }

        Account ThirdAccount()
        {
            return accounts.Skip(2).First();
        }

        Account SecondAccount()
        {
            return accounts.Skip(1).First();
        }

        Account FirstAccount()
        {
            return accounts.First();
        }
    }
}
