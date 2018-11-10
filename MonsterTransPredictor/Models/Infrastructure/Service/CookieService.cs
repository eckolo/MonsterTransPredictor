using MonsterTransPredictor.Models.Application.Repository;
using MonsterTransPredictor.Models.Application.Value;
using System;
using System.Diagnostics;
using System.IO;
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
        /// <param name="accessLogRepository">アクセスログリポジトリ</param>
        /// <param name="response">レスポンスオブジェクト</param>
        /// <param name="request">リクエストオブジェクト</param>
        /// <param name="accessTime">アクセス時刻</param>
        public static void RecordAccessLog(
            this IAccessLogRepository accessLogRepository,
            HttpResponseBase response,
            HttpRequestBase request,
            DateTime accessTime)
        {
            var cookie = request.ToAccessToken(accessTime);

            request.InputStream.Position = 0;
            using(var reader = new StreamReader(request.InputStream))
            {
                var token = cookie.Value;
                var path = request.RawUrl;
                var param = HttpUtility.UrlDecode(reader.ReadToEnd());

                var accessLog = new AccessLog(accessTime, token, path, param);

                accessLogRepository.LeaveLog(accessLog);
            }

            //値渡ししたオブジェクトへの非staticな操作してるけどメソッドに切り出すためにはしょうがなかったの許して
            response.Cookies.Add(cookie);
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
            //デバッグ実行であることを明示的にログを残す
            if(Debugger.IsAttached) return "DEBUG";

            var hash = seed.GetHashCode().ToString("x");
            var guid = Guid.NewGuid().ToString();

            return $"{guid}-{hash}";
        }
    }
}