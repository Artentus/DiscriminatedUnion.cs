using DUcs;
using System;

namespace Example
{
    internal class Program
    {
        // ----------------------------------------------------------------------
        //  This is a dummy-implementation of how using discriminated unions
        //  can look like. By using pattern matching at all stages of processing
        //  we ensure all possible cases are handled properly. We also get
        //  unintrusive error handling without any exceptions and try-catch.
        // ----------------------------------------------------------------------
        //  This example uses custom implementations of discriminated unions,
        //  which is useful to communicate intent in your code. However, the
        //  existing type AnyOf can be used in a similar way with the benefit of
        //  no additional code being required. In many cases using AnyOf will
        //  not significantly reduce readability of the code.
        // ----------------------------------------------------------------------

        private static void Main()
        {
            var payment = PayRandom();
            var result = Checkout(payment);
            result.Match(
                () => Console.WriteLine("Checkout failed!"),
                success => Console.WriteLine("Checking out with " + success.Message));
        }

        private static Payment PayWithCash(decimal amount)
            => new Payment(amount, PaymentMethod.StaticCash);

        private static Payment PayWithCheck(decimal amount, int checkNumber)
            => new Payment(amount, new PaymentMethod(checkNumber));

        private static Payment PayWithCard(decimal amount, int cardNumber, CardType cardType)
            => new Payment(amount, new PaymentMethod(cardNumber, cardType));

        private static int NextNumber(Random rnd)
            => rnd.Next(100000, 999999);

        private static CardType NextCardType(Random rnd)
            => rnd.Next(0, 1) == 0 ? CardType.StaticVisa : CardType.StaticMasterCard;

        private static Payment PayRandom()
        {
            var rnd = new Random();
            decimal amount = (decimal)(rnd.NextDouble() * 100);

            int val = rnd.Next(0, 2);
            if (val == 0) return PayWithCash(amount);
            else if (val == 1) return PayWithCheck(amount, NextNumber(rnd));
            else return PayWithCard(amount, NextNumber(rnd), NextCardType(rnd));
        }

        private static CheckoutResult CheckoutWithCash(decimal amount)
            => CheckoutResult.Success("cash for " + amount.ToString("#.00") + "$");

        private static CheckoutResult CheckoutWithCheck(decimal amount, Check check)
        {
            if (check.Number.ToString().EndsWith('7'))
                return CheckoutResult.StaticFailure;

            return CheckoutResult.Success("check for " + amount.ToString("#.00") + "$");
        }

        private static CheckoutResult ValidateVisa(int number)
        {
            if (number.ToString().EndsWith('3'))
                return CheckoutResult.StaticFailure;

            return CheckoutResult.Success("Visa");
        }

        private static CheckoutResult ValidateMasterCard(int number)
        {
            if (number.ToString().EndsWith('9'))
                return CheckoutResult.StaticFailure;

            return CheckoutResult.Success("MasterCard");
        }

        private static CheckoutResult CheckoutWithCard(decimal amount, Card card)
        {
            var result = card.Type.Match(
                visa => ValidateVisa(card.Number),
                masterCard => ValidateMasterCard(card.Number));

            CheckoutResult checkoutWithValidCard(CheckoutSuccess success)
                => CheckoutResult.Success("with " + success.Message + " for " + amount.ToString("#.00") + "$");

            return result.Bind<CheckoutResult, CheckoutSuccess>(checkoutWithValidCard);
        }

        private static CheckoutResult Checkout(Payment payment)
        {
            return payment.Method.Match(
                cash => CheckoutWithCash(payment.Amount),
                check => CheckoutWithCheck(payment.Amount, check),
                card => CheckoutWithCard(payment.Amount, card));
        }
    }
}
