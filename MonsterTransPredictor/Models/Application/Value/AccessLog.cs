using System;
using System.ComponentModel.DataAnnotations;

namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// アクセス履歴保存用クラス
    /// </summary>
    public class AccessLog
    {
        public AccessLog(DateTime accessTime, string token, string path, string param)
        {
            this.accessTime = accessTime;
            this.token = token ?? throw new ArgumentNullException(nameof(token));
            this.path = path ?? throw new ArgumentNullException(nameof(path));
            this.param = param ?? throw new ArgumentNullException(nameof(param));
        }

        /// <summary>
        /// ログ識別番号
        /// </summary>
        [Key]
        public long counter { get; private set; }
        /// <summary>
        /// アクセス時刻
        /// </summary>
        [Required]
        public DateTime accessTime { get; private set; }
        /// <summary>
        /// ユーザー識別トークン
        /// </summary>
        [Required]
        public string token { get; private set; }
        /// <summary>
        /// アクセスURL
        /// </summary>
        public string path { get; private set; }
        /// <summary>
        /// クエリパラメータ
        /// </summary>
        public string param { get; private set; }
    }
}