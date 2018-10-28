using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MonsterTransPredictor.Models.Application.Value
{
    public abstract class BaseSearchView
    {
        public BaseSearchView(
            Dictionary<int, (PartsType category, string name)> skillNameList,
            Skill[] masteredSkillList = null,
            (Skill skill, (Hp hp, Monster monster)[] monsters)[] nextMonsters = null)
        {
            _skillNameList = skillNameList.ToDictionary(skill => skill.Key, skill => skill.Value.name)
                ?? throw new ArgumentNullException(nameof(skillNameList));
            _skillNameList.Add(Const.EMPTY_ID, "");

            skillSelectList = CalcSkillSelectList(skillNameList);

            masteredSkillIdList = masteredSkillList?.Select(skill => skill?.id ?? Const.EMPTY_ID).ToArray()
                ?? masteredSkillIdList;

            tableDatas = CalcResultTableDatas(nextMonsters, _skillNameList);
        }

        static (string[] skillNames, (uint hp, (string name, int rowspan)[])[] monsters) CalcResultTableDatas(
            (Skill skill, (Hp hp, Monster monster)[] monsters)[] nextMonsters,
            Dictionary<int, string> skillNameList)
        {
            var skillIds = nextMonsters.Select(calced => calced.skill?.id ?? Const.EMPTY_ID).ToArray();

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

            var nextMonsterNames = nextMonsters
                .SelectMany(row => row.monsters?
                    .Select(monster => (
                        skillId: row.skill?.id ?? Const.EMPTY_ID,
                        monster.monster.name,
                        monster.hp,
                        rowspan: CalcRowspan(monster.hp, row.monsters, hpList))))
                .ToArray();
            var tableLines = nextMonsterNames
                .GroupBy(row => row.hp, calced => (calced.skillId, calced.name, calced.rowspan))
                .Select(rows => (
                    hp: rows.Key,
                    monsters: rows.ToDictionary(
                        row => row.skillId,
                        row => (row.name, row.rowspan))))
                .ToArray();
            var resultMonsters = tableLines
                .Select(row => (
                    hp: row.hp.real,
                    skillIds.Where(id => row.monsters.ContainsKey(id)).Select(id => row.monsters[id]).ToArray()))
                .OrderByDescending(row => row.hp)
                .ToArray();

            return (resultSkillNames, resultMonsters);
        }

        static SelectListItem[] CalcSkillSelectList(Dictionary<int, (PartsType category, string name)> skillList)
        {
            var categoryList = skillList
                .Select(skill => skill.Value.category)
                .Distinct()
                .ToDictionary(category => category, category => new SelectListGroup { Name = category.ToName() });

            var defaultSelectListItem = new SelectListItem { Value = Const.EMPTY_ID.ToString(), Text = "" };
            var selectListItems = skillList
                .OrderBy(skill => skill.Value.category)
                .ThenBy(skill => skill.Value.name)
                .ThenBy(skill => skill.Key)
                .Select(skill => new SelectListItem
                {
                    Value = skill.Key.ToString(),
                    Text = skill.Value.name,
                    Group = categoryList[skill.Value.category]
                });

            var result = new[] { defaultSelectListItem }.Concat(selectListItems).ToArray();

            return result;
        }

        /// <summary>
        /// 選択肢として表示される技名称リスト
        /// </summary>
        readonly Dictionary<int, string> _skillNameList;
        /// <summary>
        /// 選択肢として表示される技名称リスト
        /// </summary>
        public SelectListItem[] skillSelectList { get; }

        /// <summary>
        /// 追加技のデフォルト選択ID
        /// </summary>
        public int[] masteredSkillIdList { get; } = Enumerable.Range(0, 8)
            .Select(_ => Const.EMPTY_ID)
            .ToArray();

        /// <summary>
        /// 予測結果テーブルデータ
        /// </summary>
        public (string[] skillNames, (uint hp, (string name, int rowspan)[] names)[] monsters) tableDatas { get; }

        public string GetSwapButtonId(int index) => $"{swapClass}{index}";

        public string swapClass => "swap";
    }
}