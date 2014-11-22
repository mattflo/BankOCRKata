using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace BankOCR.Specs
{
    [TestFixture]
    public class UserStory2Spec
    {
        IEnumerable<Account> accounts;

        [SetUp]
        public void setup()
        {
            accounts = BankOCR.ReadAccountLines("./specs/userStory2.ocr");
        }

        [Test]
        public void should_be_6_accounts()
        {
            Assert.AreEqual(6, accounts.Count());
        }

        [Test]
        public void should_be_valid()
        {
            accounts.First().IsValid().Should().BeTrue();
            accounts.Skip(1).First().IsValid().Should().BeTrue();
            accounts.Skip(2).First().IsValid().Should().BeTrue();
        }

        [Test]
        public void should_be_invalid()
        {
            accounts.Skip(3).First().IsValid().Should().BeFalse();
            accounts.Skip(4).First().IsValid().Should().BeFalse();
            accounts.Skip(5).First().IsValid().Should().BeFalse();
        }
    }
}
