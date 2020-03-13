using System;

namespace DUcs
{
    /// <summary>
    /// Standard implementation of a discriminated union with four choices
    /// </summary>
    public class AnyOf<T1, T2, T3, T4>
        : AnyOfBase, IUnion<T1, T2, T3, T4>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
    {
        public AnyOf(T1 value)
            : base(1, value)
        { }

        public AnyOf(T2 value)
            : base(2, value)
        { }

        public AnyOf(T3 value)
            : base(3, value)
        { }

        public AnyOf(T4 value)
            : base(4, value)
        { }

        // Any value of a type in the union is implicitely also an instance of the union
        public static implicit operator AnyOf<T1, T2, T3, T4>(T1 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4>(T2 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4>(T3 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4>(T4 value) => new AnyOf<T1, T2, T3, T4>(value);

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4)
        {
            return MatchInternal(
                ToCase(caseT1),
                ToCase(caseT2),
                ToCase(caseT3),
                ToCase(caseT4));
        }
    }
}
