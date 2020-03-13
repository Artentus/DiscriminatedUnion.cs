using System;

namespace DUcs
{
    public readonly struct None : IEquatable<None>
    {
        public static readonly None Value = default;

        public static bool operator ==(None first, None second) => true;

        public static bool operator !=(None first, None second) => false;

        public bool Equals(None _) => true;

        public override bool Equals(object obj) => obj is None;

        public override int GetHashCode() => 0;

        public override string ToString() => nameof(None);
    }
}
