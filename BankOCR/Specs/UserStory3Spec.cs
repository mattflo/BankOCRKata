using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace BankOCR.Specs
{
    [TestFixture]
    public class UserStory3Spec
    {
        IEnumerable<Account> accounts;

        [SetUp]
        public void setup()
        {
            accounts = BankOCR.ReadAccountLines("./specs/userStory3.ocr");
        }

        [Test]
        public void should_be_3_accounts()
        {
            Assert.AreEqual(3, accounts.Count());
        }

        [Test]
        public void first_account_should_report_correctly()
        {
            accounts.First().Report().Should().Be("000000051");
        }

        [Test]
        public void second_account_should_report_correctly()
        {
            accounts.Skip(1).First().Report().Should().Be("49006771? ILL");
        }

        [Test]
        public void third_account_should_report_correctly()
        {
            accounts.Skip(2).First().Report().Should().Be("1234?678? ILL");
        }
    }
}
