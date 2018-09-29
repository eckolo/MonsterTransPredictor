using MonsterTransPredictor.Models.Application.Value;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Entity
{
    /// <summary>
    /// 技を表すオブジェクト
    /// </summary>
    public partial class Skill
    {
        public Skill() { }

        public Skill(string name, PartsType partsType)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.partsType = partsType;
        }

        /// <summary>
        /// 主キー
        /// </summary>
        [Key]
        public int id { get; private set; }

        /// <summary>
        /// 技名称
        /// </summary>
        [Required]
        public string name { get; private set; }

        /// <summary>
        /// 分類される部位タイプ
        /// </summary>
        [Required]
        public PartsType partsType { get; private set; }

        /// <summary>
        /// 習得可能なモンスター一覧
        /// </summary>
        public List<Monster> learnableMonsterList { get; private set; }

        public Skill AddLearnableMonster(Monster monster)
        {
            learnableMonsterList = learnableMonsterList ?? new List<Monster>();
            learnableMonsterList.Add(monster);
            return this;
        }

        /// <summary>
        /// 必要スキルとして含まれる条件リスト
        /// </summary>
        public List<TransTerm> necessaryTransTermList { get; private set; }

        public Skill AddnecessaryTransTerm(TransTerm transTerm)
        {
            necessaryTransTermList = necessaryTransTermList ?? new List<TransTerm>();
            necessaryTransTermList.Add(transTerm);
            return this;
        }
    }
}