using MonsterTransPredictor.Models.Application.Entity;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Repository
{
    /// <summary>
    /// <see cref="TransTerm"/>関連の情報取得場所
    /// </summary>
    public interface ITransTermRepository
    {
        /// <summary>
        /// 指定した技構成に含まれる変身条件を取得する
        /// </summary>
        /// <param name="skills">技のリスト</param>
        /// <param name="skills">特殊変身検索モード</param>
        /// <returns>変身条件一覧</returns>
        IEnumerable<TransTerm> GetTransTerms(List<Skill> skills, bool special = false);
    }
}
