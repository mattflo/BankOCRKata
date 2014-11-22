using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace BankOCR.Specs
{
    [TestFixture]
    public class UserStory1Spec
    {
        IEnumerable<Account> accounts;

        [SetUp]
        public void setup()
        {
            accounts = BankOCR.ReadAccountLines("./specs/userStory1.ocr");
        }

        [Test]
        public void should_be_11_accounts()
        {
            Assert.AreEqual(11, accounts.Count());
        }

        [Test]
        public void accont_numbers_should_match()
        {
            accounts.Select(a => a.AsString()).Should().Equal( new[]
	    {
	        "000000000",
		"111111111",
		"222222222",
		"333333333",
		"444444444",
		"555555555",
		"666666666",
		"777777777",
		"888888888",
		"999999999",
		"123456789"
	    });
        }
    }
}
