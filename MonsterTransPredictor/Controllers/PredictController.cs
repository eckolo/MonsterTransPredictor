using MonsterTransPredictor.Models.Application.Repository;
using MonsterTransPredictor.Models.Application.Service;
using MonsterTransPredictor.Models.Application.Value;
using MonsterTransPredictor.Models.Infrastructure.Repository;
using System;
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
        readonly IMonsterRepository monsterRepository = new MonsterRepository();
        /// <summary>
        /// 変身条件リポジトリ
        /// </summary>
        readonly ITransTermRepository transTermRepository = new TransTermRepository();
        /// <summary>
        /// 技情報リポジトリ
        /// </summary>
        readonly ISkillRepository skillRepository = new SkillRepository();
        /// <summary>
        /// アクセスログリポジトリ
        /// </summary>
        readonly IAccessLogRepository accessLogRepository = new AccessLogRepository();

        /// <summary>
        /// 処理開始時刻
        /// </summary>
        readonly DateTime processStart = DateTime.Now;

        /// <summary>
        /// トップページ兼メインメニュー
        /// </summary>
        /// <returns>HTMLページ</returns>
        public ActionResult Index()
        {
            accessLogRepository.RecordAccessLog(Response, Request, processStart);

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
            accessLogRepository.RecordAccessLog(Response, Request, processStart);

            var skillNameList = skillRepository.GetAllNameList();

            var skillIdList = masteredSkillIdList?.Concat(new List<int?> { addSkillId }).ToIdList();
            var skillDatas = skillRepository.GetSkill(skillIdList);

            var masteredSkills = masteredSkillIdList.GetSkillDetail(skillDatas);
            var addSkill = addSkillId.GetSkillDetail(skillDatas);

            var resultMonsters = transTermRepository.CalcNextMonster(masteredSkills, addSkill);
            var nextMonsters = new[] { (addSkill, resultMonsters) };

            var viewModel = new SkillSearchView(skillNameList, addSkill, masteredSkills, nextMonsters);

            return View(viewModel);
        }
        /// <summary>
        /// モンスターによる変身先予測
        /// </summary>
        /// <returns>HTMLページ</returns>
        public ActionResult MonsterSearch(List<int?> masteredSkillIdList = null, int? absorbMonsterId = null)
        {
            accessLogRepository.RecordAccessLog(Response, Request, processStart);

            var skillNameList = skillRepository.GetAllNameList();
            var monsterNameList = monsterRepository.GetAllNameList();

            var skillIdList = masteredSkillIdList?.Concat(new List<int?> { absorbMonsterId }).ToIdList();
            var skillDatas = skillRepository.GetSkill(skillIdList);

            var masteredSkills = masteredSkillIdList.GetSkillDetail(skillDatas);
            var absorbMonster = monsterRepository.GetMonster(absorbMonsterId);

            var resultMonsters = transTermRepository.CalcNextMonster(masteredSkills, absorbMonster);

            var viewModel = new MonsterSearchView(skillNameList, monsterNameList, absorbMonster, masteredSkills, resultMonsters);

            return View(viewModel);
        }
    }
}