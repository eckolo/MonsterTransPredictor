﻿using MonsterTransPredictor.Models.Application.Entity;
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
        public static Dictionary<Hp, Monster> CalcNextMonster(
            this ITransTermRepository transTermRepository,
            List<Skill> nowSkills,
            Skill addSkill)
        {
            if(!(nowSkills?.Any() ?? false)) return null;

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

            //体力によっては変身しないことがある場合、変身しない体力区域に空値を入れる
            if((nextMonsters?.Keys.Max().real ?? 0) < Const.MAX_HP)
                nextMonsters = new Dictionary<Hp, Monster> { { Hp.max, new Monster() } }
                .Concat(nextMonsters)
                .ToDictionary(monster => monster.Key, monster => monster.Value);

            return nextMonsters;
        }
        /// <summary>
        /// 現在の習得技と吸収するモンスターから変身先モンスターを算出する
        /// </summary>
        /// <param name="nowSkills">現在の習得技一覧</param>
        /// <param name="absorbMonster">吸収するモンスター</param>
        /// <returns>習得技と体力値下限のセットと変身先モンスターのセット</returns>
        public static Dictionary<Skill, Dictionary<Hp, Monster>> CalcNextMonster(
            this ITransTermRepository transTermRepository,
            List<Skill> nowSkills,
            Monster absorbMonster)
            => absorbMonster.learnableSkillList
                 .Select(skill => (skill, monster: transTermRepository.CalcNextMonster(nowSkills, skill)))
                 .ToDictionary(data => data.skill, data => data.monster);
    }
}