namespace MonsterTransPredictor.Models.Application.Value
{
    /// <summary>
    /// 共有定数値クラス
    /// </summary>
    public static class Const
    {
        /// <summary>
        /// 体力上限定数
        /// </summary>
        public const int MAX_HP = 999;
        /// <summary>
        /// 技/モンスターデータの該当無しID
        /// </summary>
        public const int EMPTY_ID = -1;
        /// <summary>
        /// 変身先モンスター無しの場合の表記
        /// </summary>
        public const string NOT_TRANS_NAME = "※変身無し※";
        /// <summary>
        /// アクセストークンクッキーのキー
        /// </summary>
        public const string ACCESS_COOKIE_KEY = "mtpauth";
    }
}