using MonsterTransPredictor.Models.Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MonsterTransPredictor.Models.Application.Value
{
    public abstract class BaseSearchView
    {
        public BaseSearchView(
            Dictionary<int, string> skillNameList,
            Skill[] masteredSkillList = null,
            (Skill skill, (Hp hp, Monster monster)[] monsters)[] nextMonsters = null)
        {
            _skillNameList = skillNameList ?? throw new ArgumentNullException(nameof(skillNameList));
            _skillNameList.Add(Const.EMPTY_ID, "");

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

        /// <summary>
        /// 選択肢として表示される技名称リスト
        /// </summary>
        protected readonly Dictionary<int, string> _skillNameList;
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