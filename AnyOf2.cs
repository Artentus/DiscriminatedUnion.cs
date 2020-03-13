using System;

namespace DUcs
{
    /// <summary>
    /// Standard implementation of a discriminated union with two choices
    /// </summary>
    public class AnyOf<T1, T2>
        : AnyOfBase, IUnion<T1, T2>
        where T1 : notnull
        where T2 : notnull
    {
        public AnyOf(T1 value)
            : base(1, value)
        { }

        public AnyOf(T2 value)
            : base(2, value)
        { }

        // Any value of a type in the union is implicitely also an instance of the union
        public static implicit operator AnyOf<T1, T2>(T1 value) => new AnyOf<T1, T2>(value);

        public static implicit operator AnyOf<T1, T2>(T2 value) => new AnyOf<T1, T2>(value);

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2)
        {
            return MatchInternal(
                ToCase(caseT1),
                ToCase(caseT2));
        }
    }
}
