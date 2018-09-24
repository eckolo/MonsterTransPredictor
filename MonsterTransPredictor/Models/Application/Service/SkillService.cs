using MonsterTransPredictor.Models.Application.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Application.Service
{
    /// <summary>
    /// <see cref="Skill"/>関連の整形処理など
    /// </summary>
    public static class SkillService
    {
        public static List<Skill> GetSkillDetail(this List<int?> skillIdList, IEnumerable<Skill> skillList)
            => skillIdList.Select(id => skillList.SingleOrDefault(skill => skill.id == id)).ToList();

        public static Skill GetSkillDetail(this int? skillId, IEnumerable<Skill> skillList)
            => new List<int?> { skillId }.GetSkillDetail(skillList).Single();
    }
}