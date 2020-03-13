using DUcs;

namespace Example
{
    // The cash choice doesn't hold any data so we implement it as singleton.
    public sealed class Cash
    {
        public static readonly Cash Value = new Cash();

        private Cash()
        { }
    }

    // The check choice is a normal record type.
    public sealed class Check
    {
        public int Number { get; }

        public Check(int number)
            => Number = number;
    }

    // There are two possible choices for card types.
    public sealed class Visa
    {
        public static readonly Visa Value = new Visa();

        private Visa()
        { }
    }

    public sealed class MasterCard
    {
        public static readonly MasterCard Value = new MasterCard();

        private MasterCard()
        { }
    }

    public sealed class CardType : AnyOf<Visa, MasterCard>
    {
        public static readonly CardType StaticVisa = new CardType(Visa.Value);
        public static readonly CardType StaticMasterCard = new CardType(MasterCard.Value);

        private CardType(Visa value)
            : base(value)
        { }

        private CardType(MasterCard value)
            : base(value)
        { }
    }

    // The card choice is a record type which itself contains another choice.
    public sealed class Card
    {
        public int Number { get; }

        public CardType Type { get; }

        public Card(int number, CardType type)
            => (Number, Type) = (number, type);
    }

    // There are three possible choices as paiment method: cash, check and card.
    public sealed class PaymentMethod : AnyOf<Cash, Check, Card>
    {
        public static readonly PaymentMethod StaticCash = new PaymentMethod(Cash.Value);

        private PaymentMethod(Cash value)
            : base(value)
        { }

        public PaymentMethod(int checkNumber)
            : base(new Check(checkNumber))
        { }

        public PaymentMethod(int cardNumber, CardType cardType)
            : base(new Card(cardNumber, cardType))
        { }
    }
}
