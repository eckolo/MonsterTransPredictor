using MonsterTransPredictor.Models.Application.Entity;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    public partial class DbInitializer
    {
        struct Monsters
        {
            public static Monster ロッキー = new Monster(name: "ロッキー")
                .AddLearnableSkill(Skills.しっぽ)
                .AddLearnableSkill(Skills.ねこだまし)
                .AddLearnableSkill(Skills.ぽんぽこ)
                .AddLearnableSkill(Skills.毛繕い);
            public static Monster ヘッジホッグ = new Monster(name: "ヘッジホッグ")
                .AddLearnableSkill(Skills.針)
                .AddLearnableSkill(Skills.体当たり)
                .AddLearnableSkill(Skills.しっぽ)
                .AddLearnableSkill(Skills.超音波);
            public static Monster バーゲスト = new Monster(name: "バーゲスト")
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.ダガージョウ)
                .AddLearnableSkill(Skills.スカッシュ);
            public static Monster モンキーライダー = new Monster(name: "モンキーライダー")
                .AddLearnableSkill(Skills.催眠)
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.暴走)
                .AddLearnableSkill(Skills.マヒ凝視);
            public static Monster ヘルハウンド = new Monster(name: "ヘルハウンド")
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.放射火炎);
            public static Monster マンティコア = new Monster(name: "マンティコア")
                .AddLearnableSkill(Skills.悪臭)
                .AddLearnableSkill(Skills.針)
                .AddLearnableSkill(Skills.ビートルジュース)
                .AddLearnableSkill(Skills.スクリーム);
            public static Monster ユニコーン = new Monster(name: "ユニコーン")
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.マジカルヒール)
                .AddLearnableSkill(Skills.暴走)
                .AddLearnableSkill(Skills.生命の雨);
            public static Monster ブッチ = new Monster(name: "ブッチ")
                .AddLearnableSkill(Skills.スポイル)
                .AddLearnableSkill(Skills.怒りの鉄拳)
                .AddLearnableSkill(Skills.スカッシュ)
                .AddLearnableSkill(Skills.毛繕い);
            public static Monster キマイラ = new Monster(name: "キマイラ")
                .AddLearnableSkill(Skills.強打)
                .AddLearnableSkill(Skills.高温ガス)
                .AddLearnableSkill(Skills.ふみつけ)
                .AddLearnableSkill(Skills.ファングクラッシュ);

            public static Monster プリクタス = new Monster(name: "プリクタス")
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.体当たり);
            public static Monster スポアパイル = new Monster(name: "スポアパイル")
                .AddLearnableSkill(Skills.胞子)
                .AddLearnableSkill(Skills.スパイダーネット)
                .AddLearnableSkill(Skills.マジカルヒール);
            public static Monster マンドレイク = new Monster(name: "マンドレイク")
                .AddLearnableSkill(Skills.睡眠ガス)
                .AddLearnableSkill(Skills.スクリーム)
                .AddLearnableSkill(Skills.マジカルヒール);
            public static Monster トラップバイン = new Monster(name: "トラップバイン")
                .AddLearnableSkill(Skills.丸のみ)
                .AddLearnableSkill(Skills.足払い)
                .AddLearnableSkill(Skills.強酸)
                .AddLearnableSkill(Skills.触手);
            public static Monster ナイトシェイド = new Monster(name: "ナイトシェイド")
                .AddLearnableSkill(Skills.ペインパウダー)
                .AddLearnableSkill(Skills.スクリーム)
                .AddLearnableSkill(Skills.サッドソング)
                .AddLearnableSkill(Skills.マヒ凝視);
            public static Monster トレント = new Monster(name: "トレント")
                .AddLearnableSkill(Skills.光合成)
                .AddLearnableSkill(Skills.サミング)
                .AddLearnableSkill(Skills.触手)
                .AddLearnableSkill(Skills.打撃);
            public static Monster サンフラワー = new Monster(name: "サンフラワー")
                .AddLearnableSkill(Skills.光合成)
                .AddLearnableSkill(Skills.閃光)
                .AddLearnableSkill(Skills.シードバルカン)
                .AddLearnableSkill(Skills.ヒートウェイヴ);
            public static Monster シュリーカー = new Monster(name: "シュリーカー")
                .AddLearnableSkill(Skills.胞子)
                .AddLearnableSkill(Skills.地響き)
                .AddLearnableSkill(Skills.トリップガス)
                .AddLearnableSkill(Skills.サッドソング);
            public static Monster 化石樹 = new Monster(name: "化石樹")
                .AddLearnableSkill(Skills.針)
                .AddLearnableSkill(Skills.烈風撃)
                .AddLearnableSkill(Skills.石化ガス)
                .AddLearnableSkill(Skills.磁気嵐);

            public static Monster フェイトード = new Monster(name: "フェイトード")
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.超音波);
            public static Monster ガンフィッシュ = new Monster(name: "ガンフィッシュ")
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.体当たり)
                .AddLearnableSkill(Skills.打撃);
            public static Monster ソルジャービル = new Monster(name: "ソルジャービル")
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.足払い)
                .AddLearnableSkill(Skills.岩石)
                .AddLearnableSkill(Skills.超音波);
            public static Monster マフラーザウルス = new Monster(name: "マフラーザウルス")
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.電撃)
                .AddLearnableSkill(Skills.暴走);
            public static Monster ガイアトード = new Monster(name: "ガイアトード")
                .AddLearnableSkill(Skills.強酸)
                .AddLearnableSkill(Skills.丸のみ)
                .AddLearnableSkill(Skills.ふみつけ)
                .AddLearnableSkill(Skills.超音波);
            public static Monster トリケプス = new Monster(name: "トリケプス")
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.地響き)
                .AddLearnableSkill(Skills.尾撃)
                .AddLearnableSkill(Skills.ふみつけ);
            public static Monster 玄武 = new Monster(name: "玄武")
                .AddLearnableSkill(Skills.落雷)
                .AddLearnableSkill(Skills.竜巻)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.ファングクラッシュ);
            public static Monster バジリスク = new Monster(name: "バジリスク")
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.毒ガス)
                .AddLearnableSkill(Skills.毒撃)
                .AddLearnableSkill(Skills.石化凝視);
            public static Monster クラーケン = new Monster(name: "クラーケン")
                .AddLearnableSkill(Skills.スミ)
                .AddLearnableSkill(Skills.触手)
                .AddLearnableSkill(Skills.メイルシュトローム)
                .AddLearnableSkill(Skills.マイティサイクロン);

            public static Monster シェルワーム = new Monster(name: "シェルワーム")
                .AddLearnableSkill(Skills.ハサミ)
                .AddLearnableSkill(Skills.スミ)
                .AddLearnableSkill(Skills.体当たり);
            public static Monster アームウォーカー = new Monster(name: "アームウォーカー")
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.スパイダーネット)
                .AddLearnableSkill(Skills.ビートルジュース);
            public static Monster キラービー = new Monster(name: "キラービー")
                .AddLearnableSkill(Skills.ブレードネット)
                .AddLearnableSkill(Skills.スパイダーネット)
                .AddLearnableSkill(Skills.突き)
                .AddLearnableSkill(Skills.スカッシュ);
            public static Monster デスポーカー = new Monster(name: "デスポーカー")
                .AddLearnableSkill(Skills.ハサミ)
                .AddLearnableSkill(Skills.毒針)
                .AddLearnableSkill(Skills.グランドヒット)
                .AddLearnableSkill(Skills.サッドソング);
            public static Monster グルームモス = new Monster(name: "グルームモス")
                .AddLearnableSkill(Skills.ペインパウダー)
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.フェロモン)
                .AddLearnableSkill(Skills.スポイル);
            public static Monster ラバーウォーム = new Monster(name: "ラバーウォーム")
                .AddLearnableSkill(Skills.強酸)
                .AddLearnableSkill(Skills.暴走)
                .AddLearnableSkill(Skills.悪臭)
                .AddLearnableSkill(Skills.流砂);
            public static Monster ゼニスマンティス = new Monster(name: "ゼニスマンティス")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.烈風撃)
                .AddLearnableSkill(Skills.振動波)
                .AddLearnableSkill(Skills.タイタスウェイヴ);
            public static Monster コスモデバウアー = new Monster(name: "コスモデバウアー")
                .AddLearnableSkill(Skills.ハサミ)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.尾撃)
                .AddLearnableSkill(Skills.マイティサイクロン);
            public static Monster ゼロディバイダー = new Monster(name: "ゼロディバイダー")
                .AddLearnableSkill(Skills.ハサミ)
                .AddLearnableSkill(Skills.石化撃)
                .AddLearnableSkill(Skills.地響き)
                .AddLearnableSkill(Skills.スポイル);

            public static Monster ピックバード = new Monster(name: "ピックバード")
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.エルフショット);
            public static Monster ラバット = new Monster(name: "ラバット")
                .AddLearnableSkill(Skills.吸血)
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.超音波);
            public static Monster ドラゴンパピー = new Monster(name: "ドラゴンパピー")
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.ファングクラッシュ);
            public static Monster ハーピー = new Monster(name: "ハーピー")
                .AddLearnableSkill(Skills.スクリーム)
                .AddLearnableSkill(Skills.ペインパウダー)
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.翼);
            public static Monster アクスビーク = new Monster(name: "アクスビーク")
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.ブレインクラッシュ)
                .AddLearnableSkill(Skills.地響き);
            public static Monster ワイバーン = new Monster(name: "ワイバーン")
                .AddLearnableSkill(Skills.強風)
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.毒針)
                .AddLearnableSkill(Skills.グライダースパイク);
            public static Monster コカトリス = new Monster(name: "コカトリス")
                .AddLearnableSkill(Skills.流砂)
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.石化撃)
                .AddLearnableSkill(Skills.強風);
            public static Monster スフィンクス = new Monster(name: "スフィンクス")
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.強風)
                .AddLearnableSkill(Skills.聖歌)
                .AddLearnableSkill(Skills.スフィンクスリドル);
            public static Monster 朱雀 = new Monster(name: "朱雀")
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.ヒートウェイヴ)
                .AddLearnableSkill(Skills.聖歌)
                .AddLearnableSkill(Skills.ファイアーバリア);

            public static Monster ゼノ = new Monster(name: "ゼノ")
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.溶解液);
            public static Monster スライム = new Monster(name: "スライム")
                .AddLearnableSkill(Skills.溶解液)
                .AddLearnableSkill(Skills.スポイル);
            public static Monster ウィップジェリー = new Monster(name: "ウィップジェリー")
                .AddLearnableSkill(Skills.まきつき)
                .AddLearnableSkill(Skills.足払い)
                .AddLearnableSkill(Skills.体当たり)
                .AddLearnableSkill(Skills.触手);
            public static Monster フューズクリスタル = new Monster(name: "フューズクリスタル")
                .AddLearnableSkill(Skills.パラリシスタッチ)
                .AddLearnableSkill(Skills.ライトボール)
                .AddLearnableSkill(Skills.アイススマッシュ)
                .AddLearnableSkill(Skills.振動波);
            public static Monster アンノウン = new Monster(name: "アンノウン")
                .AddLearnableSkill(Skills.マヒ凝視)
                .AddLearnableSkill(Skills.魅了凝視)
                .AddLearnableSkill(Skills.死の凝視)
                .AddLearnableSkill(Skills.閃光);
            public static Monster リキッドメタル = new Monster(name: "リキッドメタル")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.ヒートスマッシュ)
                .AddLearnableSkill(Skills.アイススマッシュ)
                .AddLearnableSkill(Skills.高温ガス);
            public static Monster エアエレメンタル = new Monster(name: "エアエレメンタル")
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.パラリシスタッチ)
                .AddLearnableSkill(Skills.シルフィード)
                .AddLearnableSkill(Skills.強風);
            public static Monster ゼラチナスプランター = new Monster(name: "ゼラチナスプランター")
                .AddLearnableSkill(Skills.電撃)
                .AddLearnableSkill(Skills.放射電撃)
                .AddLearnableSkill(Skills.エクトプラズムネット)
                .AddLearnableSkill(Skills.サンダーバリア);
            public static Monster 雪の精 = new Monster(name: "雪の精")
                .AddLearnableSkill(Skills.アイススマッシュ)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.強風)
                .AddLearnableSkill(Skills.フリーズバリア);

            public static Monster マッドアクス = new Monster(name: "マッドアクス")
                .AddLearnableSkill(Skills.ダブルアクス)
                .AddLearnableSkill(Skills.体当たり);
            public static Monster ワンダーランス = new Monster(name: "ワンダーランス")
                .AddLearnableSkill(Skills.突き)
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.ブレインクラッシュ);
            public static Monster ダガーグラブ = new Monster(name: "ダガーグラブ")
                .AddLearnableSkill(Skills.ダガージョウ)
                .AddLearnableSkill(Skills.打撃);
            public static Monster リビングアーマー = new Monster(name: "リビングアーマー")
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.毒液);
            public static Monster グリランドリー = new Monster(name: "グリランドリー")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.ブレードネット)
                .AddLearnableSkill(Skills.烈風撃)
                .AddLearnableSkill(Skills.振動波);
            public static Monster 魔銃 = new Monster(name: "魔銃")
                .AddLearnableSkill(Skills.シードバルカン)
                .AddLearnableSkill(Skills.閃光)
                .AddLearnableSkill(Skills.体当たり);
            public static Monster 魔鏡 = new Monster(name: "魔鏡")
                .AddLearnableSkill(Skills.ファングクラッシュ)
                .AddLearnableSkill(Skills.マジカルヒール)
                .AddLearnableSkill(Skills.死の凝視)
                .AddLearnableSkill(Skills.サイリフレクター);
            public static Monster ミミック = new Monster(name: "ミミック")
                .AddLearnableSkill(Skills.魅了凝視)
                .AddLearnableSkill(Skills.死の凝視)
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.タイタスウェイヴ);
            public static Monster ジブサムスカウト = new Monster(name: "ジブサムスカウト")
                .AddLearnableSkill(Skills.ブレインクラッシュ)
                .AddLearnableSkill(Skills.放射電撃)
                .AddLearnableSkill(Skills.ぽんぽこ)
                .AddLearnableSkill(Skills.強打);

            public static Monster スパルトイ = new Monster(name: "スパルトイ")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.突き)
                .AddLearnableSkill(Skills.グランドヒット)
                .AddLearnableSkill(Skills.ブレード);
            public static Monster ゴースト = new Monster(name: "ゴースト")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.ゴーストタッチ)
                .AddLearnableSkill(Skills.催眠)
                .AddLearnableSkill(Skills.冷気);
            public static Monster ゾンビ = new Monster(name: "ゾンビ")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.サミング)
                .AddLearnableSkill(Skills.毒撃)
                .AddLearnableSkill(Skills.まきつき);
            public static Monster ライダーゴースト = new Monster(name: "ライダーゴースト")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.超音波)
                .AddLearnableSkill(Skills.サイレン)
                .AddLearnableSkill(Skills.暴走);
            public static Monster ナイトスケルトン = new Monster(name: "ナイトスケルトン")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.グランドヒット)
                .AddLearnableSkill(Skills.生気吸収)
                .AddLearnableSkill(Skills.烈風撃);
            public static Monster アンクヘッグ = new Monster(name: "アンクヘッグ")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.生気吸収)
                .AddLearnableSkill(Skills.エクトプラズムネット)
                .AddLearnableSkill(Skills.ダガージョウ);
            public static Monster リッチ = new Monster(name: "リッチ")
                .AddLearnableSkill(Skills.デスタッチ)
                .AddLearnableSkill(Skills.死人ゴケ)
                .AddLearnableSkill(Skills.カウンターフィアー)
                .AddLearnableSkill(Skills.死の属性);
            public static Monster スカルサウルス = new Monster(name: "スカルサウルス")
                .AddLearnableSkill(Skills.死の属性)
                .AddLearnableSkill(Skills.ファングクラッシュ)
                .AddLearnableSkill(Skills.スクリーム)
                .AddLearnableSkill(Skills.放射電撃);
            public static Monster デュラハン = new Monster(name: "デュラハン")
                .AddLearnableSkill(Skills.魅了凝視)
                .AddLearnableSkill(Skills.死の凝視)
                .AddLearnableSkill(Skills.暴走)
                .AddLearnableSkill(Skills.サイレン);

            public static Monster ワンダードギー = new Monster(name: "ワンダードギー")
                .AddLearnableSkill(Skills.爪)
                .AddLearnableSkill(Skills.しっぽ)
                .AddLearnableSkill(Skills.催眠)
                .AddLearnableSkill(Skills.毛繕い);
            public static Monster ガーゴイル = new Monster(name: "ガーゴイル")
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.針)
                .AddLearnableSkill(Skills.ダガージョウ);
            public static Monster マンスネーク = new Monster(name: "マンスネーク")
                .AddLearnableSkill(Skills.爪)
                .AddLearnableSkill(Skills.しっぽ)
                .AddLearnableSkill(Skills.ブレインクラッシュ)
                .AddLearnableSkill(Skills.サミング);
            public static Monster 魚人 = new Monster(name: "魚人")
                .AddLearnableSkill(Skills.突き)
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.落雷)
                .AddLearnableSkill(Skills.シードバルカン);
            public static Monster エインヘリアル = new Monster(name: "エインヘリアル")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.閃光)
                .AddLearnableSkill(Skills.グランドヒット)
                .AddLearnableSkill(Skills.烈風撃);
            public static Monster グレムリン = new Monster(name: "グレムリン")
                .AddLearnableSkill(Skills.グレムリンタッチ)
                .AddLearnableSkill(Skills.サミング)
                .AddLearnableSkill(Skills.落雷);
            public static Monster ベクサーク = new Monster(name: "ベクサーク")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.グランドヒット)
                .AddLearnableSkill(Skills.毒ガス)
                .AddLearnableSkill(Skills.高温ガス);
            public static Monster サイバーサーカー = new Monster(name: "サイバーサーカー")
                .AddLearnableSkill(Skills.岩石)
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.地震)
                .AddLearnableSkill(Skills.強打);
            public static Monster ゼフォン = new Monster(name: "ゼフォン")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.烈風撃)
                .AddLearnableSkill(Skills.ヒートウェイヴ)
                .AddLearnableSkill(Skills.タイタスウェイヴ);

            public static Monster スプライト = new Monster(name: "スプライト")
                .AddLearnableSkill(Skills.突き)
                .AddLearnableSkill(Skills.エルフショット)
                .AddLearnableSkill(Skills.ララバイ)
                .AddLearnableSkill(Skills.マジカルヒール);
            public static Monster オンディーヌ = new Monster(name: "オンディーヌ")
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.マジカルヒール)
                .AddLearnableSkill(Skills.パラリシスタッチ);
            public static Monster ピンクパンチ = new Monster(name: "ピンクパンチ")
                .AddLearnableSkill(Skills.爪)
                .AddLearnableSkill(Skills.魅了凝視)
                .AddLearnableSkill(Skills.毛繕い)
                .AddLearnableSkill(Skills.しっぽ);
            public static Monster バンシー = new Monster(name: "バンシー")
                .AddLearnableSkill(Skills.吸血)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.スクリーム)
                .AddLearnableSkill(Skills.カウンターフィアー);
            public static Monster メロウ = new Monster(name: "メロウ")
                .AddLearnableSkill(Skills.突き)
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.マジカルヒール)
                .AddLearnableSkill(Skills.アシスト);
            public static Monster ヴァルキリー槍 = new Monster(name: "ヴァルキリー（槍）")
                .AddLearnableSkill(Skills.ライトボール)
                .AddLearnableSkill(Skills.グライダースパイク)
                .AddLearnableSkill(Skills.シルフィード)
                .AddLearnableSkill(Skills.バトルソング);
            public static Monster サキュバス = new Monster(name: "サキュバス")
                .AddLearnableSkill(Skills.ララバイ)
                .AddLearnableSkill(Skills.サッドソング)
                .AddLearnableSkill(Skills.炎のくちづけ)
                .AddLearnableSkill(Skills.誘惑);
            public static Monster ラミア = new Monster(name: "ラミア")
                .AddLearnableSkill(Skills.ララバイ)
                .AddLearnableSkill(Skills.炎のくちづけ)
                .AddLearnableSkill(Skills.誘惑)
                .AddLearnableSkill(Skills.尾撃);
            public static Monster サイレン = new Monster(name: "サイレン")
                .AddLearnableSkill(Skills.落雷)
                .AddLearnableSkill(Skills.サイレン)
                .AddLearnableSkill(Skills.ブレインクラッシュ)
                .AddLearnableSkill(Skills.グレムリンタッチ);

            public static Monster ブロンズプリマ = new Monster(name: "ブロンズプリマ")
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.足払い);
            public static Monster ロックバブーン = new Monster(name: "ロックバブーン")
                .AddLearnableSkill(Skills.ダブルアクス)
                .AddLearnableSkill(Skills.ぽんぽこ)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.強打);
            public static Monster マスカラプリマ = new Monster(name: "マスカラプリマ")
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.足払い);
            public static Monster エティン = new Monster(name: "エティン")
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.超音波)
                .AddLearnableSkill(Skills.スクリーム);
            public static Monster ゴートギガース = new Monster(name: "ゴートギガース")
                .AddLearnableSkill(Skills.ダブルアクス)
                .AddLearnableSkill(Skills.怒りの鉄拳)
                .AddLearnableSkill(Skills.強打)
                .AddLearnableSkill(Skills.毒液);
            public static Monster アースゴーレム = new Monster(name: "アースゴーレム")
                .AddLearnableSkill(Skills.地響き)
                .AddLearnableSkill(Skills.地震)
                .AddLearnableSkill(Skills.強打)
                .AddLearnableSkill(Skills.グランドヒット);
            public static Monster サイクロプス = new Monster(name: "サイクロプス")
                .AddLearnableSkill(Skills.マヒ凝視)
                .AddLearnableSkill(Skills.ぶちかまし)
                .AddLearnableSkill(Skills.地震)
                .AddLearnableSkill(Skills.岩石);
            public static Monster メタルチャリオット = new Monster(name: "メタルチャリオット")
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.暴走)
                .AddLearnableSkill(Skills.タイタスウェイヴ)
                .AddLearnableSkill(Skills.ぶちかまし);
            public static Monster 巨人 = new Monster(name: "巨人")
                .AddLearnableSkill(Skills.ブレード)
                .AddLearnableSkill(Skills.ヒートスマッシュ)
                .AddLearnableSkill(Skills.アイススマッシュ)
                .AddLearnableSkill(Skills.タイタスウェイヴ);

            public static Monster ストレイシープ = new Monster(name: "ストレイシープ")
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.スポイル)
                .AddLearnableSkill(Skills.ララバイ)
                .AddLearnableSkill(Skills.体当たり);
            public static Monster マスキャット = new Monster(name: "マスキャット")
                .AddLearnableSkill(Skills.ぽんぽこ)
                .AddLearnableSkill(Skills.毛繕い)
                .AddLearnableSkill(Skills.アシスト)
                .AddLearnableSkill(Skills.スポイル);
            public static Monster ティディ = new Monster(name: "ティディ");
            public static Monster RABI = new Monster(name: "R・A・B・I")
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.魅了凝視);

            public static Monster カモフック = new Monster(name: "カモフック")
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.フェロモン)
                .AddLearnableSkill(Skills.ブーメランフック);
            public static Monster カモキング = new Monster(name: "カモキング")
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.強酸)
                .AddLearnableSkill(Skills.ぽんぽこ);

            public static Monster ドラゴンミニー = new Monster(name: "ドラゴンミニー")
                .AddLearnableSkill(Skills.牙)
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.電撃)
                .AddLearnableSkill(Skills.放射電撃);
            public static Monster ソニックバット = new Monster(name: "ソニックバット")
                .AddLearnableSkill(Skills.超音波)
                .AddLearnableSkill(Skills.スクリーム)
                .AddLearnableSkill(Skills.毒撃)
                .AddLearnableSkill(Skills.グライダースパイク);
            public static Monster グリフォン小 = new Monster(name: "グリフォン（小）")
                .AddLearnableSkill(Skills.クチバシ)
                .AddLearnableSkill(Skills.強風)
                .AddLearnableSkill(Skills.グライダースパイク)
                .AddLearnableSkill(Skills.グリフィススクラッチ);

            public static Monster ファイアクリスタル = new Monster(name: "ファイアクリスタル")
                .AddLearnableSkill(Skills.パラリシスタッチ)
                .AddLearnableSkill(Skills.ライトボール)
                .AddLearnableSkill(Skills.振動波)
                .AddLearnableSkill(Skills.ヒートスマッシュ);
            public static Monster フレイム = new Monster(name: "フレイム")
                .AddLearnableSkill(Skills.ヒートスマッシュ)
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.イグニスストリーム)
                .AddLearnableSkill(Skills.高温ガス);
            public static Monster ウォーター = new Monster(name: "ウォーター")
                .AddLearnableSkill(Skills.水撃)
                .AddLearnableSkill(Skills.触手)
                .AddLearnableSkill(Skills.冷気)
                .AddLearnableSkill(Skills.生命の雨);
            public static Monster スライム大 = new Monster(name: "スライム大")
                .AddLearnableSkill(Skills.溶解液)
                .AddLearnableSkill(Skills.スポイル)
                .AddLearnableSkill(Skills.毒液);
            public static Monster スライム特大 = new Monster(name: "スライム特大")
                .AddLearnableSkill(Skills.溶解液)
                .AddLearnableSkill(Skills.スポイル)
                .AddLearnableSkill(Skills.毒液);

            public static Monster ピンクショック = new Monster(name: "ピンクショック")
                .AddLearnableSkill(Skills.キック)
                .AddLearnableSkill(Skills.毛繕い);
            public static Monster ヴァルキリー剣 = new Monster(name: "ヴァルキリー（剣）")
                .AddLearnableSkill(Skills.魅了凝視)
                .AddLearnableSkill(Skills.ライトボール)
                .AddLearnableSkill(Skills.グライダースパイク)
                .AddLearnableSkill(Skills.強風);
            public static Monster タイタニア = new Monster(name: "タイタニア")
                .AddLearnableSkill(Skills.吸血);
            public static Monster アンシリーコート = new Monster(name: "アンシリーコート")
                .AddLearnableSkill(Skills.サッドソング)
                .AddLearnableSkill(Skills.炎のくちづけ)
                .AddLearnableSkill(Skills.ライトボール)
                .AddLearnableSkill(Skills.毒霧);

            public static Monster ルナティックハイ = new Monster(name: "ルナティックハイ")
                .AddLearnableSkill(Skills.尾撃)
                .AddLearnableSkill(Skills.グライダースパイク);
            public static Monster マリーチ = new Monster(name: "マリーチ");

            public static Monster オーガ = new Monster(name: "オーガ")
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.ダブルアクス)
                .AddLearnableSkill(Skills.グランドヒット);
            public static Monster イエティ = new Monster(name: "イエティ")
                .AddLearnableSkill(Skills.ダブルアクス)
                .AddLearnableSkill(Skills.ぽんぽこ)
                .AddLearnableSkill(Skills.岩石)
                .AddLearnableSkill(Skills.強打);
            public static Monster オーガロード = new Monster(name: "オーガロード")
                .AddLearnableSkill(Skills.突進)
                .AddLearnableSkill(Skills.ふみつけ)
                .AddLearnableSkill(Skills.落雷)
                .AddLearnableSkill(Skills.タイタスウェイヴ);
            public static Monster ミノタウロス = new Monster(name: "ミノタウロス")
                .AddLearnableSkill(Skills.ダブルアクス)
                .AddLearnableSkill(Skills.地響き)
                .AddLearnableSkill(Skills.怒りの鉄拳)
                .AddLearnableSkill(Skills.強打);
            public static Monster バフォメット = new Monster(name: "バフォメット")
                .AddLearnableSkill(Skills.角)
                .AddLearnableSkill(Skills.ふみつけ)
                .AddLearnableSkill(Skills.フェロモン)
                .AddLearnableSkill(Skills.死の凝視);

            public static Monster 赤竜 = new Monster(name: "赤竜")
                .AddLearnableSkill(Skills.爪)
                .AddLearnableSkill(Skills.ファングクラッシュ)
                .AddLearnableSkill(Skills.火炎)
                .AddLearnableSkill(Skills.放射火炎);
            public static Monster 雷竜 = new Monster(name: "雷竜")
                .AddLearnableSkill(Skills.翼)
                .AddLearnableSkill(Skills.落雷)
                .AddLearnableSkill(Skills.電撃)
                .AddLearnableSkill(Skills.放射電撃);
            public static Monster 黒竜 = new Monster(name: "黒竜")
                .AddLearnableSkill(Skills.ファングクラッシュ)
                .AddLearnableSkill(Skills.石化ガス)
                .AddLearnableSkill(Skills.タイタスウェイヴ)
                .AddLearnableSkill(Skills.グリフィススクラッチ);
        }
    }
}