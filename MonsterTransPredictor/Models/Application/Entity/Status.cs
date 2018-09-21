using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Entity
{
    /// <summary>
    /// HPや習得技などの状態を表すクラス
    /// </summary>
    public class Status
    {
        /// <summary>
        /// 体力値
        /// </summary>
        public Hp hp { get; set; }
        /// <summary>
        /// 技一覧
        /// </summary>
        public List<Skill> skillList { get; set; }
    }
}