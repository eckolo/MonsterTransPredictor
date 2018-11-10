using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MonsterTransPredictor.Models.Infrastructure.Repository
{
    /// <summary>
    /// <see cref="Monster"/>関連の情報取得場所
    /// </summary>
    public class MonsterRepository : IMonsterRepository
    {
        /// <summary>
        /// 全モンスターデータのIDと名称のセットを取得する
        /// </summary>
        /// <returns>全モンスターデータのIDと名称のセット</returns>
        public Dictionary<int, string> GetAllNameList()
        {
            using(var entity = MtpRepository.entity)
            {
                return entity.monsters.ToDictionary(monster => monster.id, monster => monster.name);
            }
        }

        /// <summary>
        /// 指定したIDのモンスター情報を取得する
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>モンスター情報</returns>
        public Monster GetMonster(int? id)
        {
            using(var entity = MtpRepository.entity)
            {
                return entity.monsters
                    .Where(monster => monster.id == id)
                    .Include(monster => monster.learnableSkillList)
                    .SingleOrDefault();
            }
        }
    }
}