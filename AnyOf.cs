namespace DUcs
{
    public static class AnyOf
    {
        public static AnyOf<T1, T2, T3>
            FromUnion<T1, T2, T3>(
            IUnion<T1, T2, T3> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
        {
            if (union is AnyOf<T1, T2, T3> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3);
            }
        }

        public static AnyOf<T1, T2, T3, T4>
            FromUnion<T1, T2, T3, T4>(
            IUnion<T1, T2, T3, T4> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
        {
            if (union is AnyOf<T1, T2, T3, T4> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5>
            FromUnion<T1, T2, T3, T4, T5>(
            IUnion<T1, T2, T3, T4, T5> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
        {
            if (union is AnyOf<T1, T2, T3, T4, T5> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6>
            FromUnion<T1, T2, T3, T4, T5, T6>(
            IUnion<T1, T2, T3, T4, T5, T6> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
        {
            if (union is AnyOf<T1, T2, T3, T4, T5, T6> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7>
            FromUnion<T1, T2, T3, T4, T5, T6, T7>(
            IUnion<T1, T2, T3, T4, T5, T6, T7> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
        {
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8> union)
            where T1 : notnull
            where T2 : notnull
            where T3 : notnull
            where T4 : notnull
            where T5 : notnull
            where T6 : notnull
            where T7 : notnull
            where T8 : notnull
        {
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10,
                    v11 => v11);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10,
                    v11 => v11,
                    v12 => v12);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10,
                    v11 => v11,
                    v12 => v12,
                    v13 => v13);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10,
                    v11 => v11,
                    v12 => v12,
                    v13 => v13,
                    v14 => v14);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10,
                    v11 => v11,
                    v12 => v12,
                    v13 => v13,
                    v14 => v14,
                    v15 => v15);
            }
        }

        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            FromUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            IUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> union)
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
            if (union is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> anyOf)
            {
                return anyOf;
            }
            else
            {
                return union.Match<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                    v1 => v1,
                    v2 => v2,
                    v3 => v3,
                    v4 => v4,
                    v5 => v5,
                    v6 => v6,
                    v7 => v7,
                    v8 => v8,
                    v9 => v9,
                    v10 => v10,
                    v11 => v11,
                    v12 => v12,
                    v13 => v13,
                    v14 => v14,
                    v15 => v15,
                    v16 => v16);
            }
        }
    }
}
