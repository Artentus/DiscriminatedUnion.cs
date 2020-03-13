using System;

namespace DUcs
{
    public static class Union
    {
        #region Matching

        // Wraps an action into a Func with a result of None
        private static Func<T, None> Wrap<T>(Action<T> action)
        {
            None inner(T value)
            {
                action.Invoke(value);
                return None.Value;
            }

            return inner;
        }

        // Only first case

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, TResult>(
                    this IUnion<T1, T2, T3> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3>, TResult> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
        {
            return union.Match(
                caseT1,
                v2 => caseElse(new Either<T2, T3>(v2)),
                v3 => caseElse(new Either<T2, T3>(v3)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, TResult>(
            this IUnion<T1, T2, T3, T4> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4>, TResult> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
        {
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4>(v4)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, TResult>(
            this IUnion<T1, T2, T3, T4, T5> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5>, TResult> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5>(v5)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6>, TResult> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v6)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7>, TResult> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v7)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8>, TResult> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v8)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v9)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v10)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v11)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v12)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v13)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v13)),
                v14 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v14)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v13)),
                v14 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v14)),
                v15 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v15)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> union,
            Func<T1, TResult> caseT1,
            Func<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, TResult> caseElse)
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
            return union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v13)),
                v14 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v14)),
                v15 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v15)),
                v16 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v16)));
        }

        // No return value

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2>(
            this IUnion<T1, T2> union,
            Action<T1> caseT1,
            Action<T2> caseT2)
            where T1 : notnull
            where T2 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3>(
            this IUnion<T1, T2, T3> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4>(
            this IUnion<T1, T2, T3, T4> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5>(
            this IUnion<T1, T2, T3, T4, T5> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6>(
            this IUnion<T1, T2, T3, T4, T5, T6> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10,
            Action<T11> caseT11)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10),
                Wrap(caseT11));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10,
            Action<T11> caseT11,
            Action<T12> caseT12)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10),
                Wrap(caseT11),
                Wrap(caseT12));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10,
            Action<T11> caseT11,
            Action<T12> caseT12,
            Action<T13> caseT13)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10),
                Wrap(caseT11),
                Wrap(caseT12),
                Wrap(caseT13));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10,
            Action<T11> caseT11,
            Action<T12> caseT12,
            Action<T13> caseT13,
            Action<T14> caseT14)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10),
                Wrap(caseT11),
                Wrap(caseT12),
                Wrap(caseT13),
                Wrap(caseT14));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10,
            Action<T11> caseT11,
            Action<T12> caseT12,
            Action<T13> caseT13,
            Action<T14> caseT14,
            Action<T15> caseT15)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10),
                Wrap(caseT11),
                Wrap(caseT12),
                Wrap(caseT13),
                Wrap(caseT14),
                Wrap(caseT15));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> union,
            Action<T1> caseT1,
            Action<T2> caseT2,
            Action<T3> caseT3,
            Action<T4> caseT4,
            Action<T5> caseT5,
            Action<T6> caseT6,
            Action<T7> caseT7,
            Action<T8> caseT8,
            Action<T9> caseT9,
            Action<T10> caseT10,
            Action<T11> caseT11,
            Action<T12> caseT12,
            Action<T13> caseT13,
            Action<T14> caseT14,
            Action<T15> caseT15,
            Action<T16> caseT16)
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
            _ = union.Match(
                Wrap(caseT1),
                Wrap(caseT2),
                Wrap(caseT3),
                Wrap(caseT4),
                Wrap(caseT5),
                Wrap(caseT6),
                Wrap(caseT7),
                Wrap(caseT8),
                Wrap(caseT9),
                Wrap(caseT10),
                Wrap(caseT11),
                Wrap(caseT12),
                Wrap(caseT13),
                Wrap(caseT14),
                Wrap(caseT15),
                Wrap(caseT16));
        }

        // Only first case + no return value

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3>(
            this IUnion<T1, T2, T3> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3>> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
        {
            union.Match(
                caseT1,
                v2 => caseElse(new Either<T2, T3>(v2)),
                v3 => caseElse(new Either<T2, T3>(v3)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4>(
            this IUnion<T1, T2, T3, T4> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4>> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
        {
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4>(v4)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5>(
            this IUnion<T1, T2, T3, T4, T5> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5>> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5>(v5)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6>(
            this IUnion<T1, T2, T3, T4, T5, T6> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6>> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6>(v6)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7>> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7>(v7)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8>> caseElse)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8>(v8)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9>(v9)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10>(v10)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v11)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v12)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v13)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v13)),
                v14 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v14)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v13)),
                v14 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v14)),
                v15 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v15)));
        }

        /// <summary>
        /// Pattern matches the value of the union.
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> union,
            Action<T1> caseT1,
            Action<IUnion<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> caseElse)
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
            union.Match(
                caseT1,
                v2 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2)),
                v3 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3)),
                v4 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4)),
                v5 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5)),
                v6 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6)),
                v7 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7)),
                v8 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8)),
                v9 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9)),
                v10 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10)),
                v11 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11)),
                v12 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v12)),
                v13 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v13)),
                v14 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v14)),
                v15 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v15)),
                v16 => caseElse(new AnyOf<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v16)));
        }

        #endregion Matching

        #region Casting

        // To three choices

        /// <summary>
        /// Reinterprets the two-choice union as a three-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3>
            Cast<T1, T2, T3>(
            this IUnion<T1, T2> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3>(v1),
                v2 => new AnyOf<T1, T2, T3>(v2));
        }

        // To four choices

        /// <summary>
        /// Reinterprets the two-choice union as a four-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4>
            Cast<T1, T2, T3, T4>(
            this IUnion<T1, T2> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4>(v1),
                v2 => new AnyOf<T1, T2, T3, T4>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a four-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4>
            Cast<T1, T2, T3, T4>(
            this IUnion<T1, T2, T3> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4>(v1),
                v2 => new AnyOf<T1, T2, T3, T4>(v2),
                v3 => new AnyOf<T1, T2, T3, T4>(v3));
        }

        // To five choices

        /// <summary>
        /// Reinterprets the two-choice union as a five-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5>
            Cast<T1, T2, T3, T4, T5>(
            this IUnion<T1, T2> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a five-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5>
            Cast<T1, T2, T3, T4, T5>(
            this IUnion<T1, T2, T3> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a five-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5>
            Cast<T1, T2, T3, T4, T5>(
            this IUnion<T1, T2, T3, T4> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5>(v4));
        }

        // To six choices

        /// <summary>
        /// Reinterprets the two-choice union as a six-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6>
            Cast<T1, T2, T3, T4, T5, T6>(
            this IUnion<T1, T2> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a six-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6>
            Cast<T1, T2, T3, T4, T5, T6>(
            this IUnion<T1, T2, T3> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a six-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6>
            Cast<T1, T2, T3, T4, T5, T6>(
            this IUnion<T1, T2, T3, T4> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a six-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6>
            Cast<T1, T2, T3, T4, T5, T6>(
            this IUnion<T1, T2, T3, T4, T5> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6>(v5));
        }

        // To seven choices

        /// <summary>
        /// Reinterprets the two-choice union as a seven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7>
            Cast<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a seven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7>
            Cast<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2, T3> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a seven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7>
            Cast<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2, T3, T4> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a seven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7>
            Cast<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2, T3, T4, T5> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a seven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7>
            Cast<T1, T2, T3, T4, T5, T6, T7>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(v6));
        }

        // To eight choices

        /// <summary>
        /// Reinterprets the two-choice union as an eight-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as an eight-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as an eight-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3, T4> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as an eight-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3, T4, T5> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as an eight-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as an eight-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>(v7));
        }

        // To nine choices

        /// <summary>
        /// Reinterprets the two-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a nine-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v8));
        }

        // To ten choices

        /// <summary>
        /// Reinterprets the two-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as a ten-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v9));
        }

        // To eleven choices

        /// <summary>
        /// Reinterprets the two-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v9));
        }

        /// <summary>
        /// Reinterprets the ten-choice union as an eleven-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v10));
        }

        // To twelve choices

        /// <summary>
        /// Reinterprets the two-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v9));
        }

        /// <summary>
        /// Reinterprets the ten-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v10));
        }

        /// <summary>
        /// Reinterprets the eleven-choice union as a twelve-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v11));
        }

        // To thirteen choices

        /// <summary>
        /// Reinterprets the two-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v9));
        }

        /// <summary>
        /// Reinterprets the ten-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v10));
        }

        /// <summary>
        /// Reinterprets the eleven-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v11));
        }

        /// <summary>
        /// Reinterprets the twelve-choice union as a thirteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v12));
        }

        // To fourteen choices

        /// <summary>
        /// Reinterprets the two-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9));
        }

        /// <summary>
        /// Reinterprets the ten-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v10));
        }

        /// <summary>
        /// Reinterprets the eleven-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v11));
        }

        /// <summary>
        /// Reinterprets the twelve-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v12));
        }

        /// <summary>
        /// Reinterprets the thirteen-choice union as a fourteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v12),
                v13 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v13));
        }

        // To fifteen choices

        /// <summary>
        /// Reinterprets the two-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9));
        }

        /// <summary>
        /// Reinterprets the ten-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10));
        }

        /// <summary>
        /// Reinterprets the eleven-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v11));
        }

        /// <summary>
        /// Reinterprets the twelve-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v12));
        }

        /// <summary>
        /// Reinterprets the thirteen-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v12),
                v13 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v13));
        }

        /// <summary>
        /// Reinterprets the fourteen-choice union as a fifteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v12),
                v13 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v13),
                v14 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v14));
        }

        // To sixteen choices

        /// <summary>
        /// Reinterprets the two-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2));
        }

        /// <summary>
        /// Reinterprets the three-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3));
        }

        /// <summary>
        /// Reinterprets the four-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4));
        }

        /// <summary>
        /// Reinterprets the five-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5));
        }

        /// <summary>
        /// Reinterprets the six-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6));
        }

        /// <summary>
        /// Reinterprets the seven-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7));
        }

        /// <summary>
        /// Reinterprets the eight-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8));
        }

        /// <summary>
        /// Reinterprets the nine-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9));
        }

        /// <summary>
        /// Reinterprets the ten-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10));
        }

        /// <summary>
        /// Reinterprets the eleven-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11));
        }

        /// <summary>
        /// Reinterprets the twelve-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v12));
        }

        /// <summary>
        /// Reinterprets the thirteen-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v12),
                v13 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v13));
        }

        /// <summary>
        /// Reinterprets the fourteen-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v12),
                v13 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v13),
                v14 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v14));
        }

        /// <summary>
        /// Reinterprets the fifteen-choice union as a sixteen-choice union.
        /// </summary>
        public static IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Cast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> union)
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
            return union.Match(
                v1 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1),
                v2 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v2),
                v3 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v3),
                v4 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v4),
                v5 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v5),
                v6 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v6),
                v7 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v7),
                v8 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v8),
                v9 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v9),
                v10 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v10),
                v11 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v11),
                v12 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v12),
                v13 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v13),
                v14 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v14),
                v15 => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v15));
        }

        #endregion Casting
    }
}
