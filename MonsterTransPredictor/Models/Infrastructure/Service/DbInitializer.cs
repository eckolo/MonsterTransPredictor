using MonsterTransPredictor.Models.Application.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    public partial class DbInitializer
    {
        public static void Initialize(Mtp context)
        {
            //初期化前にデータを全削除
            context.monsters.RemoveRange(context.monsters.ToList());
            context.skills.RemoveRange(context.skills.ToList());
            context.transTerms.RemoveRange(context.transTerms.ToList());


            var shellWorm = new Monster(name: "シェルワーム")
                .AddLearnableSkill(Skills.scissors)
                .AddLearnableSkill(Skills.ink)
                .AddLearnableSkill(Skills.bodyBlow);
            var rocky = new Monster(name: "ロッキー")
                .AddLearnableSkill(Skills.tail)
                .AddLearnableSkill(Skills.tail)
                .AddLearnableSkill(Skills.tail)
                .AddLearnableSkill(Skills.tail);

            var shellWormTerm = new TransTerm(monster: shellWorm, hpLimit: 250, priority: 50)
                .AddNecessarySkill(Skills.scissors);

            context.skills.AddRange(new List<Skill> { Skills.scissors, Skills.ink, Skills.bodyBlow });
            context.monsters.AddRange(new List<Monster> { shellWorm });
            context.transTerms.AddRange(new List<TransTerm> { shellWormTerm });
            context.SaveChanges();
        }
    }
}