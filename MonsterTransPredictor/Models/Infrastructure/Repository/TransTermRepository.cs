using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MonsterTransPredictor.Models.Infrastructure.Repository
{
    public class TransTermRepository : ITransTermRepository
    {
        /// <summary>
        /// 指定した技構成に含まれる変身条件を取得する
        /// </summary>
        /// <param name="skills">技のリスト</param>
        /// <param name="skills">特殊変身検索モード</param>
        /// <returns>変身条件一覧</returns>
        public IEnumerable<TransTerm> GetTransTerms(List<Skill> skills, bool special = false)
        {
            var skillIdList = skills.Select(_skill => _skill.id).ToList();
            using(var entity = MtpRepository.entity)
            {
                return entity.transTerms
                    .Where(term => term.necessarySkillList.All(skill => skillIdList.Contains(skill.id)))
                    .Where(term => term.special == special)
                    .Include(term => term.monster)
                    .ToList();
            }
        }
    }
}