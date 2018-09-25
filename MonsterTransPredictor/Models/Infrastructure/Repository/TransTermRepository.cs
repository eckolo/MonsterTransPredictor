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
        /// <returns>変身条件一覧</returns>
        public IEnumerable<TransTerm> GetTransTerms(List<Skill> skills)
        {
            var skillIdList = skills.Select(_skill => _skill.id).ToList();
            return MtpRepository.entity.transTerms
                .Where(term => term.necessarySkillList.All(skill => skillIdList.Contains(skill.id)))
                .Include(term => term.monster)
                .ToList();
        }
    }
}