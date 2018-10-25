using MonsterTransPredictor.Models.Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// モンスター検索機能画面で使用される情報のモデル
    /// </summary>
    public class MonsterSearchView : BaseSearchView
    {
        public MonsterSearchView(
            Dictionary<int, string> skillNameList,
            Dictionary<int, string> monsterNameList,
            Monster absorbMonster = null,
            Skill[] masteredSkillList = null,
            (Skill skill, (Hp hp, Monster monster)[] monsters)[] nextMonsters = null)
                : base(skillNameList, masteredSkillList, nextMonsters)
        {
            _monsterNameList = monsterNameList ?? throw new ArgumentNullException(nameof(monsterNameList));
            _monsterNameList.Add(Const.EMPTY_ID, "");

            absorbMonsterId = absorbMonster?.id ?? absorbMonsterId;
        }

        /// <summary>
        /// 選択肢として表示されるモンスター名称リスト
        /// </summary>
        protected readonly Dictionary<int, string> _monsterNameList;
        /// <summary>
        /// 選択肢として表示されるモンスター名称リスト
        /// </summary>
        public SelectListItem[] monsterNameList
            => _monsterNameList
            .OrderBy(name => name.Value)
            .ThenBy(name => name.Key)
            .Select(name => new SelectListItem { Value = name.Key.ToString(), Text = name.Value })
            .ToArray();

        /// <summary>
        /// 吸収したモンスターのID
        /// </summary>
        public int absorbMonsterId { get; } = Const.EMPTY_ID;
    }
}