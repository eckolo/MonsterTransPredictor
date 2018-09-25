using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Repository
{
    /// <summary>
    /// <see cref="Monster"/>関連の情報取得場所
    /// </summary>
    public interface IMonsterRepository
    {
        /// <summary>
        /// 全モンスターデータのIDと名称のセットを取得する
        /// </summary>
        /// <returns>全モンスターデータのIDと名称のセット</returns>
        Dictionary<int, string> GetAllNameList();

        /// <summary>
        /// 指定したIDのモンスター情報を取得する
        /// </summary>
        /// <param name="ids">IDのリスト</param>
        /// <returns>モンスター情報一覧</returns>
        IEnumerable<Monster> GetMonster(IEnumerable<int> ids);

        /// <summary>
        /// 技の一覧から該当するモンスターと体力条件を検索する
        /// </summary>
        /// <param name="keySkills">索引条件となる技の一覧</param>
        /// <returns>モンスターと体力条件の組の一覧</returns>
        Dictionary<Hp, Monster> SearchBySkills(IEnumerable<Skill> keySkills);
    }
}
