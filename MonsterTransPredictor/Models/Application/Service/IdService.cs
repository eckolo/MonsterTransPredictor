using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Application.Service
{
    /// <summary>
    /// ID周りのちょっとした計算処理とか
    /// </summary>
    public static class IdService
    {
        /// <summary>
        /// 不正値混じりのIDリストを重複無しの純粋なIDのみのリストに変換
        /// </summary>
        /// <param name="origin">元となるIDリスト</param>
        /// <returns>過不足無い正確なIDリスト</returns>
        public static List<int> ToIdList(this IEnumerable<int?> origin)
            => origin
            .Where(id => id != null)
            .Select(id => id ?? throw new NullReferenceException())
            .Distinct()
            .ToList();
    }
}