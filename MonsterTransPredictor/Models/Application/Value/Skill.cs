using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 技を表すオブジェクト
    /// </summary>
    public partial class Skill
    {
        /// <summary>
        /// 主キー
        /// </summary>
        [Key]
        public int id { get; private set; }

        /// <summary>
        /// 技名称
        /// </summary>
        public string name { get; private set; }

        /// <summary>
        /// 分類される部位タイプ
        /// </summary>
        [Required]
        public PartsType partsType { get; private set; }

        /// <summary>
        /// 習得可能なモンスター一覧
        /// </summary>
        [Required]
        public List<Monster> learnableMonsterList { get; private set; }

        /// <summary>
        /// 必要スキルとして含まれる条件リスト
        /// </summary>
        [Required]
        public List<Monster.TransTerm> necessaryTransTermList { get; private set; }
    }
}