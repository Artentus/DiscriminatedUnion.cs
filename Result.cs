using System;
using System.Diagnostics.CodeAnalysis;

namespace DUcs
{
    /// <summary>
    /// A choice between either a failure or a success.
    /// </summary>
    public class Result<TFailure, TSuccess> : IChoice<TFailure, TSuccess>
        where TFailure : notnull
        where TSuccess : notnull
    {
        [AllowNull] private readonly TFailure _failVal;
        [AllowNull] private readonly TSuccess _sucVal;
        private readonly bool _success;

        public Result(TFailure value)
        {
            _success = false;
            _sucVal = default;
            _failVal = value;
        }

        public Result(TSuccess value)
        {
            _success = true;
            _sucVal = value;
            _failVal = default;
        }

        public static implicit operator Result<TFailure, TSuccess>(TFailure value) => new Result<TFailure, TSuccess>(value);

        public static implicit operator Result<TFailure, TSuccess>(TSuccess value) => new Result<TFailure, TSuccess>(value);

        /// <summary>
        /// Pattern matches the value of the result.
        /// </summary>
        public TResult Match<TResult>(
            Func<TFailure, TResult> caseFailure,
            Func<TSuccess, TResult> caseSuccess)
        {
            if (_success) return caseSuccess.Invoke(_sucVal);
            else return caseFailure.Invoke(_failVal);
        }

        public Result<T1Result, T2Result> Map<T1Result, T2Result>(
            Func<TFailure, T1Result> failureTransformator,
            Func<TSuccess, T2Result> successTransformator)
            where T1Result : notnull
            where T2Result : notnull
        {
            return Match(
                v1 => new Result<T1Result, T2Result>(failureTransformator(v1)),
                v2 => new Result<T1Result, T2Result>(successTransformator(v2)));
        }

        IChoice<T1Result, T2Result> IChoice<TFailure, TSuccess>.Map<T1Result, T2Result>(
            Func<TFailure, T1Result> transformator1,
            Func<TSuccess, T2Result> transformator2)
            => Map(transformator1, transformator2);
    }

    /// <summary>
    /// A choice between either a failure or a success.
    /// </summary>
    public class Result<TSuccess> : Result<Failure, TSuccess>
        where TSuccess : notnull
    {
        public static readonly Result<TSuccess> StaticFailure = new Result<TSuccess>(Failure.Value);

        protected Result(Failure value)
            : base(value)
        { }

        public Result(TSuccess value)
            : base(value)
        { }

        public static implicit operator Result<TSuccess>(Failure _) => StaticFailure;

        public static implicit operator Result<TSuccess>(TSuccess value) => new Result<TSuccess>(value);

        /// <summary>
        /// Pattern matches the value of the result.
        /// </summary>
        public TResult Match<TResult>(
            Func<TResult> caseFailure,
            Func<TSuccess, TResult> caseSuccess)
        {
            return Match(
                fail => caseFailure.Invoke(),
                suc => caseSuccess.Invoke(suc));
        }

        /// <summary>
        /// Pattern matches the value of the result.
        /// </summary>
        public void Match(
            Action caseFailure,
            Action<TSuccess> caseSuccess)
        {
            None matchFail()
            {
                caseFailure.Invoke();
                return None.Value;
            }

            None matchSucc(TSuccess value)
            {
                caseSuccess.Invoke(value);
                return None.Value;
            }

            _ = Match(matchFail, matchSucc);
        }

        public Result<TResult> Map<TResult>(
            Func<TSuccess, TResult> successTransformator)
            where TResult : notnull
        {
            return Match(
                v1 => Result<TResult>.StaticFailure,
                v2 => new Result<TResult>(successTransformator(v2)));
        }
    }
}
