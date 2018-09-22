using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 敵味方関わらずモンスターを表現するクラス
    /// </summary>
    public partial class Monster
    {
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

        /// <summary>
        /// 変身条件一覧
        /// </summary>
        [Required]
        public List<TransTerm> transTermList { get; private set; }
    }
}