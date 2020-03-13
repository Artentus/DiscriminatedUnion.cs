using System;

namespace DUcs
{
    /// <summary>
    /// Represents a choice between two types.
    /// </summary>
    public interface IChoice<out T1, out T2>
        : IUnion<T1, T2>
        where T1 : notnull
        where T2 : notnull
    {
        /// <summary>
        /// Maps the values to different types.
        /// </summary>
        IChoice<T1Result, T2Result> Map<T1Result, T2Result>(
            Func<T1, T1Result> transformator1,
            Func<T2, T2Result> transformator2)
            where T1Result : notnull
            where T2Result : notnull;
    }
}
