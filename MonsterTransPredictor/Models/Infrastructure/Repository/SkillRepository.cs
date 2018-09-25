using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Infrastructure.Repository
{
    /// <summary>
    /// <see cref="Skill"/>関連の情報取得場所
    /// </summary>
    public class SkillRepository : ISkillRepository
    {
        /// <summary>
        /// 全技データのIDと名称のセットを取得する
        /// </summary>
        /// <returns>全技データのIDと名称のセット</returns>
        Dictionary<int, string> ISkillRepository.GetAllNameList()
            => MtpRepository.entity.skills.ToDictionary(skill => skill.id, skill => skill.name);

        /// <summary>
        /// 指定したIDの技情報を取得する
        /// </summary>
        /// <param name="ids">IDのリスト</param>
        /// <returns>技情報一覧</returns>
        IEnumerable<Skill> ISkillRepository.GetSkill(IEnumerable<int> ids)
        {
            var idList = ids ?? new List<int>();
            return MtpRepository.entity.skills.Where(skill => idList.Contains(skill.id)).ToList();
        }
    }
}