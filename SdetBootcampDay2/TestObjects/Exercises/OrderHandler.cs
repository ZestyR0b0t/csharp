namespace SdetBootcampDay2.TestObjects.Exercises
{
    public class OrderHandler
    {
        private IDictionary<OrderItem, int>? _stock = new Dictionary<OrderItem, int>();
        private readonly IPaymentProcessor _paymentProcessor;

        /**
         * TODO: can you apply Dependency Inversion here to make this code more flexible,
         * allowing users to inject the stock, and thereby make the code easier to test?
         * Do the same for the PaymentProcessor. You do not need to create interfaces as
         * was shown in the example (although if you want to, be my guest!)
         * After you have done that, update the existing tests and add the tests that were
         * not possible before.
         */
        public OrderHandler(IPaymentProcessor paymentProcessor, IDictionary<OrderItem, int>? stock)
        {
            this._paymentProcessor = paymentProcessor;
            this._stock = stock;
        }

        /**
         * TODO: this method clearly violates the Single Responsibility Principle
         * Can you refactor the code to resolve that? Don't forget to also update the tests.
         */
        public void Order(OrderItem item, int quantity)
        {
            if (!this._stock!.TryGetValue(item, out int result))
            {
                throw new ArgumentException($"Unknown item {item}");
            }

            if (this._stock[item] < quantity)
            {
                throw new ArgumentException($"Insufficient stock for item {item}");
            }

            this._stock[item] -= quantity;
        }

        public bool Pay(OrderItem item, int quantity)
        {
            return this._paymentProcessor.PayFor(item, quantity);
        }

        public void AddStock(OrderItem item, int quantity)
        {
            if (!this._stock!.TryGetValue(item, out int result))
            {
                throw new ArgumentException($"Unknown item {item}");
            }

            this._stock[item] += quantity;
        }

        public int GetStockFor(OrderItem item)
        {
            if (!this._stock!.TryGetValue(item, out int result))
            {
                throw new ArgumentException($"Unknown item {item}");
            }

            return this._stock[item]; 
        }
    }
}
