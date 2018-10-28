using MonsterTransPredictor.Models.Application.Value;
using System.Web;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    /// <summary>
    /// Cookie関連の計算処理用サービス
    /// </summary>
    public static class CookieService
    {
        /// <summary>
        /// リクエストオブジェクトから1度以上アクセスしたユーザーか否か判定してアクセスクッキーを生成する
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static HttpCookie ToAccessCookie(this HttpRequestBase request)
        {
            return new HttpCookie(Const.ACCESS_COOKIE_KEY, "testCookie");
        }
    }
}