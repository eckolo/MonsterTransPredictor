using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Value
{
    public partial class Monster
    {
        /// <summary>
        /// 変身条件
        /// </summary>
        public class TransTerm
        {
            /// <summary>
            /// 体力条件
            /// </summary>
            public Hp hpLimit { get; }
            /// <summary>
            /// 必要スキル条件
            /// </summary>
            public List<Skill> necessarySkillList { get; }
        }
    }
}