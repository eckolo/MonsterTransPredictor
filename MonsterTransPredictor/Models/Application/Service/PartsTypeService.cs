using MonsterTransPredictor.Models.Application.Value;
using System;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Service
{
    /// <summary>
    /// 部位関連の汎用サービス
    /// </summary>
    public static class PartsTypeService
    {
        /// <summary>
        /// 部位の名称リスト
        /// </summary>
        static readonly Dictionary<PartsType, string> _partsNames = new Dictionary<PartsType, string>
        {
            { PartsType.head, "頭部" },
            { PartsType.arm, "腕部" },
            { PartsType.leg, "脚部" },
            { PartsType.body, "身体" },
            { PartsType.breath, "ブレス" },
            { PartsType.magic, "魔法能力" },
        };

        /// <summary>
        /// 部位の名称を取得
        /// </summary>
        /// <param name="partsType">部位種別</param>
        /// <returns>部位の名称</returns>
        public static string ToName(this PartsType partsType)
            => _partsNames.ContainsKey(partsType)
                ? _partsNames[partsType]
                : throw new ArgumentOutOfRangeException(nameof(partsType));
    }
}