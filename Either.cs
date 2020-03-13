using System;
using System.Diagnostics.CodeAnalysis;

namespace DUcs
{
    internal sealed class Either<T1, T2> : IChoice<T1, T2>
        where T1 : notnull
        where T2 : notnull
    {
        [AllowNull] private readonly T1 _val1;
        [AllowNull] private readonly T2 _val2;
        private readonly bool _isT1;

        internal Either(T1 value)
        {
            _isT1 = true;
            _val1 = value;
            _val2 = default;
        }

        internal Either(T2 value)
        {
            _isT1 = false;
            _val1 = default;
            _val2 = value;
        }

        public TResult Match<TResult>(
            Func<T1, TResult> caseT1,
            Func<T2, TResult> caseT2)
        {
            if (_isT1) return caseT1.Invoke(_val1);
            else return caseT2.Invoke(_val2);
        }

        public IChoice<T1Result, T2Result> Map<T1Result, T2Result>(
            Func<T1, T1Result> transformator1,
            Func<T2, T2Result> transformator2)
            where T1Result : notnull
            where T2Result : notnull
        {
            return Match(
                v1 => new Either<T1Result, T2Result>(transformator1(v1)),
                v2 => new Either<T1Result, T2Result>(transformator2(v2)));
        }
    }
}
