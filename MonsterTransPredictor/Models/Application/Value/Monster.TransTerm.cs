﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Value
{
    public partial class Monster
    {
        /// <summary>
        /// 変身条件
        /// </summary>
        public partial class TransTerm
        {
            /// <summary>
            /// 主キー
            /// </summary>
            [Key]
            public int id { get; private set; }

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
            /// 必要スキル条件
            /// </summary>
            [Required]
            public List<Skill> necessarySkillList { get; private set; }
        }
    }
}