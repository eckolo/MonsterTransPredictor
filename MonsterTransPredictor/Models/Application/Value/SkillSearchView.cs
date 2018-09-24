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
        public SkillSearchView(Dictionary<int, string> skillNameList, int? addSkillIdDefault = null, List<int> masteredSkillIdDefault = null)
        {
            _skillNameList = skillNameList ?? throw new ArgumentNullException(nameof(skillNameList));
            this.addSkillIdDefault = addSkillIdDefault ?? this.addSkillIdDefault;
            this.masteredSkillIdDefault = masteredSkillIdDefault ?? this.masteredSkillIdDefault;
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
            .OrderBy(name => name.Key)
            .Select(name => new SelectListItem { Value = name.Key.ToString(), Text = name.Value })
            .ToArray();

        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public int addSkillIdDefault { get; } = 0;
        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public List<int> masteredSkillIdDefault { get; } = Enumerable.Range(0, 8).Select(_ => 0).ToList();
    }
}