using MonsterTransPredictor.Models.Application.Entity;
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
        public SkillSearchView(
            Dictionary<int, string> skillNameList,
            int? addSkillId = null,
            int?[] masteredSkillIdList = null,
            (int? skillId, (Hp hp, Monster monster)[] monsters)[] nextMonsters = null)
        {
            _skillNameList = skillNameList ?? throw new ArgumentNullException(nameof(skillNameList));
            _skillNameList.Add(Const.EMPTY_SKILL_ID, "");

            this.addSkillId = addSkillId ?? this.addSkillId;
            this.masteredSkillIdList = masteredSkillIdList?.Select(id => id ?? Const.EMPTY_SKILL_ID).ToArray()
                ?? this.masteredSkillIdList;

            tableDatas = CalcResultTableDatas(nextMonsters, _skillNameList);
        }

        static (string[] skillNames, (uint hp, (string name, int rowspan)[])[] monsters) CalcResultTableDatas(
            (int? skillId, (Hp hp, Monster monster)[] monsters)[] nextMonsters,
            Dictionary<int, string> skillNameList)
        {
            var skillIds = nextMonsters.Select(calced => calced.skillId ?? Const.EMPTY_SKILL_ID).ToArray();

            var hpList = nextMonsters
                .SelectMany(calced => calced.monsters?.Select(monster => monster.hp))
                .Distinct()
                .ToArray();

            int CalcRowspan(Hp target, IEnumerable<(Hp hp, Monster monster)> monsters, IEnumerable<Hp> all)
            {
                var maxUnderTarget = monsters
                    .Select(monster => monster.hp)
                    .Concat(new List<Hp> { Hp.zero })
                    .Where(elem => elem < target)
                    .Max();
                var rowspan = all.Count(elem => maxUnderTarget < elem && elem <= target);
                return rowspan;
            }

            var resultSkillNames = skillIds?.Select(id => skillNameList[id]).ToArray() ?? new string[] { };
            var resultMonsters = nextMonsters
                .SelectMany(row => row.monsters?
                    .Select(monster => (
                        skillId: row.skillId ?? Const.EMPTY_SKILL_ID,
                        monster.monster.name,
                        monster.hp,
                        rowspan: CalcRowspan(monster.hp, row.monsters, hpList))))
                .GroupBy(row => row.hp, calced => (calced.skillId, calced.name, calced.rowspan))
                .Select(rows => (
                    hp: rows.Key,
                    monsters: rows.ToDictionary(
                        row => row.skillId,
                        row => (row.name, row.rowspan))))
                .Select(row => (hp: row.hp.real, skillIds.Select(id => row.monsters[id]).ToArray()))
                .ToArray();

            return (resultSkillNames, resultMonsters);
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
            .OrderBy(name => name.Value)
            .ThenBy(name => name.Key)
            .Select(name => new SelectListItem { Value = name.Key.ToString(), Text = name.Value })
            .ToArray();

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
        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public int[] masteredSkillIdList { get; } = Enumerable.Range(0, 8)
            .Select(_ => Const.EMPTY_SKILL_ID)
            .ToArray();

        /// <summary>
        /// 予測結果テーブルデータ
        /// </summary>
        public (string[] skillNames, (uint hp, (string name, int rowspan)[] names)[] monsters) tableDatas { get; }

        public string GetSwapButtonId(int index) => $"{swapClass}{index}";

        public string swapClass => "swap";
    }
}