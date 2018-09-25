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
        /// 指定したIDのモンスター情報を取得する
        /// </summary>
        /// <param name="skills">技のリスト</param>
        /// <returns>モンスター情報一覧</returns>
        IEnumerable<TransTerm> GetTransTerms(IEnumerable<Skill> skills);
    }
}
