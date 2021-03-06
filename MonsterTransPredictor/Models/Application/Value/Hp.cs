﻿using System;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 体力値を表すクラス
    /// </summary>
    public class Hp : IComparable<Hp>, IEquatable<Hp>
    {
        public Hp(uint real)
        {
            this.real = real;
        }
        public Hp(int real)
            : this((uint)real)
        {
            if(real < 0) throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// 最大体力値
        /// </summary>
        public static readonly Hp max = new Hp(Const.MAX_HP);

        /// <summary>
        /// 体力0
        /// </summary>
        public static readonly Hp zero = new Hp(0);

        /// <summary>
        /// 実際の値
        /// </summary>
        public uint real { get; }

        public static Hp operator +(Hp x, Hp y) => new Hp(x.real + y.real);
        public static Hp operator -(Hp x, Hp y) => new Hp(x.real - y.real);
        public static Hp operator *(Hp x, Hp y) => new Hp(x.real * y.real);
        public static Hp operator /(Hp x, Hp y) => new Hp(x.real / y.real);

        public static bool operator ==(Hp x, Hp y) => x?.Equals(y) ?? y is null;
        public static bool operator !=(Hp x, Hp y) => !(x == y);

        public static bool operator <(Hp x, Hp y) => x.CompareTo(y) < 0;
        public static bool operator >(Hp x, Hp y) => x.CompareTo(y) > 0;

        public static bool operator <=(Hp x, Hp y) => x.CompareTo(y) <= 0;
        public static bool operator >=(Hp x, Hp y) => x.CompareTo(y) >= 0;

        public int CompareTo(Hp other) => real.CompareTo(other?.real);

        public bool Equals(Hp other) => real == other?.real;
        public override bool Equals(object other)
            => other is Hp otherHp ? Equals(otherHp) : false;

        public override int GetHashCode() => real.GetHashCode();
    }
}