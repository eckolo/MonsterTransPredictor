using MonsterTransPredictor.Models.Application.Value;

namespace MonsterTransPredictor.Models.Application.Repository
{
    /// <summary>
    /// <see cref="AccessLog"/>関連の情報取得場所
    /// </summary>
    public interface IAccessLogRepository
    {
        /// <summary>
        /// 新規にアクセスログを記録する
        /// </summary>
        /// <param name="accessLog">残したいログ</param>
        void LeaveLog(AccessLog accessLog);
    }
}
