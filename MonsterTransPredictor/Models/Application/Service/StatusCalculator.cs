using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Repository;
using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Application.Service
{
    /// <summary>
    /// ステータスを基に何かしらを計算する処理
    /// </summary>
    public static class StatusCalculator
    {
        /// <summary>
        /// 現在の習得技と追加する技から変身先モンスターを算出する
        /// </summary>
        /// <param name="repository">必要なデータを読み出すリポジトリ</param>
        /// <param name="nowSkills">現在の習得技一覧</param>
        /// <param name="addSkill">新規習得技</param>
        /// <returns>体力値の下限と変身先モンスターのセット</returns>
        public static (Hp hp, Monster monster)[] CalcNextMonster(
            this ITransTermRepository transTermRepository,
            Skill[] nowSkills,
            Skill addSkill)
        {
            var emptyMonsters = new[] { (Hp.max, new Monster(Const.NOT_TRANS_NAME)) };
            if(!(nowSkills?.Any() ?? false)) return addSkill != null
                    ? emptyMonsters
                    : new (Hp hp, Monster monster)[] { };

            var nextSkillList = new List<Skill> { addSkill ?? nowSkills.Last() }.Concat(nowSkills)
                .Take(8)
                .Where(skill => skill != null)
                .ToList();

            var keySkillList = nextSkillList
                .GroupBy(skill => skill.partsType)
                .Select(skills => skills.FirstOrDefault())
                .Where(skill => skill != default)
                .ToList();

            //特殊変身条件と通常変身条件は判定に使う技リストが異なる
            var transTermList = transTermRepository.GetTransTerms(keySkillList)
                .Concat(transTermRepository.GetTransTerms(nextSkillList, true))
                .ToList();

            var nextMonsters = transTermList.CalcNextMonsters();

            var maxHpKey = nextMonsters?.Keys.Max();
            //体力によっては変身条件を満たさない場合、直下の変身条件を適用する
            if(maxHpKey?.real is uint maxHpKeyReal && maxHpKeyReal < Const.MAX_HP)
            {
                nextMonsters.Add(Hp.max, nextMonsters[maxHpKey]);
                nextMonsters.Remove(maxHpKey);
            }

            //一切変身条件を満たさない場合、ダミーのモンスターデータを最大体力に紐づけて入れておく
            if((nextMonsters?.Keys.Max()?.real ?? 0) < Const.MAX_HP) return emptyMonsters;

            var result = nextMonsters?
                .Select(monster => (hp: monster.Key, monster: monster.Value))
                .OrderByDescending(monster => monster.hp)
                .ToArray();

            return result;
        }
        /// <summary>
        /// 現在の習得技と吸収するモンスターから変身先モンスターを算出する
        /// </summary>
        /// <param name="nowSkills">現在の習得技一覧</param>
        /// <param name="absorbMonster">吸収するモンスター</param>
        /// <returns>習得技と体力値下限のセットと変身先モンスターのセット</returns>
        public static (Skill skill, (Hp hp, Monster monster)[] monsters)[] CalcNextMonster(
            this ITransTermRepository transTermRepository,
            Skill[] nowSkills,
            Monster absorbMonster)
            => absorbMonster?
                .learnableSkillList?
                .Select(skill => (skill, monster: transTermRepository.CalcNextMonster(nowSkills, skill)))
                .ToArray()
                ?? new (Skill skill, (Hp hp, Monster monster)[] monsters)[] { };
    }
}