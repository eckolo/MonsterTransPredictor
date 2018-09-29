using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    public partial class DbInitializer
    {
        struct Skills
        {
            public static Skill fang = new Skill(name: "牙", partsType: PartsType.head);
            public static Skill fangCrash = new Skill(name: "ファングクラッシュ", partsType: PartsType.head);
            public static Skill beak = new Skill(name: "クチバシ", partsType: PartsType.head);
            public static Skill horn = new Skill(name: "角", partsType: PartsType.head);
            public static Skill mahiStare = new Skill(name: "マヒ凝視", partsType: PartsType.head);
            public static Skill fascinationGaze = new Skill(name: "魅了凝視", partsType: PartsType.head);
            public static Skill stoneGaze = new Skill(name: "石化凝視", partsType: PartsType.head);
            public static Skill stareOfDeath = new Skill(name: "死の凝視", partsType: PartsType.head);
            public static Skill hypnotism = new Skill(name: "催眠", partsType: PartsType.head);
            public static Skill bloodSucking = new Skill(name: "吸血", partsType: PartsType.head);
            public static Skill marunomi = new Skill(name: "丸のみ", partsType: PartsType.head);
            public static Skill stoning = new Skill(name: "石化撃", partsType: PartsType.head);
            public static Skill dagasvarHi = new Skill(name: "ダガージョウ", partsType: PartsType.head);
            public static Skill veiperBlast = new Skill(name: "ヴェイパーブラスト", partsType: PartsType.head);
            public static Skill vanish = new Skill(name: "バニッシュ", partsType: PartsType.head);
            public static Skill reverseGravity = new Skill(name: "リバースグラビティ", partsType: PartsType.head);
            public static Skill lightShift = new Skill(name: "ライトシフト", partsType: PartsType.head);
            public static Skill darkShift = new Skill(name: "ダークシフト", partsType: PartsType.head);
            public static Skill votek = new Skill(name: "ヴォーテクス", partsType: PartsType.head);

            public static Skill doubleAx = new Skill(name: "ダブルアクス", partsType: PartsType.arm);
            public static Skill brainCrash = new Skill(name: "ブレインクラッシュ", partsType: PartsType.arm);
            public static Skill blow = new Skill(name: "打撃", partsType: PartsType.arm);
            public static Skill scissors = new Skill(name: "ハサミ", partsType: PartsType.arm);
            public static Skill smashed = new Skill(name: "強打", partsType: PartsType.arm);
            public static Skill fakeOut = new Skill(name: "ねこだまし", partsType: PartsType.arm);
            public static Skill summing = new Skill(name: "サミング", partsType: PartsType.arm);
            public static Skill tentacle = new Skill(name: "触手", partsType: PartsType.arm);
            public static Skill claw = new Skill(name: "爪", partsType: PartsType.arm);
            public static Skill poisonAttack = new Skill(name: "毒撃", partsType: PartsType.arm);
            public static Skill ghostTouch = new Skill(name: "ゴーストタッチ", partsType: PartsType.arm);
            public static Skill destatch = new Skill(name: "デスタッチ", partsType: PartsType.arm);
            public static Skill paralysisTouch = new Skill(name: "パラリシスタッチ", partsType: PartsType.arm);
            public static Skill blade = new Skill(name: "ブレード", partsType: PartsType.arm);
            public static Skill strongWindBlow = new Skill(name: "烈風撃", partsType: PartsType.arm);
            public static Skill swordOfKusanagi = new Skill(name: "草薙の剣", partsType: PartsType.arm);
            public static Skill ironFistOfAnger = new Skill(name: "怒りの鉄拳", partsType: PartsType.arm);
            public static Skill grandHit = new Skill(name: "グランドヒット", partsType: PartsType.arm);
            public static Skill heatSmash = new Skill(name: "ヒートスマッシュ", partsType: PartsType.arm);
            public static Skill iceSmash = new Skill(name: "アイススマッシュ", partsType: PartsType.arm);
            public static Skill titusWave = new Skill(name: "タイタスウェイヴ", partsType: PartsType.arm);
            public static Skill thrust = new Skill(name: "突き", partsType: PartsType.arm);
            public static Skill boomerangHook = new Skill(name: "ブーメランフック", partsType: PartsType.arm);

            public static Skill kick = new Skill(name: "キック", partsType: PartsType.leg);
            public static Skill fumble = new Skill(name: "ふみつけ", partsType: PartsType.leg);
            public static Skill tail = new Skill(name: "しっぽ", partsType: PartsType.leg);
            public static Skill shock = new Skill(name: "尾撃", partsType: PartsType.leg);
            public static Skill tripped = new Skill(name: "足払い", partsType: PartsType.leg);
            public static Skill squash = new Skill(name: "スカッシュ", partsType: PartsType.leg);
            public static Skill poisonedNeedle = new Skill(name: "毒針", partsType: PartsType.leg);
            public static Skill feint = new Skill(name: "フェイント", partsType: PartsType.leg);
            public static Skill centipedeTramp = new Skill(name: "百足蹂躙", partsType: PartsType.leg);
            public static Skill griffithScratch = new Skill(name: "グリフィススクラッチ", partsType: PartsType.leg);

            public static Skill minionStrike = new Skill(name: "ミニオンストライク", partsType: PartsType.body);
            public static Skill hairTrimming = new Skill(name: "毛繕い", partsType: PartsType.body);
            public static Skill pimp = new Skill(name: "まきつき", partsType: PartsType.body);
            public static Skill bodyBlow = new Skill(name: "体当たり", partsType: PartsType.body);
            public static Skill rush = new Skill(name: "突進", partsType: PartsType.body);
            public static Skill bitch = new Skill(name: "ぶちかまし", partsType: PartsType.body);
            public static Skill runaway = new Skill(name: "暴走", partsType: PartsType.body);
            public static Skill wing = new Skill(name: "翼", partsType: PartsType.body);
            public static Skill gliderSpike = new Skill(name: "グライダースパイク", partsType: PartsType.body);
            public static Skill vibrationWave = new Skill(name: "振動波", partsType: PartsType.body);
            public static Skill knotOfFire = new Skill(name: "炎のくちづけ", partsType: PartsType.body);
            public static Skill spore = new Skill(name: "胞子", partsType: PartsType.body);
            public static Skill seedBalkan = new Skill(name: "シードバルカン", partsType: PartsType.body);
            public static Skill lysisSolution = new Skill(name: "溶解液", partsType: PartsType.body);
            public static Skill needle = new Skill(name: "針", partsType: PartsType.body);
            public static Skill fireBarrier = new Skill(name: "ファイアーバリア", partsType: PartsType.body);
            public static Skill freezeBarrier = new Skill(name: "フリーズバリア", partsType: PartsType.body);
            public static Skill thunderBarrier = new Skill(name: "サンダーバリア", partsType: PartsType.body);
            public static Skill counterFear = new Skill(name: "カウンターフィアー", partsType: PartsType.body);
            public static Skill psyReflector = new Skill(name: "サイ・リフレクター", partsType: PartsType.body);
            public static Skill photosynthesis = new Skill(name: "光合成", partsType: PartsType.body);
            public static Skill attributionOfDeath = new Skill(name: "死の属性", partsType: PartsType.body);

            public static Skill highTemperatureGas = new Skill(name: "高温ガス", partsType: PartsType.breath);
            public static Skill flame = new Skill(name: "火炎", partsType: PartsType.breath);
            public static Skill radiationFlame = new Skill(name: "放射火炎", partsType: PartsType.breath);
            public static Skill cold = new Skill(name: "冷気", partsType: PartsType.breath);
            public static Skill electricShock = new Skill(name: "電撃", partsType: PartsType.breath);
            public static Skill radiationShock = new Skill(name: "放射電撃", partsType: PartsType.breath);
            public static Skill ink = new Skill(name: "スミ", partsType: PartsType.breath);
            public static Skill waterHammer = new Skill(name: "水撃", partsType: PartsType.breath);
            public static Skill badSmell = new Skill(name: "悪臭", partsType: PartsType.breath);
            public static Skill poisonGas = new Skill(name: "毒ガス", partsType: PartsType.breath);
            public static Skill petroleumGas = new Skill(name: "石化ガス", partsType: PartsType.breath);
            public static Skill sleepingGas = new Skill(name: "睡眠ガス", partsType: PartsType.breath);
            public static Skill tripGas = new Skill(name: "トリップガス", partsType: PartsType.breath);
            public static Skill beetleJuice = new Skill(name: "ビートルジュース", partsType: PartsType.breath);
            public static Skill strongAcid = new Skill(name: "強酸", partsType: PartsType.breath);
            public static Skill deadManMoss = new Skill(name: "死人ゴケ", partsType: PartsType.breath);
            public static Skill venom = new Skill(name: "毒液", partsType: PartsType.breath);
            public static Skill sphinxRiddle = new Skill(name: "スフィンクスリドル", partsType: PartsType.breath);

            public static Skill lifeAbsorption = new Skill(name: "生気吸収", partsType: PartsType.magic);
            public static Skill temptation = new Skill(name: "誘惑", partsType: PartsType.magic);
            public static Skill pheromone = new Skill(name: "フェロモン", partsType: PartsType.magic);
            public static Skill flash = new Skill(name: "閃光", partsType: PartsType.magic);
            public static Skill spiderNet = new Skill(name: "スパイダーネット", partsType: PartsType.magic);
            public static Skill bladeNet = new Skill(name: "ブレードネット", partsType: PartsType.magic);
            public static Skill ectoplasmNet = new Skill(name: "エクトプラズムネット", partsType: PartsType.magic);
            public static Skill lightning = new Skill(name: "落雷", partsType: PartsType.magic);
            public static Skill painPowder = new Skill(name: "ペインパウダー", partsType: PartsType.magic);
            public static Skill toxinFog = new Skill(name: "毒霧", partsType: PartsType.magic);
            public static Skill illStorm = new Skill(name: "イルストーム", partsType: PartsType.magic);
            public static Skill strongWind = new Skill(name: "強風", partsType: PartsType.magic);
            public static Skill tornado = new Skill(name: "竜巻", partsType: PartsType.magic);
            public static Skill chant = new Skill(name: "聖歌", partsType: PartsType.magic);
            public static Skill magicalHeel = new Skill(name: "マジカルヒール", partsType: PartsType.magic);
            public static Skill assist = new Skill(name: "アシスト", partsType: PartsType.magic);
            public static Skill spoil = new Skill(name: "スポイル", partsType: PartsType.magic);
            public static Skill gremlinTouch = new Skill(name: "グレムリンタッチ", partsType: PartsType.magic);
            public static Skill heatWave = new Skill(name: "ヒートウェイヴ", partsType: PartsType.magic);
            public static Skill mightyCyclone = new Skill(name: "マイティサイクロン", partsType: PartsType.magic);
            public static Skill mailstrom = new Skill(name: "メイルシュトローム", partsType: PartsType.magic);
            public static Skill elfShot = new Skill(name: "エルフショット", partsType: PartsType.magic);
            public static Skill ultrasonicWave = new Skill(name: "超音波", partsType: PartsType.magic);
            public static Skill lullaby = new Skill(name: "ララバイ", partsType: PartsType.magic);
            public static Skill scream = new Skill(name: "スクリーム", partsType: PartsType.magic);
            public static Skill siren = new Skill(name: "サイレン", partsType: PartsType.magic);
            public static Skill ponpoko = new Skill(name: "ぽんぽこ", partsType: PartsType.magic);
            public static Skill lightBall = new Skill(name: "ライトボール", partsType: PartsType.magic);
            public static Skill earthSound = new Skill(name: "地響き", partsType: PartsType.magic);
            public static Skill earthquake = new Skill(name: "地震", partsType: PartsType.magic);
            public static Skill quicksand = new Skill(name: "流砂", partsType: PartsType.magic);
            public static Skill rock = new Skill(name: "岩石", partsType: PartsType.magic);
            public static Skill magneticStorm = new Skill(name: "磁気嵐", partsType: PartsType.magic);
            public static Skill battleSong = new Skill(name: "バトルソング", partsType: PartsType.magic);
            public static Skill sadSong = new Skill(name: "サッドソング", partsType: PartsType.magic);
            public static Skill silpheed = new Skill(name: "シルフィード", partsType: PartsType.magic);
            public static Skill ignisStream = new Skill(name: "イグニスストリーム", partsType: PartsType.magic);
            public static Skill rainOfLife = new Skill(name: "生命の雨", partsType: PartsType.magic);
            public static Skill songOfKirin = new Skill(name: "麒麟の歌", partsType: PartsType.magic);
        }
    }
}