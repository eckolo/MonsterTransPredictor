using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 技検索機能画面で使用される情報のモデル
    /// </summary>
    public class SkillSearchView
    {
        public SkillSearchView(Dictionary<int, string> skillNameList, int? addSkillId = null, List<int?> masteredSkillIdList = null)
        {
            _skillNameList = skillNameList ?? throw new ArgumentNullException(nameof(skillNameList));
            this.addSkillId = addSkillId ?? this.addSkillId;
            this.masteredSkillIdList = masteredSkillIdList?.Select(id => id ?? 0).ToList()
                ?? this.masteredSkillIdList;
        }

        /// <summary>
        /// 選択肢として表示される技名称リスト
        /// </summary>
        readonly Dictionary<int, string> _skillNameList;
        /// <summary>
        /// 選択肢として表示される技名称リスト
        /// </summary>
        public SelectListItem[] skillNameList
            => _skillNameList
            .Concat(new Dictionary<int, string> { { 0, "" } })
            .OrderBy(name => name.Value)
            .ThenBy(name => name.Key)
            .Select(name => new SelectListItem { Value = name.Key.ToString(), Text = name.Value })
            .ToArray();

        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public int addSkillId { get; } = 0;
        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public List<int> masteredSkillIdList { get; } = Enumerable.Range(0, 8).Select(_ => 0).ToList();
    }
}