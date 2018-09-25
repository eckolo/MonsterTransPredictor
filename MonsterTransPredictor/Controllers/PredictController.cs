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
            var viewModel = new SkillSearchView(skillNameList, addSkillId, masteredSkillIdList);

            var skillIdList = masteredSkillIdList.Concat(new List<int?> { addSkillId }).ToIdList();
            var skillList = skillRepository.GetSkill(skillIdList);

            var masteredSkillList = masteredSkillIdList.GetSkillDetail(skillList);
            var addSkill = addSkillId.GetSkillDetail(skillList);

            var nextMonster = monsterRepository.CalcNextMonster(masteredSkillList, addSkill);

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