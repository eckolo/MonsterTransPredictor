using MonsterTransPredictor.Models.Application.Entity;
using MonsterTransPredictor.Models.Application.Value;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    public partial class DbInitializer
    {
        struct Skills
        {
            public static Skill 牙 = new Skill(name: "牙", partsType: PartsType.head);
            public static Skill ファングクラッシュ = new Skill(name: "ファングクラッシュ", partsType: PartsType.head);
            public static Skill クチバシ = new Skill(name: "クチバシ", partsType: PartsType.head);
            public static Skill 角 = new Skill(name: "角", partsType: PartsType.head);
            public static Skill マヒ凝視 = new Skill(name: "マヒ凝視", partsType: PartsType.head);
            public static Skill 魅了凝視 = new Skill(name: "魅了凝視", partsType: PartsType.head);
            public static Skill 石化凝視 = new Skill(name: "石化凝視", partsType: PartsType.head);
            public static Skill 死の凝視 = new Skill(name: "死の凝視", partsType: PartsType.head);
            public static Skill 催眠 = new Skill(name: "催眠", partsType: PartsType.head);
            public static Skill 吸血 = new Skill(name: "吸血", partsType: PartsType.head);
            public static Skill 丸のみ = new Skill(name: "丸のみ", partsType: PartsType.head);
            public static Skill 石化撃 = new Skill(name: "石化撃", partsType: PartsType.head);
            public static Skill ダガージョウ = new Skill(name: "ダガージョウ", partsType: PartsType.head);
            public static Skill ヴェイパーブラスト = new Skill(name: "ヴェイパーブラスト", partsType: PartsType.head);
            public static Skill バニッシュ = new Skill(name: "バニッシュ", partsType: PartsType.head);
            public static Skill リバースグラビティ = new Skill(name: "リバースグラビティ", partsType: PartsType.head);
            public static Skill ライトシフト = new Skill(name: "ライトシフト", partsType: PartsType.head);
            public static Skill ダークシフト = new Skill(name: "ダークシフト", partsType: PartsType.head);
            public static Skill ヴォーテクス = new Skill(name: "ヴォーテクス", partsType: PartsType.head);

            public static Skill ダブルアクス = new Skill(name: "ダブルアクス", partsType: PartsType.arm);
            public static Skill ブレインクラッシュ = new Skill(name: "ブレインクラッシュ", partsType: PartsType.arm);
            public static Skill 打撃 = new Skill(name: "打撃", partsType: PartsType.arm);
            public static Skill ハサミ = new Skill(name: "ハサミ", partsType: PartsType.arm);
            public static Skill 強打 = new Skill(name: "強打", partsType: PartsType.arm);
            public static Skill ねこだまし = new Skill(name: "ねこだまし", partsType: PartsType.arm);
            public static Skill サミング = new Skill(name: "サミング", partsType: PartsType.arm);
            public static Skill 触手 = new Skill(name: "触手", partsType: PartsType.arm);
            public static Skill 爪 = new Skill(name: "爪", partsType: PartsType.arm);
            public static Skill 毒撃 = new Skill(name: "毒撃", partsType: PartsType.arm);
            public static Skill ゴーストタッチ = new Skill(name: "ゴーストタッチ", partsType: PartsType.arm);
            public static Skill デスタッチ = new Skill(name: "デスタッチ", partsType: PartsType.arm);
            public static Skill パラリシスタッチ = new Skill(name: "パラリシスタッチ", partsType: PartsType.arm);
            public static Skill ブレード = new Skill(name: "ブレード", partsType: PartsType.arm);
            public static Skill 烈風撃 = new Skill(name: "烈風撃", partsType: PartsType.arm);
            public static Skill 草薙の剣 = new Skill(name: "草薙の剣", partsType: PartsType.arm);
            public static Skill 怒りの鉄拳 = new Skill(name: "怒りの鉄拳", partsType: PartsType.arm);
            public static Skill グランドヒット = new Skill(name: "グランドヒット", partsType: PartsType.arm);
            public static Skill ヒートスマッシュ = new Skill(name: "ヒートスマッシュ", partsType: PartsType.arm);
            public static Skill アイススマッシュ = new Skill(name: "アイススマッシュ", partsType: PartsType.arm);
            public static Skill タイタスウェイヴ = new Skill(name: "タイタスウェイヴ", partsType: PartsType.arm);
            public static Skill 突き = new Skill(name: "突き", partsType: PartsType.arm);
            public static Skill ブーメランフック = new Skill(name: "ブーメランフック", partsType: PartsType.arm);

            public static Skill キック = new Skill(name: "キック", partsType: PartsType.leg);
            public static Skill ふみつけ = new Skill(name: "ふみつけ", partsType: PartsType.leg);
            public static Skill しっぽ = new Skill(name: "しっぽ", partsType: PartsType.leg);
            public static Skill 尾撃 = new Skill(name: "尾撃", partsType: PartsType.leg);
            public static Skill 足払い = new Skill(name: "足払い", partsType: PartsType.leg);
            public static Skill スカッシュ = new Skill(name: "スカッシュ", partsType: PartsType.leg);
            public static Skill 毒針 = new Skill(name: "毒針", partsType: PartsType.leg);
            public static Skill フェイント = new Skill(name: "フェイント", partsType: PartsType.leg);
            public static Skill 百足蹂躙 = new Skill(name: "百足蹂躙", partsType: PartsType.leg);
            public static Skill グリフィススクラッチ = new Skill(name: "グリフィススクラッチ", partsType: PartsType.leg);

            public static Skill ミニオンストライク = new Skill(name: "ミニオンストライク", partsType: PartsType.body);
            public static Skill 毛繕い = new Skill(name: "毛繕い", partsType: PartsType.body);
            public static Skill まきつき = new Skill(name: "まきつき", partsType: PartsType.body);
            public static Skill 体当たり = new Skill(name: "体当たり", partsType: PartsType.body);
            public static Skill 突進 = new Skill(name: "突進", partsType: PartsType.body);
            public static Skill ぶちかまし = new Skill(name: "ぶちかまし", partsType: PartsType.body);
            public static Skill 暴走 = new Skill(name: "暴走", partsType: PartsType.body);
            public static Skill 翼 = new Skill(name: "翼", partsType: PartsType.body);
            public static Skill グライダースパイク = new Skill(name: "グライダースパイク", partsType: PartsType.body);
            public static Skill 振動波 = new Skill(name: "振動波", partsType: PartsType.body);
            public static Skill 炎のくちづけ = new Skill(name: "炎のくちづけ", partsType: PartsType.body);
            public static Skill 胞子 = new Skill(name: "胞子", partsType: PartsType.body);
            public static Skill シードバルカン = new Skill(name: "シードバルカン", partsType: PartsType.body);
            public static Skill 溶解液 = new Skill(name: "溶解液", partsType: PartsType.body);
            public static Skill 針 = new Skill(name: "針", partsType: PartsType.body);
            public static Skill ファイアーバリア = new Skill(name: "ファイアーバリア", partsType: PartsType.body);
            public static Skill フリーズバリア = new Skill(name: "フリーズバリア", partsType: PartsType.body);
            public static Skill サンダーバリア = new Skill(name: "サンダーバリア", partsType: PartsType.body);
            public static Skill カウンターフィアー = new Skill(name: "カウンターフィアー", partsType: PartsType.body);
            public static Skill サイリフレクター = new Skill(name: "サイ・リフレクター", partsType: PartsType.body);
            public static Skill 光合成 = new Skill(name: "光合成", partsType: PartsType.body);
            public static Skill 死の属性 = new Skill(name: "死の属性", partsType: PartsType.body);

            public static Skill 高温ガス = new Skill(name: "高温ガス", partsType: PartsType.breath);
            public static Skill 火炎 = new Skill(name: "火炎", partsType: PartsType.breath);
            public static Skill 放射火炎 = new Skill(name: "放射火炎", partsType: PartsType.breath);
            public static Skill 冷気 = new Skill(name: "冷気", partsType: PartsType.breath);
            public static Skill 電撃 = new Skill(name: "電撃", partsType: PartsType.breath);
            public static Skill 放射電撃 = new Skill(name: "放射電撃", partsType: PartsType.breath);
            public static Skill スミ = new Skill(name: "スミ", partsType: PartsType.breath);
            public static Skill 水撃 = new Skill(name: "水撃", partsType: PartsType.breath);
            public static Skill 悪臭 = new Skill(name: "悪臭", partsType: PartsType.breath);
            public static Skill 毒ガス = new Skill(name: "毒ガス", partsType: PartsType.breath);
            public static Skill 石化ガス = new Skill(name: "石化ガス", partsType: PartsType.breath);
            public static Skill 睡眠ガス = new Skill(name: "睡眠ガス", partsType: PartsType.breath);
            public static Skill トリップガス = new Skill(name: "トリップガス", partsType: PartsType.breath);
            public static Skill ビートルジュース = new Skill(name: "ビートルジュース", partsType: PartsType.breath);
            public static Skill 強酸 = new Skill(name: "強酸", partsType: PartsType.breath);
            public static Skill 死人ゴケ = new Skill(name: "死人ゴケ", partsType: PartsType.breath);
            public static Skill 毒液 = new Skill(name: "毒液", partsType: PartsType.breath);
            public static Skill スフィンクスリドル = new Skill(name: "スフィンクスリドル", partsType: PartsType.breath);

            public static Skill 生気吸収 = new Skill(name: "生気吸収", partsType: PartsType.magic);
            public static Skill 誘惑 = new Skill(name: "誘惑", partsType: PartsType.magic);
            public static Skill フェロモン = new Skill(name: "フェロモン", partsType: PartsType.magic);
            public static Skill 閃光 = new Skill(name: "閃光", partsType: PartsType.magic);
            public static Skill スパイダーネット = new Skill(name: "スパイダーネット", partsType: PartsType.magic);
            public static Skill ブレードネット = new Skill(name: "ブレードネット", partsType: PartsType.magic);
            public static Skill エクトプラズムネット = new Skill(name: "エクトプラズムネット", partsType: PartsType.magic);
            public static Skill 落雷 = new Skill(name: "落雷", partsType: PartsType.magic);
            public static Skill ペインパウダー = new Skill(name: "ペインパウダー", partsType: PartsType.magic);
            public static Skill 毒霧 = new Skill(name: "毒霧", partsType: PartsType.magic);
            public static Skill イルストーム = new Skill(name: "イルストーム", partsType: PartsType.magic);
            public static Skill 強風 = new Skill(name: "強風", partsType: PartsType.magic);
            public static Skill 竜巻 = new Skill(name: "竜巻", partsType: PartsType.magic);
            public static Skill 聖歌 = new Skill(name: "聖歌", partsType: PartsType.magic);
            public static Skill マジカルヒール = new Skill(name: "マジカルヒール", partsType: PartsType.magic);
            public static Skill アシスト = new Skill(name: "アシスト", partsType: PartsType.magic);
            public static Skill スポイル = new Skill(name: "スポイル", partsType: PartsType.magic);
            public static Skill グレムリンタッチ = new Skill(name: "グレムリンタッチ", partsType: PartsType.magic);
            public static Skill ヒートウェイヴ = new Skill(name: "ヒートウェイヴ", partsType: PartsType.magic);
            public static Skill マイティサイクロン = new Skill(name: "マイティサイクロン", partsType: PartsType.magic);
            public static Skill メイルシュトローム = new Skill(name: "メイルシュトローム", partsType: PartsType.magic);
            public static Skill エルフショット = new Skill(name: "エルフショット", partsType: PartsType.magic);
            public static Skill 超音波 = new Skill(name: "超音波", partsType: PartsType.magic);
            public static Skill ララバイ = new Skill(name: "ララバイ", partsType: PartsType.magic);
            public static Skill スクリーム = new Skill(name: "スクリーム", partsType: PartsType.magic);
            public static Skill サイレン = new Skill(name: "サイレン", partsType: PartsType.magic);
            public static Skill ぽんぽこ = new Skill(name: "ぽんぽこ", partsType: PartsType.magic);
            public static Skill ライトボール = new Skill(name: "ライトボール", partsType: PartsType.magic);
            public static Skill 地響き = new Skill(name: "地響き", partsType: PartsType.magic);
            public static Skill 地震 = new Skill(name: "地震", partsType: PartsType.magic);
            public static Skill 流砂 = new Skill(name: "流砂", partsType: PartsType.magic);
            public static Skill 岩石 = new Skill(name: "岩石", partsType: PartsType.magic);
            public static Skill 磁気嵐 = new Skill(name: "磁気嵐", partsType: PartsType.magic);
            public static Skill バトルソング = new Skill(name: "バトルソング", partsType: PartsType.magic);
            public static Skill サッドソング = new Skill(name: "サッドソング", partsType: PartsType.magic);
            public static Skill シルフィード = new Skill(name: "シルフィード", partsType: PartsType.magic);
            public static Skill イグニスストリーム = new Skill(name: "イグニスストリーム", partsType: PartsType.magic);
            public static Skill 生命の雨 = new Skill(name: "生命の雨", partsType: PartsType.magic);
            public static Skill 麒麟の歌 = new Skill(name: "麒麟の歌", partsType: PartsType.magic);
        }
    }
}