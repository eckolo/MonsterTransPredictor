using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Entity
{
    /// <summary>
    /// 敵味方関わらずモンスターを表現するクラス
    /// </summary>
    public partial class Monster
    {
        public Monster() { }

        public Monster(string name, List<TransTerm> transTermList)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.transTermList = transTermList ?? throw new ArgumentNullException(nameof(transTermList));
        }

        /// <summary>
        /// 主キー
        /// </summary>
        [Key]
        public int id { get; private set; }

        /// <summary>
        /// モンスター名称
        /// </summary>
        public string name { get; private set; }

        /// <summary>
        /// 習得可能技一覧
        /// </summary>
        [Required]
        public List<Skill> learnableSkillList { get; private set; }

        public Monster AddLearnableSkill(Skill skill)
        {
            learnableSkillList = learnableSkillList ?? new List<Skill>();
            learnableSkillList.Add(skill.AddLearnableMonster(this));
            return this;
        }

        /// <summary>
        /// 変身条件一覧
        /// </summary>
        [Required]
        public List<TransTerm> transTermList { get; private set; }
    }
}