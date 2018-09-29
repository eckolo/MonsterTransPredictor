using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Application.Service
{
    /// <summary>
    /// モンスター周りの計算処理サービス
    /// </summary>
    public static class MonsterService
    {
        /// <summary>
        /// 変身条件一覧から次に変身すると思われるモンスターを体力毎に算出する
        /// </summary>
        /// <param name="termList"></param>
        /// <returns></returns>
        public static Dictionary<Hp, Monster> CalcNextMonsters(this List<TransTerm> termList)
        {
            //特殊変身判定
            var specialTerms = termList.Where(term => term.special);
            if(specialTerms.Any()) return new Dictionary<Hp, Monster> { { Hp.max, specialTerms.Single().monster } };

            return termList
                .Where(term => !term.special)
                .GroupBy(term => term.hpLimit)
                .Select(terms => terms.MaxKeys(term => term.priority).Single())
                .ToDictionary(term => term.hpLimit, term => term.monster);
        }
    }
}