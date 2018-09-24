using MonsterTransPredictor.Models.Application.Repository;
using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;
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
        readonly ISkillRepository skillRepository;

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
        /// <returns>HTMLページ</returns>
        public ActionResult SkillSearch()
        {
            return View(new SkillSearchView(skillNameList: new Dictionary<int, string> { { 1, "test1" }, { 2, "test2" } }));
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