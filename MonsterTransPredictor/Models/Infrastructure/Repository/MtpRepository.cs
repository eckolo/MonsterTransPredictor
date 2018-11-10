using System.Data.Entity;
using System.Diagnostics;

namespace MonsterTransPredictor.Models.Infrastructure.Repository
{
    /// <summary>
    /// DBアクセス用エンティティ取得場所
    /// </summary>
    public static class MtpRepository
    {
        /// <summary>
        /// エンティティ取得インターフェース
        /// </summary>
        public static Mtp entity => new Mtp().SetLog();

        /// <summary>
        /// DBアクセスログをコンソールに吐き出すための処理
        /// </summary>
        /// <typeparam name="TContext">エンティティの型</typeparam>
        /// <param name="dbContext">アクセスログをコンソールに吐かせたいエンティティ</param>
        /// <returns>渡したエンティティ</returns>
        private static TContext SetLog<TContext>(this TContext dbContext) where TContext : DbContext
        {
            dbContext.Database.Log = message => Debug.WriteLine(message);
            return dbContext;
        }
    }
}