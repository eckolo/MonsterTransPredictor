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
        /// アクセストークンを生成しアクセスログを記録する
        /// </summary>
        /// <param name="response">レスポンスオブジェクト</param>
        /// <param name="request">リクエストオブジェクト</param>
        /// <param name="accessTime">アクセス時刻</param>
        public static void RecordAccessLog(
            this HttpResponseBase response,
            HttpRequestBase request,
            DateTime accessTime)
        {
            var token = request.ToAccessToken(accessTime);

            response.Cookies.Add(token);
        }

        /// <summary>
        /// リクエストオブジェクトから1度以上アクセスしたユーザーか否か判定してアクセスクッキーを生成する
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        static HttpCookie ToAccessToken(this HttpRequestBase request, DateTime seed)
        {
            var cookies = request.Cookies;
            if(cookies.AllKeys.Contains(Const.ACCESS_COOKIE_KEY)) return cookies[Const.ACCESS_COOKIE_KEY];

            var uniqueId = seed.ToUniqueId();
            return new HttpCookie(Const.ACCESS_COOKIE_KEY, uniqueId);
        }

        static string ToUniqueId(this DateTime seed)
        {
            var hash = seed.GetHashCode().ToString("x");
            var guid = Guid.NewGuid().ToString();

            return $"{guid}-{hash}";
        }
    }
}