﻿using Moq;
using NUnit.Framework;

namespace SdetBootcampDay2.Exercises
{
    // [TestFixture]
    // public class Exercises02
    // {
    //     [Test]
    //     public void MockPaymentProcessor_ReturnFalseForAllStripePayments()
    //     {
    //         Dictionary<OrderItem, int> stock = new Dictionary<OrderItem, int>
    //         {
    //             { OrderItem.FIFA_24, 10 }
    //         };

    //         /**
    //          * TODO: Create a mock object representing the payment processor. Pass in Stripe
    //          * as the payment processor type. Set up the mock so that a call to PayFor() with
    //          * FIFA 24 and 10 as arguments returns false.
    //          */
    //         var mockProcessor = new Mock<PaymentProcessor>(PaymentProcessorType.Stripe);
    //         //mockProcessor.Setup(x => x.PayFor(OrderItem.FIFA_24, 10)).Returns(true);


    //         /**
    //          * TODO: Complete the test by creating a new OrderHandler, passing in the mock object
    //          * for the payment processor. Call the Order() method and then assert that the PayFor()
    //          * method of the OrderHandler returns false
    //          */
    //         var orderHandler = new OrderHandler(stock, mockProcessor.Object);
    //         orderHandler.Order(OrderItem.FIFA_24, 10);
    //         Assert.That(orderHandler.PayFor(OrderItem.FIFA_24, 10), Is.EqualTo(false));


    //         /**
    //          * TODO: verify that the PayFor() method of the mock payment processor was called
    //          * exactly once with FIFA_24 and 10 as parameters.
    //          */
    //         mockProcessor.Verify(x => x.PayFor(OrderItem.FIFA_24, 10), Times.Once());
    //     }
    // }
}
