using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises03
    {
        [Test]
        public void TryingToOverdrawOnASavingsAccountThrowsExpectedException()
        {
            Account account = new Account(AccountType.Savings);

            account.Deposit(50);

            var argEx = Assert.Throws<ArgumentException>(() =>
            {
                account.Withdraw(100);
            });
            Assert.That(argEx.Message, Is.EqualTo("You cannot overdraw on a savings account"));
            Assert.That(account.Balance, Is.EqualTo(50));
        }
    }
}
