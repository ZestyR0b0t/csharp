﻿using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises01
    {
        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit200_ThenBalanceShouldBe200()
        {
            var account = new Account(AccountType.Checking);

            account.Deposit(200);

            /**
             * TODO: add an assertion that verifies that the resulting balance is 200.
             */
            Assert.That(account.Balance, Is.EqualTo(200));
            /**
             * TODO: add an assertion that verifies that the resulting balance is greater than 199.
             */
            Assert.That(account.Balance, Is.GreaterThan(199));
        }

        [Test]
        public void GivenANewSavingsAccount_WhenIDeposit200AndWithdraw100_ThenBalanceShouldBe100()
        {
            /**
             * TODO: create a new savings account
             */
             var savingsAccount = new Account(AccountType.Savings);

            /**
             * TODO: first, deposit 200 dollars, then immediately withdraw 100 dollars again.
             */
            savingsAccount.Deposit(200);
            savingsAccount.Withdraw(100);

            /**
             * TODO: assert that the resulting balance is equal to 100.
             */
            Assert.That(savingsAccount.Balance, Is.EqualTo(100));
        }

        /**
         * TODO: Write a third test method that performs the following steps:
         * - Create a new checking account
         * - Deposit 100 dollars
         * - Withdraw 200 dollars
         * - Check that the resulting balance is -100 dollars
         */
        
        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit100AndWithdraw200_ThenBalanceShouldBeNeg100()
        {
            var checkingAccount = new Account(AccountType.Checking);

            checkingAccount.Deposit(100);
            checkingAccount.Withdraw(200);

            Assert.That(checkingAccount.Balance, Is.EqualTo(-100));
        }
    }
}