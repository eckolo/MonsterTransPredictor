﻿using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(Mtp context)
        {
            //初期化前にデータを全削除
            context.monsters.RemoveRange(context.monsters.ToList());
            context.skills.RemoveRange(context.skills.ToList());
            context.transTerms.RemoveRange(context.transTerms.ToList());

            var scissors = new Skill(name: "ハサミ", partsType: PartsType.arm);
            var ink = new Skill(name: "スミ", partsType: PartsType.breath);
            var bodyBlow = new Skill(name: "体当たり", partsType: PartsType.body);
            var shellWorm = new Monster(name: "シェルワーム")
                .AddLearnableSkill(scissors)
                .AddLearnableSkill(ink)
                .AddLearnableSkill(bodyBlow);
            var shellWormTerm = new Monster.TransTerm(monster: shellWorm, hpLimit: 250, priority: 50)
                .AddNecessarySkill(scissors);

            context.skills.AddRange(new List<Skill> { scissors, ink, bodyBlow });
            context.monsters.AddRange(new List<Monster> { shellWorm });
            context.transTerms.AddRange(new List<Monster.TransTerm> { shellWormTerm });
            context.SaveChanges();
        }
    }
}