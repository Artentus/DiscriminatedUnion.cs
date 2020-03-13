using System;

namespace DUcs
{
    /// <summary>
    /// Represents a choice between a type or None.
    /// </summary>
    public interface IOption<out T>
        : IUnion<None, T>
        where T : notnull
    {
        /// <summary>
        /// Pattern matches the value of the option.
        /// </summary>
        TResult Match<TResult>(
            Func<TResult> caseNone,
            Func<T, TResult> caseSome);

        /// <summary>
        /// Maps the value to a different type, if it is set.
        /// </summary>
        IOption<TResult> Map<TResult>(
            Func<T, TResult> transformator)
            where TResult : notnull;
    }

    public static class Option
    {
        /// <summary>
        /// An Option with a value of None.
        /// </summary>
        public static IOption<T> None<T>()
            where T : notnull
            => Maybe<T>.StaticNone;

        /// <summary>
        /// Wraps a value into an Option.
        /// </summary>
        public static IOption<T> FromValue<T>(T value)
            where T : notnull
            => new Maybe<T>(value);

        /// <summary>
        /// Converts the Nullable into an Option.
        /// </summary>
        public static IOption<T> ToOption<T>(this T? nullable)
            where T : struct
        {
            if (nullable.HasValue) return FromValue(nullable.Value);
            else return None<T>();
        }

        /// <summary>
        /// Converts the reference, which may be null, into an Option.
        /// </summary>
        public static IOption<T> ToOption<T>(this T? obj)
            where T : class
        {
            if (obj is null) return None<T>();
            else return FromValue(obj);
        }
    }
}
