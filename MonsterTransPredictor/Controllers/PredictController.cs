using MonsterTransPredictor.Models.Application.Repository;
using MonsterTransPredictor.Models.Application.Service;
using MonsterTransPredictor.Models.Application.Value;
using MonsterTransPredictor.Models.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MonsterTransPredictor.Controllers
{
    public class PredictController : Controller
    {
        /// <summary>
        /// モンスター情報リポジトリ
        /// </summary>
        readonly IMonsterRepository monsterRepository;
        /// <summary>
        /// 変身条件リポジトリ
        /// </summary>
        readonly ITransTermRepository transTermRepository = new TransTermRepository();
        /// <summary>
        /// 技情報リポジトリ
        /// </summary>
        readonly ISkillRepository skillRepository = new SkillRepository();

        /// <summary>
        /// トップページ兼メインメニュー
        /// </summary>
        /// <returns>HTMLページ</returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 技による変身先予測
        /// </summary>
        /// <param name="masteredSkillIdList">習得済み技IDリスト</param>
        /// <param name="addSkillId">新規習得技ID</param>
        /// <returns>HTMLページ</returns>
        public ActionResult SkillSearch(List<int?> masteredSkillIdList = null, int? addSkillId = null)
        {
            var skillNameList = skillRepository.GetAllNameList();

            var skillIdList = masteredSkillIdList?.Concat(new List<int?> { addSkillId }).ToIdList();
            var skillDatas = skillRepository.GetSkill(skillIdList);

            var masteredSkills = masteredSkillIdList.GetSkillDetail(skillDatas);
            var addSkill = addSkillId.GetSkillDetail(skillDatas);

            var resultMonsters = transTermRepository.CalcNextMonster(masteredSkills, addSkill)?
                .Select(monster => (hp: monster.Key, monster: monster.Value))
                .OrderByDescending(monster => monster.hp)
                .ToArray();

            var nextMonsters = new[] { (addSkill, resultMonsters) };
            var masteredSkillIds = masteredSkillIdList?.ToArray();

            var viewModel = new SkillSearchView(skillNameList, addSkill, masteredSkills, nextMonsters);

            return View(viewModel);
        }
        /// <summary>
        /// モンスターによる変身先予測
        /// </summary>
        /// <returns>HTMLページ</returns>
        public ActionResult MonsterSearch()
        {
            return View();
        }
    }
}