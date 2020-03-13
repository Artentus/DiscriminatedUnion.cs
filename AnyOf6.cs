using System;

namespace DUcs
{
    /// <summary>
    /// Standard implementation of a discriminated union with six choices
    /// </summary>
    public class AnyOf<T1, T2, T3, T4, T5, T6>
        : AnyOfBase, IUnion<T1, T2, T3, T4, T5, T6>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
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

        public AnyOf(T5 value)
            : base(5, value)
        { }

        public AnyOf(T6 value)
            : base(6, value)
        { }

        // Any value of a type in the union is implicitely also an instance of the union
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6>(T1 value) => new AnyOf<T1, T2, T3, T4, T5, T6>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6>(T2 value) => new AnyOf<T1, T2, T3, T4, T5, T6>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6>(T3 value) => new AnyOf<T1, T2, T3, T4, T5, T6>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6>(T4 value) => new AnyOf<T1, T2, T3, T4, T5, T6>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6>(T5 value) => new AnyOf<T1, T2, T3, T4, T5, T6>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6>(T6 value) => new AnyOf<T1, T2, T3, T4, T5, T6>(value);

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6)
        {
            return MatchInternal(
                ToCase(caseT1),
                ToCase(caseT2),
                ToCase(caseT3),
                ToCase(caseT4),
                ToCase(caseT5),
                ToCase(caseT6));
        }
    }
}
