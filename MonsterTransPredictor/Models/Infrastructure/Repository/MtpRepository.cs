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
        /// エンティティの実体
        /// </summary>
        static Mtp _mtp = null;
        /// <summary>
        /// エンティティ取得インターフェース
        /// </summary>
        public static Mtp mtp => _mtp ?? (_mtp = new Mtp().SetLog());

        /// <summary>
        /// DBアクセスログをコンソールに吐き出すための処理
        /// </summary>
        /// <typeparam name="TContext">エンティティの型</typeparam>
        /// <param name="dbContext">アクセスログをコンソールに吐かせたいエンティティ</param>
        /// <returns>渡したエンティティ</returns>
        private static TContext SetLog<TContext>(this TContext dbContext) where TContext : DbContext
        {
            dbContext.Database.Log = ShowWindowsMessage;
            return dbContext;
        }
        /// <summary>
        /// コンソールへの標準出力処理をデリゲートとして渡すためのラッパー
        /// </summary>
        /// <param name="message">コンソールへ出力する文字列</param>
        private static void ShowWindowsMessage(string message)
        {
            Debug.WriteLine(message);
        }
    }
}