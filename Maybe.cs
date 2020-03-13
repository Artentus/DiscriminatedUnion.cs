using System;
using System.Diagnostics.CodeAnalysis;

namespace DUcs
{
    internal sealed class Maybe<T> : IOption<T>
        where T : notnull
    {
        [AllowNull] private readonly T _value;
        private readonly bool _hasValue;

        internal static readonly Maybe<T> StaticNone = new Maybe<T>(None.Value);

        private Maybe(None _)
        {
            _value = default;
            _hasValue = false;
        }

        internal Maybe(T value)
        {
            _value = value;
            _hasValue = true;
        }

        public TResult Match<TResult>(
            Func<None, TResult> caseT1,
            Func<T, TResult> caseT2)
        {
            if (_hasValue) return caseT2.Invoke(_value);
            else return caseT1.Invoke(None.Value);
        }

        public TResult Match<TResult>(
            Func<TResult> caseNone,
            Func<T, TResult> caseSome)
        {
            if (_hasValue) return caseSome.Invoke(_value);
            else return caseNone.Invoke();
        }

        public IOption<TResult> Map<TResult>(
            Func<T, TResult> transformator)
            where TResult : notnull
        {
            return Match(
                n => Maybe<TResult>.StaticNone,
                v => new Maybe<TResult>(transformator(v)));
        }
    }
}
