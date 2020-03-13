using DUcs;

namespace Example
{
    public sealed class CheckoutSuccess
    {
        public string Message { get; }

        public CheckoutSuccess(string message)
            => Message = message;
    }

    public sealed class CheckoutResult : Result<CheckoutSuccess>
    {
        public new static readonly CheckoutResult StaticFailure = new CheckoutResult(Failure.Value);

        private CheckoutResult(Failure value)
            : base(value)
        { }

        private CheckoutResult(string message)
            : base(new CheckoutSuccess(message))
        { }

        public static CheckoutResult Success(string message)
            => new CheckoutResult(message);
    }
}
