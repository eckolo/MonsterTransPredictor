using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;
using System.Collections.Generic;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    public partial class DbInitializer
    {
        struct TransTerms
        {
            public static List<TransTerm> list = new List<TransTerm> {
                new TransTerm(monster: Monsters.ロッキー, hpLimit: Const.MAX_HP, priority: 5)
                    .AddNecessarySkill(Skills.ぽんぽこ),

                new TransTerm(monster: Monsters.ブッチ, hpLimit: Const.MAX_HP, priority: 10)
                    .AddNecessarySkill(Skills.毒針),

                new TransTerm(monster: Monsters.ナイトスケルトン, hpLimit: Const.MAX_HP, priority: 15)
                    .AddNecessarySkill(Skills.死の属性),

                new TransTerm(monster: Monsters.クラーケン, hpLimit: Const.MAX_HP, priority: 20)
                    .AddNecessarySkill(Skills.スミ)
                    .AddNecessarySkill(Skills.メイルシュトローム),
                new TransTerm(monster: Monsters.クラーケン, hpLimit: Const.MAX_HP, priority: 20)
                    .AddNecessarySkill(Skills.スミ)
                    .AddNecessarySkill(Skills.マイティサイクロン),
                new TransTerm(monster: Monsters.クラーケン, hpLimit: Const.MAX_HP, priority: 20)
                    .AddNecessarySkill(Skills.触手)
                    .AddNecessarySkill(Skills.メイルシュトローム),
                new TransTerm(monster: Monsters.クラーケン, hpLimit: Const.MAX_HP, priority: 20)
                    .AddNecessarySkill(Skills.まきつき)
                    .AddNecessarySkill(Skills.メイルシュトローム),

                new TransTerm(monster: Monsters.雪の精, hpLimit: Const.MAX_HP, priority: 25)
                    .AddNecessarySkill(Skills.アイススマッシュ)
                    .AddNecessarySkill(Skills.冷気),

                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.催眠)
                    .AddNecessarySkill(Skills.ブレード)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.催眠)
                    .AddNecessarySkill(Skills.アイススマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.催眠)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.石化凝視)
                    .AddNecessarySkill(Skills.ブレード)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.石化凝視)
                    .AddNecessarySkill(Skills.アイススマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.石化凝視)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.魅了凝視)
                    .AddNecessarySkill(Skills.ブレード)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.魅了凝視)
                    .AddNecessarySkill(Skills.アイススマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.魅了凝視)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.マヒ凝視)
                    .AddNecessarySkill(Skills.ブレード)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.マヒ凝視)
                    .AddNecessarySkill(Skills.アイススマッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.デュラハン, hpLimit: Const.MAX_HP, priority: 30)
                    .AddNecessarySkill(Skills.マヒ凝視)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.死の属性),

                new TransTerm(monster: Monsters.スカルサウルス, hpLimit: Const.MAX_HP, priority: 35)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.スカルサウルス, hpLimit: Const.MAX_HP, priority: 35)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.死の属性),

                new TransTerm(monster: Monsters.ゼロディバイダー, hpLimit: Const.MAX_HP, priority: 40)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.ハサミ)
                    .AddNecessarySkill(Skills.電撃),
                new TransTerm(monster: Monsters.ゼロディバイダー, hpLimit: Const.MAX_HP, priority: 40)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.ハサミ)
                    .AddNecessarySkill(Skills.放射電撃),

                new TransTerm(monster: Monsters.サンフラワー, hpLimit: Const.MAX_HP, priority: 45)
                    .AddNecessarySkill(Skills.光合成 ),

                new TransTerm(monster: Monsters.玄武, hpLimit: Const.MAX_HP, priority: 50)
                    .AddNecessarySkill(Skills.冷気)
                    .AddNecessarySkill(Skills.竜巻),
                new TransTerm(monster: Monsters.玄武, hpLimit: Const.MAX_HP, priority: 50)
                    .AddNecessarySkill(Skills.冷気)
                    .AddNecessarySkill(Skills.磁気嵐),

                new TransTerm(monster: Monsters.シュリーカー, hpLimit: Const.MAX_HP, priority: 55)
                    .AddNecessarySkill(Skills.スクリーム),

                new TransTerm(monster: Monsters.キラービー, hpLimit: Const.MAX_HP, priority: 60)
                    .AddNecessarySkill(Skills.突き),

                new TransTerm(monster: Monsters.ブッチ, hpLimit: Const.MAX_HP, priority: 65)
                    .AddNecessarySkill(Skills.怒りの鉄拳)
                    .AddNecessarySkill(Skills.スポイル),

                new TransTerm(monster: Monsters.マンティコア, hpLimit: Const.MAX_HP, priority: 70)
                    .AddNecessarySkill(Skills.針),

                new TransTerm(monster: Monsters.ユニコーン, hpLimit: Const.MAX_HP, priority: 75)
                    .AddNecessarySkill(Skills.生命の雨),
                new TransTerm(monster: Monsters.ユニコーン, hpLimit: Const.MAX_HP, priority: 75)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.マジカルヒール),
                new TransTerm(monster: Monsters.ユニコーン, hpLimit: Const.MAX_HP, priority: 75)
                    .AddNecessarySkill(Skills.魅了凝視)
                    .AddNecessarySkill(Skills.マジカルヒール),

                new TransTerm(monster: Monsters.ジブサムスカウト, hpLimit: Const.MAX_HP, priority: 80)
                    .AddNecessarySkill(Skills.石化凝視)
                    .AddNecessarySkill(Skills.グランドヒット),

                new TransTerm(monster: Monsters.キマイラ, hpLimit: Const.MAX_HP, priority: 85)
                    .AddNecessarySkill(Skills.高温ガス),

                new TransTerm(monster: Monsters.朱雀, hpLimit: Const.MAX_HP, priority: 90)
                    .AddNecessarySkill(Skills.ファイアーバリア),

                new TransTerm(monster: Monsters.化石樹, hpLimit: Const.MAX_HP, priority: 95)
                    .AddNecessarySkill(Skills.ブレード)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.化石樹, hpLimit: Const.MAX_HP, priority: 95)
                    .AddNecessarySkill(Skills.烈風撃)
                    .AddNecessarySkill(Skills.石化ガス),

                new TransTerm(monster: Monsters.バジリスク, hpLimit: Const.MAX_HP, priority: 100)
                    .AddNecessarySkill(Skills.石化凝視)
                    .AddNecessarySkill(Skills.毒ガス),
                new TransTerm(monster: Monsters.バジリスク, hpLimit: Const.MAX_HP, priority: 100)
                    .AddNecessarySkill(Skills.石化凝視)
                    .AddNecessarySkill(Skills.毒撃),

                new TransTerm(monster: Monsters.オーガロード, hpLimit: Const.MAX_HP, priority: 105)
                    .AddNecessarySkill(Skills.グランドヒット)
                    .AddNecessarySkill(Skills.落雷),
                new TransTerm(monster: Monsters.オーガロード, hpLimit: Const.MAX_HP, priority: 105)
                    .AddNecessarySkill(Skills.ダブルアクス)
                    .AddNecessarySkill(Skills.落雷),

                new TransTerm(monster: Monsters.ゼラチナスプランター, hpLimit: Const.MAX_HP, priority: 110)
                    .AddNecessarySkill(Skills.サンダーバリア)
                    .AddNecessarySkill(Skills.電撃),
                new TransTerm(monster: Monsters.ゼラチナスプランター, hpLimit: Const.MAX_HP, priority: 110)
                    .AddNecessarySkill(Skills.サンダーバリア)
                    .AddNecessarySkill(Skills.放射電撃),

                new TransTerm(monster: Monsters.ブッチ, hpLimit: Const.MAX_HP, priority: 115)
                    .AddNecessarySkill(Skills.デスタッチ)
                    .AddNecessarySkill(Skills.死の属性)
                    .AddNecessarySkill(Skills.死人ゴケ),
                new TransTerm(monster: Monsters.ブッチ, hpLimit: Const.MAX_HP, priority: 115)
                    .AddNecessarySkill(Skills.ゴーストタッチ)
                    .AddNecessarySkill(Skills.死の属性)
                    .AddNecessarySkill(Skills.死人ゴケ),

                new TransTerm(monster: Monsters.コカトリス, hpLimit: Const.MAX_HP, priority: 120)
                    .AddNecessarySkill(Skills.石化撃),

                new TransTerm(monster: Monsters.赤竜, hpLimit: Const.MAX_HP, priority: 125)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.しっぽ)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.赤竜, hpLimit: Const.MAX_HP, priority: 125)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.尾撃)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.赤竜, hpLimit: Const.MAX_HP, priority: 125)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.しっぽ)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.赤竜, hpLimit: Const.MAX_HP, priority: 125)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.尾撃)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.赤竜, hpLimit: Const.MAX_HP, priority: 125)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.しっぽ)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.赤竜, hpLimit: Const.MAX_HP, priority: 125)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.ヒートスマッシュ)
                    .AddNecessarySkill(Skills.尾撃)
                    .AddNecessarySkill(Skills.火炎),

                new TransTerm(monster: Monsters.黒竜, hpLimit: Const.MAX_HP, priority: 130)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.しっぽ)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.黒竜, hpLimit: Const.MAX_HP, priority: 130)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.尾撃)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.黒竜, hpLimit: Const.MAX_HP, priority: 130)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.しっぽ)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.黒竜, hpLimit: Const.MAX_HP, priority: 130)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.尾撃)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.黒竜, hpLimit: Const.MAX_HP, priority: 130)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.しっぽ)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.黒竜, hpLimit: Const.MAX_HP, priority: 130)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.尾撃)
                    .AddNecessarySkill(Skills.石化ガス),

                new TransTerm(monster: Monsters.雷竜, hpLimit: Const.MAX_HP, priority: 135)
                    .AddNecessarySkill(Skills.スカッシュ)
                    .AddNecessarySkill(Skills.電撃)
                    .AddNecessarySkill(Skills.落雷),
                new TransTerm(monster: Monsters.雷竜, hpLimit: Const.MAX_HP, priority: 135)
                    .AddNecessarySkill(Skills.スカッシュ)
                    .AddNecessarySkill(Skills.放射電撃)
                    .AddNecessarySkill(Skills.落雷),

                new TransTerm(monster: Monsters.コスモデバウアー, hpLimit: Const.MAX_HP, priority: 140)
                    .AddNecessarySkill(Skills.アイススマッシュ)
                    .AddNecessarySkill(Skills.冷気),
                new TransTerm(monster: Monsters.コスモデバウアー, hpLimit: Const.MAX_HP, priority: 140)
                    .AddNecessarySkill(Skills.ハサミ)
                    .AddNecessarySkill(Skills.冷気),

                new TransTerm(monster: Monsters.ブッチ, hpLimit: Const.MAX_HP, priority: 145)
                    .AddNecessarySkill(Skills.毒針),

                new TransTerm(monster: Monsters.トリケプス, hpLimit: Const.MAX_HP, priority: 150)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.石化ガス),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: Const.MAX_HP, priority: 150)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.石化ガス),


                new TransTerm(monster: Monsters.カモキング, hpLimit: 520, priority: 5)
                    .AddNecessarySkill(Skills.ぽんぽこ)
                    .AddNecessarySkill(Skills.強酸),
                new TransTerm(monster: Monsters.カモキング, hpLimit: 520, priority: 5)
                    .AddNecessarySkill(Skills.ぽんぽこ)
                    .AddNecessarySkill(Skills.クチバシ),


                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 505, priority: 5)
                    .AddNecessarySkill(Skills.強風),


                new TransTerm(monster: Monsters.グリランドリー, hpLimit: 500, priority: 5)
                    .AddNecessarySkill(Skills.ブレード),


                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.地響き),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.流砂),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.突進),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.体当たり),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.角)
                    .AddNecessarySkill(Skills.暴走),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.突進),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.体当たり),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.暴走),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.ダガージョウ)
                    .AddNecessarySkill(Skills.突進),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.ダガージョウ)
                    .AddNecessarySkill(Skills.体当たり),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 475, priority: 5)
                    .AddNecessarySkill(Skills.ダガージョウ)
                    .AddNecessarySkill(Skills.暴走),

                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 475, priority: 10)
                    .AddNecessarySkill(Skills.毒針),


                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 470, priority: 5)
                    .AddNecessarySkill(Skills.シードバルカン),


                new TransTerm(monster: Monsters.トリケプス, hpLimit: 460, priority: 5)
                    .AddNecessarySkill(Skills.ふみつけ),


                new TransTerm(monster: Monsters.リキッドメタル, hpLimit: 455, priority: 5)
                    .AddNecessarySkill(Skills.ブレード),
                new TransTerm(monster: Monsters.リキッドメタル, hpLimit: 455, priority: 5)
                    .AddNecessarySkill(Skills.アイススマッシュ),
                new TransTerm(monster: Monsters.リキッドメタル, hpLimit: 455, priority: 5)
                    .AddNecessarySkill(Skills.ヒートスマッシュ),


                new TransTerm(monster: Monsters.アンクヘッグ, hpLimit: 445, priority: 5)
                    .AddNecessarySkill(Skills.吸血)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.アンクヘッグ, hpLimit: 445, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.死の属性),
                new TransTerm(monster: Monsters.アンクヘッグ, hpLimit: 445, priority: 5)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.死の属性),


                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 435, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.翼),
                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 435, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ)
                    .AddNecessarySkill(Skills.グライダースパイク),
                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 435, priority: 5)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.翼),
                new TransTerm(monster: Monsters.ワイバーン, hpLimit: 435, priority: 5)
                    .AddNecessarySkill(Skills.牙)
                    .AddNecessarySkill(Skills.グライダースパイク),


                new TransTerm(monster: Monsters.マンティコア, hpLimit: 430, priority: 5)
                    .AddNecessarySkill(Skills.スミ),
                new TransTerm(monster: Monsters.マンティコア, hpLimit: 430, priority: 5)
                    .AddNecessarySkill(Skills.悪臭),


                new TransTerm(monster: Monsters.トレント, hpLimit: 420, priority: 5)
                    .AddNecessarySkill(Skills.光合成),


                new TransTerm(monster: Monsters.アンノウン, hpLimit: 410, priority: 5)
                    .AddNecessarySkill(Skills.催眠),
                new TransTerm(monster: Monsters.アンノウン, hpLimit: 410, priority: 5)
                    .AddNecessarySkill(Skills.石化凝視),
                new TransTerm(monster: Monsters.アンノウン, hpLimit: 410, priority: 5)
                    .AddNecessarySkill(Skills.魅了凝視),
                new TransTerm(monster: Monsters.アンノウン, hpLimit: 410, priority: 5)
                    .AddNecessarySkill(Skills.マヒ凝視),


                new TransTerm(monster: Monsters.スライム大, hpLimit: 405, priority: 5)
                    .AddNecessarySkill(Skills.溶解液),

                new TransTerm(monster: Monsters.ヘルハウンド, hpLimit: 405, priority: 10)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.ヘルハウンド, hpLimit: 405, priority: 10)
                    .AddNecessarySkill(Skills.放射火炎),


                new TransTerm(monster: Monsters.アクスビーク, hpLimit: 400, priority: 5)
                    .AddNecessarySkill(Skills.クチバシ),
                new TransTerm(monster: Monsters.アクスビーク, hpLimit: 400, priority: 5)
                    .AddNecessarySkill(Skills.グランドヒット),


                new TransTerm(monster: Monsters.ソニックバット, hpLimit: 385, priority: 5)
                    .AddNecessarySkill(Skills.超音波),
                new TransTerm(monster: Monsters.ソニックバット, hpLimit: 385, priority: 5)
                    .AddNecessarySkill(Skills.スクリーム),


                new TransTerm(monster: Monsters.ルナティックハイ, hpLimit: 375, priority: 5)
                    .AddNecessarySkill(Skills.ねこだまし)
                    .AddNecessarySkill(Skills.翼)
                    .AddNecessarySkill(Skills.しっぽ),
                new TransTerm(monster: Monsters.ルナティックハイ, hpLimit: 375, priority: 5)
                    .AddNecessarySkill(Skills.ねこだまし)
                    .AddNecessarySkill(Skills.翼)
                    .AddNecessarySkill(Skills.尾撃),
                new TransTerm(monster: Monsters.ルナティックハイ, hpLimit: 375, priority: 5)
                    .AddNecessarySkill(Skills.ねこだまし)
                    .AddNecessarySkill(Skills.グライダースパイク)
                    .AddNecessarySkill(Skills.しっぽ),
                new TransTerm(monster: Monsters.ルナティックハイ, hpLimit: 375, priority: 5)
                    .AddNecessarySkill(Skills.ねこだまし)
                    .AddNecessarySkill(Skills.グライダースパイク)
                    .AddNecessarySkill(Skills.尾撃),


                new TransTerm(monster: Monsters.ガイアトード, hpLimit: 370, priority: 5)
                    .AddNecessarySkill(Skills.ふみつけ),


                new TransTerm(monster: Monsters.マフラーザウルス, hpLimit: 355, priority: 5)
                    .AddNecessarySkill(Skills.体当たり),
                new TransTerm(monster: Monsters.マフラーザウルス, hpLimit: 355, priority: 5)
                    .AddNecessarySkill(Skills.暴走),
                new TransTerm(monster: Monsters.マフラーザウルス, hpLimit: 355, priority: 5)
                    .AddNecessarySkill(Skills.突進),
                new TransTerm(monster: Monsters.マフラーザウルス, hpLimit: 355, priority: 5)
                    .AddNecessarySkill(Skills.キック),


                new TransTerm(monster: Monsters.ガイアトード, hpLimit: 350, priority: 5)
                    .AddNecessarySkill(Skills.丸のみ),


                new TransTerm(monster: Monsters.グルームモス, hpLimit: 345, priority: 5)
                    .AddNecessarySkill(Skills.ペインパウダー),


                new TransTerm(monster: Monsters.ハーピー, hpLimit: 335, priority: 5)
                    .AddNecessarySkill(Skills.翼),
                new TransTerm(monster: Monsters.ハーピー, hpLimit: 335, priority: 5)
                    .AddNecessarySkill(Skills.グライダースパイク),


                new TransTerm(monster: Monsters.マスキャット, hpLimit: 330, priority: 5)
                    .AddNecessarySkill(Skills.ぽんぽこ),


                new TransTerm(monster: Monsters.ストレイシープ, hpLimit: 325, priority: 5)
                    .AddNecessarySkill(Skills.ララバイ)
                    .AddNecessarySkill(Skills.突進),
                new TransTerm(monster: Monsters.ストレイシープ, hpLimit: 325, priority: 5)
                    .AddNecessarySkill(Skills.ララバイ)
                    .AddNecessarySkill(Skills.暴走),


                new TransTerm(monster: Monsters.ナイトシェイド, hpLimit: 320, priority: 5)
                    .AddNecessarySkill(Skills.催眠),
                new TransTerm(monster: Monsters.ナイトシェイド, hpLimit: 320, priority: 5)
                    .AddNecessarySkill(Skills.マヒ凝視),
                new TransTerm(monster: Monsters.ナイトシェイド, hpLimit: 320, priority: 5)
                    .AddNecessarySkill(Skills.魅了凝視),
                new TransTerm(monster: Monsters.ナイトシェイド, hpLimit: 320, priority: 5)
                    .AddNecessarySkill(Skills.石化凝視),


                new TransTerm(monster: Monsters.ハーピー, hpLimit: 310, priority: 5)
                    .AddNecessarySkill(Skills.スクリーム),


                new TransTerm(monster: Monsters.ライダーゴースト, hpLimit: 305, priority: 5)
                    .AddNecessarySkill(Skills.死の属性)
                    .AddNecessarySkill(Skills.スクリーム),
                new TransTerm(monster: Monsters.ライダーゴースト, hpLimit: 305, priority: 5)
                    .AddNecessarySkill(Skills.死の属性)
                    .AddNecessarySkill(Skills.超音波),


                new TransTerm(monster: Monsters.ファイアクリスタル, hpLimit: 300, priority: 5)
                    .AddNecessarySkill(Skills.ヒートスマッシュ),

                new TransTerm(monster: Monsters.フューズクリスタル, hpLimit: 300, priority: 5)
                    .AddNecessarySkill(Skills.アイススマッシュ),


                new TransTerm(monster: Monsters.デスポーカー, hpLimit: 295, priority: 5)
                    .AddNecessarySkill(Skills.毒針),


                new TransTerm(monster: Monsters.ソルジャービル, hpLimit: 285, priority: 5)
                    .AddNecessarySkill(Skills.クチバシ),
                new TransTerm(monster: Monsters.ソルジャービル, hpLimit: 285, priority: 5)
                    .AddNecessarySkill(Skills.スミ),


                new TransTerm(monster: Monsters.ゾンビ, hpLimit: 280, priority: 5)
                    .AddNecessarySkill(Skills.死の属性),


                new TransTerm(monster: Monsters.モンキーライダー, hpLimit: 275, priority: 5)
                    .AddNecessarySkill(Skills.催眠),


                new TransTerm(monster: Monsters.デスポーカー, hpLimit: 270, priority: 5)
                    .AddNecessarySkill(Skills.ハサミ),


                new TransTerm(monster: Monsters.プリクタス, hpLimit: 260, priority: 5)
                    .AddNecessarySkill(Skills.針),


                new TransTerm(monster: Monsters.バーゲスト, hpLimit: 255, priority: 5)
                    .AddNecessarySkill(Skills.突進),
                new TransTerm(monster: Monsters.バーゲスト, hpLimit: 255, priority: 5)
                    .AddNecessarySkill(Skills.体当たり),
                new TransTerm(monster: Monsters.バーゲスト, hpLimit: 255, priority: 5)
                    .AddNecessarySkill(Skills.暴走),
                new TransTerm(monster: Monsters.バーゲスト, hpLimit: 255, priority: 5)
                    .AddNecessarySkill(Skills.牙),
                new TransTerm(monster: Monsters.バーゲスト, hpLimit: 255, priority: 5)
                    .AddNecessarySkill(Skills.ファングクラッシュ),
                new TransTerm(monster: Monsters.バーゲスト, hpLimit: 255, priority: 5)
                    .AddNecessarySkill(Skills.ダガージョウ),


                new TransTerm(monster: Monsters.ドラゴンパピー, hpLimit: 250, priority: 5)
                    .AddNecessarySkill(Skills.火炎),
                new TransTerm(monster: Monsters.ドラゴンパピー, hpLimit: 250, priority: 5)
                    .AddNecessarySkill(Skills.放射火炎),
                new TransTerm(monster: Monsters.ドラゴンパピー, hpLimit: 250, priority: 5)
                    .AddNecessarySkill(Skills.高温ガス),

                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.突進)
                    .AddNecessarySkill(Skills.催眠),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.突進)
                    .AddNecessarySkill(Skills.石化凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.突進)
                    .AddNecessarySkill(Skills.マヒ凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.突進)
                    .AddNecessarySkill(Skills.魅了凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.体当たり)
                    .AddNecessarySkill(Skills.催眠),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.体当たり)
                    .AddNecessarySkill(Skills.石化凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.体当たり)
                    .AddNecessarySkill(Skills.マヒ凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.体当たり)
                    .AddNecessarySkill(Skills.魅了凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.暴走)
                    .AddNecessarySkill(Skills.催眠),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.暴走)
                    .AddNecessarySkill(Skills.石化凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.暴走)
                    .AddNecessarySkill(Skills.マヒ凝視),
                new TransTerm(monster: Monsters.リビングアーマー, hpLimit: 250, priority: 10)
                    .AddNecessarySkill(Skills.暴走)
                    .AddNecessarySkill(Skills.魅了凝視),

                new TransTerm(monster: Monsters.ロッキー, hpLimit: 250, priority: 15)
                    .AddNecessarySkill(Skills.ぽんぽこ),

                new TransTerm(monster: Monsters.マッドアクス, hpLimit: 250, priority: 20)
                    .AddNecessarySkill(Skills.ブレード),

                new TransTerm(monster: Monsters.キラービー, hpLimit: 250, priority: 25)
                    .AddNecessarySkill(Skills.エクトプラズムネット),
                new TransTerm(monster: Monsters.キラービー, hpLimit: 250, priority: 25)
                    .AddNecessarySkill(Skills.スパイダーネット),
                new TransTerm(monster: Monsters.キラービー, hpLimit: 250, priority: 25)
                    .AddNecessarySkill(Skills.ブレードネット),

                new TransTerm(monster: Monsters.ウィップジェリー, hpLimit: 250, priority: 30)
                    .AddNecessarySkill(Skills.触手),

                new TransTerm(monster: Monsters.トリケプス, hpLimit: 250, priority: 35)
                    .AddNecessarySkill(Skills.電撃),
                new TransTerm(monster: Monsters.トリケプス, hpLimit: 250, priority: 35)
                    .AddNecessarySkill(Skills.放射電撃),

                new TransTerm(monster: Monsters.アクスビーク, hpLimit: 250, priority: 40)
                    .AddNecessarySkill(Skills.地響き),

                new TransTerm(monster: Monsters.ウィップジェリー, hpLimit: 250, priority: 45)
                    .AddNecessarySkill(Skills.足払い),

                new TransTerm(monster: Monsters.アームウォーカー, hpLimit: 250, priority: 50)
                    .AddNecessarySkill(Skills.角),

                new TransTerm(monster: Monsters.シェルワーム, hpLimit: 250, priority: 55)
                    .AddNecessarySkill(Skills.ハサミ),

                new TransTerm(monster: Monsters.ワンダーランス, hpLimit: 250, priority: 55)
                    .AddNecessarySkill(Skills.突き),

                new TransTerm(monster: Monsters.フェイトード, hpLimit: 250, priority: 60)
                    .AddNecessarySkill(Skills.キック),

                new TransTerm(monster: Monsters.ゴースト, hpLimit: 250, priority: 65)
                    .AddNecessarySkill(Skills.死の属性),

                new TransTerm(monster: Monsters.ラバット, hpLimit: 250, priority: 70)
                    .AddNecessarySkill(Skills.吸血),

                new TransTerm(monster: Monsters.スポアパイル, hpLimit: 250, priority: 75)
                    .AddNecessarySkill(Skills.胞子),


                new TransTerm(monster: Monsters.キラービー, hpLimit: 125, priority: 5)
                    .AddNecessarySkill(Skills.毒針),
                new TransTerm(monster: Monsters.キラービー, hpLimit: 125, priority: 5)
                    .AddNecessarySkill(Skills.スカッシュ),


                new TransTerm(monster: Monsters.ゼノ, hpLimit: 120, priority: 5)
                    .AddNecessarySkill(Skills.牙),


                new TransTerm(monster: Monsters.マッドアクス, hpLimit: 110, priority: 5)
                    .AddNecessarySkill(Skills.ダブルアクス),


                new TransTerm(monster: Monsters.ピックバード, hpLimit: 105, priority: 5)
                    .AddNecessarySkill(Skills.クチバシ),

                new TransTerm(monster: Monsters.スパルトイ, hpLimit: 100, priority: 5)
                    .AddNecessarySkill(Skills.死の属性)
            };
        }
    }
}