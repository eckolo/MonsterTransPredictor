﻿using MonsterTransPredictor.Models.Application.Entity;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Application.Repository
{
    /// <summary>
    /// <see cref="Skill"/>関連の情報取得場所
    /// </summary>
    public interface ISkillRepository
    {
        /// <summary>
        /// 全技データのIDと名称のセットを取得する
        /// </summary>
        /// <returns>全技データのIDと名称のセット</returns>
        Dictionary<int, string> GetAllNameList();

        /// <summary>
        /// 指定したIDの技情報を取得する
        /// </summary>
        /// <param name="ids">IDのリスト</param>
        /// <returns>技情報一覧</returns>
        IEnumerable<Skill> GetMonster(IEnumerable<int> ids);
    }
}
