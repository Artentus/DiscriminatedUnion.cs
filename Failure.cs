using System;

namespace DUcs
{
    /// <summary>
    /// A generic failure state
    /// </summary>
    public readonly struct Failure : IEquatable<Failure>
    {
        public static readonly Failure Value = default;

        public static bool operator ==(Failure first, Failure second) => true;

        public static bool operator !=(Failure first, Failure second) => false;

        public bool Equals(Failure _) => true;

        public override bool Equals(object obj) => obj is Failure;

        public override int GetHashCode() => 0;

        public override string ToString() => nameof(Failure);
    }
}
