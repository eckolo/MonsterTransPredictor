using MonsterTransPredictor.Models.Application.Repository;
using MonsterTransPredictor.Models.Application.Value;

namespace MonsterTransPredictor.Models.Infrastructure.Repository
{
    /// <summary>
    /// <see cref="AccessLog"/>関連の情報取得場所
    /// </summary>
    public class AccessLogRepository : IAccessLogRepository
    {
        /// <summary>
        /// 新規にアクセスログを記録する
        /// </summary>
        /// <param name="accessLog">残したいログ</param>
        public void LeaveLog(AccessLog accessLog)
        {
            using(var entity = MtpRepository.entity)
            {
                entity.accessLogs.Add(accessLog);
                entity.SaveChanges();
            }
        }
    }
}