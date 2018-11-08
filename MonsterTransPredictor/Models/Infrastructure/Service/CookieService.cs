using MonsterTransPredictor.Models.Application.Value;
using System;
using System.Linq;
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
        public static HttpCookie ToAccessCookie(this HttpRequestBase request, DateTime seed)
        {
            var cookies = request.Cookies;
            if(cookies.AllKeys.Contains(Const.ACCESS_COOKIE_KEY)) return cookies[Const.ACCESS_COOKIE_KEY];

            var uniqueId = seed.ToUniqueId();
            return new HttpCookie(Const.ACCESS_COOKIE_KEY, uniqueId);
        }

        static string ToUniqueId(this DateTime seed)
        {
            var hash = seed.GetHashCode();
            var guid = Guid.NewGuid().ToString();

            return $"{hash}{guid}";
        }
    }
}