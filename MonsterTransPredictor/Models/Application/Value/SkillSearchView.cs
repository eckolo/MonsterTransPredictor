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
            int? addSkillId = null,
            int?[] masteredSkillIdList = null,
            (int? skillId, (Hp hp, Monster monster)[] monsters)[] nextMonsters = null)
                : base(skillNameList, masteredSkillIdList, nextMonsters)
        {
            this.addSkillId = addSkillId ?? this.addSkillId;
        }

        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public int addSkillId { get; } = Const.EMPTY_SKILL_ID;
        /// <summary>
        /// 追加技の名称
        /// </summary>
        public string addSkillName
            => _skillNameList.ContainsKey(addSkillId)
            ? _skillNameList[addSkillId]
            : "";
    }
}