using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Application.Service
{
    /// <summary>
    /// <see cref="IEnumerable{T}">関連の汎用操作クラス
    /// </summary>
    public static class EnumerableManager
    {
        /// <summary>
        /// リストから所定の最大値を持つ要素を抽出する
        /// </summary>
        /// <typeparam name="TSource">リストを構成する要素型</typeparam>
        /// <typeparam name="TComparable">最大値判定時の型</typeparam>
        /// <param name="source">元リスト</param>
        /// <param name="selector">最大値判定値算出関数</param>
        /// <returns></returns>
        public static IEnumerable<TSource> MaxKeys<TSource, TComparable>(this IEnumerable<TSource> source, Func<TSource, TComparable> selector)
            where TComparable : IComparable<TComparable>
        {
            if(!source?.Any() ?? true) return source;
            var maxValue = source.Max(selector);
            return source.Where(elem => selector(elem).CompareTo(maxValue) == 0);
        }
        /// <summary>
        /// リストから所定の最小値を持つ要素を抽出する
        /// </summary>
        /// <typeparam name="TSource">リストを構成する要素型</typeparam>
        /// <typeparam name="TComparable">最小値判定時の型</typeparam>
        /// <param name="source">元リスト</param>
        /// <param name="selector">最小値判定値算出関数</param>
        /// <returns></returns>
        public static IEnumerable<TSource> MinKeys<TSource, TComparable>(this IEnumerable<TSource> source, Func<TSource, TComparable> selector)
            where TComparable : IComparable<TComparable>
        {
            if(!source?.Any() ?? true) return source;
            var minValue = source.Min(selector);
            return source.Where(elem => selector(elem).CompareTo(minValue) == 0);
        }
    }
}