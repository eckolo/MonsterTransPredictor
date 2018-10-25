using MonsterTransPredictor.Models.Application.Entity;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 技検索機能画面で使用される情報のモデル
    /// </summary>
    public class SkillSearchView : BaseSearchView
    {
        public SkillSearchView(
            Dictionary<int, string> skillNameList,
            Skill addSkill = null,
            Skill[] masteredSkillList = null,
            (Skill skill, (Hp hp, Monster monster)[] monsters)[] nextMonsters = null)
                : base(skillNameList, masteredSkillList, nextMonsters)
        {
            addSkillId = addSkill?.id ?? addSkillId;
        }

        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public int addSkillId { get; } = Const.EMPTY_ID;
    }
}