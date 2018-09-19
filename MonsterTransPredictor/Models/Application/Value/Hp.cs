using System;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 体力値を表すクラス
    /// </summary>
    public class Hp : IComparable<Hp>, IEquatable<Hp>
    {
        /// <summary>
        /// 実際の値
        /// </summary>
        uint _value;

        //TODO 実装する
        public static Hp operator +(Hp x, Hp y)
            => throw new NotImplementedException();
        public static Hp operator -(Hp x, Hp y)
            => throw new NotImplementedException();
        public static Hp operator *(Hp x, Hp y)
            => throw new NotImplementedException();
        public static Hp operator /(Hp x, Hp y)
            => throw new NotImplementedException();

        public static bool operator ==(Hp x, Hp y) => x.CompareTo(y) == 0;
        public static bool operator !=(Hp x, Hp y) => x.CompareTo(y) != 0;

        public static bool operator <(Hp x, Hp y) => x.CompareTo(y) < 0;
        public static bool operator >(Hp x, Hp y) => x.CompareTo(y) > 0;

        public static bool operator <=(Hp x, Hp y) => x.CompareTo(y) <= 0;
        public static bool operator >=(Hp x, Hp y) => x.CompareTo(y) >= 0;

        public int CompareTo(Hp other)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
        public int CompareTo(object other)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }

        public bool Equals(Hp other)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
    }
}