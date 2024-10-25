using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        [TestCase(100, 50, 50, TestName = "Withdraw 50%")]
        [TestCase(1000, 1000, 0, TestName = "Withdraw 100%")]
        [TestCase(250, 1, 249, TestName = "Withdraw $1")]

        [Test]
        public void CreateNewSavingsAccount_DepositXThenWithdrawY_BalanceShouldBeXMinusY
            (int depositAmt, int withdrawAmt, int expectedBalance)
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(depositAmt);
            account.Withdraw(withdrawAmt);

            Assert.That(account.Balance, Is.EqualTo(expectedBalance));
        }
    }
}
