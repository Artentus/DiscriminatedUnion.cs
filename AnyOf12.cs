using System;

namespace DUcs
{
    /// <summary>
    /// Standard implementation of a discriminated union with twelve choices
    /// </summary>
    public class AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        : AnyOfBase, IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
        where T7 : notnull
        where T8 : notnull
        where T9 : notnull
        where T10 : notnull
        where T11 : notnull
        where T12 : notnull
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

        public AnyOf(T7 value)
            : base(7, value)
        { }

        public AnyOf(T8 value)
            : base(8, value)
        { }

        public AnyOf(T9 value)
            : base(9, value)
        { }

        public AnyOf(T10 value)
            : base(10, value)
        { }

        public AnyOf(T11 value)
            : base(11, value)
        { }

        public AnyOf(T12 value)
            : base(12, value)
        { }

        // Any value of a type in the union is implicitely also an instance of the union
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6,
            Func<T7, TResult> caseT7,
            Func<T8, TResult> caseT8,
            Func<T9, TResult> caseT9,
            Func<T10, TResult> caseT10,
            Func<T11, TResult> caseT11,
            Func<T12, TResult> caseT12)
        {
            return MatchInternal(
                ToCase(caseT1),
                ToCase(caseT2),
                ToCase(caseT3),
                ToCase(caseT4),
                ToCase(caseT5),
                ToCase(caseT6),
                ToCase(caseT7),
                ToCase(caseT8),
                ToCase(caseT9),
                ToCase(caseT10),
                ToCase(caseT11),
                ToCase(caseT12));
        }
    }
}
