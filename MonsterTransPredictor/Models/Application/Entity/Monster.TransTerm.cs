using MonsterTransPredictor.Models.Application.Value;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Entity
{
    public partial class Monster
    {
        /// <summary>
        /// 変身条件
        /// </summary>
        public partial class TransTerm
        {
            public TransTerm() { }

            public TransTerm(Monster monster, int hpLimit, int priority)
            {
                this.monster = monster ?? throw new ArgumentNullException(nameof(monster));
                _hpLimit = hpLimit;
                this.priority = priority;
            }
            /// <summary>
            /// 主キー
            /// </summary>
            [Key]
            public int id { get; private set; }

            /// <summary>
            /// 対象モンスター
            /// </summary>
            [Required]
            public Monster monster { get; private set; }

            /// <summary>
            /// 体力条件
            /// </summary>
            public Hp hpLimit => new Hp(_hpLimit);
            /// <summary>
            /// 体力条件
            /// </summary>
            [Required]
            protected int _hpLimit { get; private set; }
            /// <summary>
            /// 優先度
            /// </summary>
            [Required]
            public int priority { get; private set; }

            /// <summary>
            /// 必要スキル条件
            /// </summary>
            [Required]
            public List<Skill> necessarySkillList { get; private set; }

            public TransTerm AddNecessarySkill(Skill skill)
            {
                necessarySkillList = necessarySkillList ?? new List<Skill>();
                necessarySkillList.Add(skill.AddnecessaryTransTerm(this));
                return this;
            }
        }
    }
}