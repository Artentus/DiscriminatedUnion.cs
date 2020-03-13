using System;

namespace DUcs
{
    /// <summary>
    /// Represents a discriminated union with two choices.
    /// </summary>
    public interface IUnion<out T1, out T2>
        where T1 : notnull
        where T2 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2);
    }

    /// <summary>
    /// Represents a discriminated union with three choices.
    /// </summary>
    public interface IUnion<out T1, out T2, out T3>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3);
    }

    /// <summary>
    /// Represents a discriminated union with four choices.
    /// </summary>
    public interface IUnion<out T1, out T2, out T3, out T4>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4);
    }

    /// <summary>
    /// Represents a discriminated union with five choices.
    /// </summary>
    public interface IUnion<out T1, out T2, out T3, out T4, out T5>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5);
    }

    /// <summary>
    /// Represents a discriminated union with six choices.
    /// </summary>
    public interface IUnion<out T1, out T2, out T3, out T4, out T5, out T6>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6);
    }

    /// <summary>
    /// Represents a discriminated union with seven choices.
    /// </summary>
    public interface IUnion<out T1, out T2, out T3, out T4, out T5, out T6, out T7>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
        where T7 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6,
            Func<T7, TResult> caseT7);
    }

    /// <summary>
    /// Represents a discriminated union with eight choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
        where T7 : notnull
        where T8 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6,
            Func<T7, TResult> caseT7,
            Func<T8, TResult> caseT8);
    }

    /// <summary>
    /// Represents a discriminated union with nine choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8, out T9>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
        where T7 : notnull
        where T8 : notnull
        where T9 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6,
            Func<T7, TResult> caseT7,
            Func<T8, TResult> caseT8,
            Func<T9, TResult> caseT9);
    }

    /// <summary>
    /// Represents a discriminated union with ten choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8, out T9, out T10>
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
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2,
            Func<T3, TResult> caseT3,
            Func<T4, TResult> caseT4,
            Func<T5, TResult> caseT5,
            Func<T6, TResult> caseT6,
            Func<T7, TResult> caseT7,
            Func<T8, TResult> caseT8,
            Func<T9, TResult> caseT9,
            Func<T10, TResult> caseT10);
    }

    /// <summary>
    /// Represents a discriminated union with eleven choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8, out T9, out T10, out T11>
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
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
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
            Func<T11, TResult> caseT11);
    }

    /// <summary>
    /// Represents a discriminated union with twelve choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8,
        out T9, out T10, out T11, out T12>
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
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
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
            Func<T12, TResult> caseT12);
    }

    /// <summary>
    /// Represents a discriminated union with thirteen choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8,
        out T9, out T10, out T11, out T12, out T13>
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
        where T13 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
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
            Func<T12, TResult> caseT12,
            Func<T13, TResult> caseT13);
    }

    /// <summary>
    /// Represents a discriminated union with fourteen choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8,
        out T9, out T10, out T11, out T12, out T13, out T14>
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
        where T13 : notnull
        where T14 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
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
            Func<T12, TResult> caseT12,
            Func<T13, TResult> caseT13,
            Func<T14, TResult> caseT14);
    }

    /// <summary>
    /// Represents a discriminated union with fifteen choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8,
        out T9, out T10, out T11, out T12, out T13, out T14, out T15>
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
        where T13 : notnull
        where T14 : notnull
        where T15 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
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
            Func<T12, TResult> caseT12,
            Func<T13, TResult> caseT13,
            Func<T14, TResult> caseT14,
            Func<T15, TResult> caseT15);
    }

    /// <summary>
    /// Represents a discriminated union with sixteen choices.
    /// </summary>
    public interface IUnion<
        out T1, out T2, out T3, out T4,
        out T5, out T6, out T7, out T8,
        out T9, out T10, out T11, out T12,
        out T13, out T14, out T15, out T16>
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
        where T13 : notnull
        where T14 : notnull
        where T15 : notnull
        where T16 : notnull
    {
        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        TResult Match<TResult>(
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
            Func<T12, TResult> caseT12,
            Func<T13, TResult> caseT13,
            Func<T14, TResult> caseT14,
            Func<T15, TResult> caseT15,
            Func<T16, TResult> caseT16);
    }
}
