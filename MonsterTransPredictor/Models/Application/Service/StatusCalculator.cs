using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;
using System;
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
        /// <param name="nowSkills">現在の習得技一覧</param>
        /// <param name="addSkill">新規習得技</param>
        /// <returns>体力値の下限と変身先モンスターのセット</returns>
        public static Dictionary<Hp, Monster> CalcNextMonster(this List<Skill> nowSkills, Skill addSkill)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
        /// <summary>
        /// 現在の習得技と吸収するモンスターから変身先モンスターを算出する
        /// </summary>
        /// <param name="nowSkills">現在の習得技一覧</param>
        /// <param name="absorbMonster">吸収するモンスター</param>
        /// <returns>習得技と体力値下限のセットと変身先モンスターのセット</returns>
        public static Dictionary<Skill, Dictionary<Hp, Monster>> CalcNextMonster(this List<Skill> nowSkills, Monster absorbMonster)
            => absorbMonster.learnableSkillList
                 .Select(skill => (skill, monster: nowSkills.CalcNextMonster(skill)))
                 .ToDictionary(data => data.skill, data => data.monster);
    }
}