using System;
using System.Diagnostics.CodeAnalysis;

namespace DUcs
{
    public abstract class AnyOfBase
    {
        internal interface ICase<out TResult>
        {
            void SetValue(object value);

            TResult Invoke();
        }

        private sealed class Case<T, TResult> : ICase<TResult>
            where T : notnull
        {
            private readonly Func<T, TResult> _caseFunc;
            [AllowNull] private T _value;

            public Case(Func<T, TResult> caseFunc)
                => (_caseFunc, _value) = (caseFunc, default);

            public TResult Invoke()
                => _caseFunc.Invoke(_value);

            public void SetValue(object value)
                => _value = (T)value;
        }

        private readonly int _tag;

        private readonly object _value;

        internal AnyOfBase(int tag, object value)
            => (_tag, _value) = (tag, value);

        internal static ICase<TResult> ToCase<T, TResult>(
            Func<T, TResult> func)
            where T : notnull
            => new Case<T, TResult>(func);

        internal TResult MatchInternal<TResult>(
            params ICase<TResult>[] cases)
        {
            var actualCase = cases[_tag - 1];
            actualCase.SetValue(_value);
            return actualCase.Invoke();
        }
    }
}
