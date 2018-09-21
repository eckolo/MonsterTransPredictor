using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 敵味方関わらずモンスターを表現するクラス
    /// </summary>
    public partial class Monster
    {
        /// <summary>
        /// 習得可能技一覧
        /// </summary>
        public List<Skill> learnableSkillList { get; }

        /// <summary>
        /// 変身条件一覧
        /// </summary>
        public List<TransTerm> transTermList { get; }
    }
}