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

            var shellWormTerm = new TransTerm(monster: Monsters.シェルワーム, hpLimit: 250, priority: 50)
                .AddNecessarySkill(Skills.ハサミ);

            context.skills.AddRange(new List<Skill> { Skills.ハサミ, Skills.スミ, Skills.体当たり });
            context.monsters.AddRange(new List<Monster> { Monsters.シェルワーム });
            context.transTerms.AddRange(new List<TransTerm> { shellWormTerm });
            context.SaveChanges();
        }
    }
}