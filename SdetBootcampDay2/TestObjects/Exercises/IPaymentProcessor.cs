namespace SdetBootcampDay2.TestObjects.Exercises
{
    public interface IPaymentProcessor
    {
        bool PayFor(OrderItem item, int quantity);
    }
}