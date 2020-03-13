namespace Example
{
    // A paiment is a record type with amount and paiment method choice.
    public sealed class Payment
    {
        public decimal Amount { get; }

        public PaymentMethod Method { get; }

        public Payment(decimal amount, PaymentMethod method)
            => (Amount, Method) = (amount, method);
    }
}
