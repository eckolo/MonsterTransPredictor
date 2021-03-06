﻿using MonsterTransPredictor.Models.Application.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Infrastructure.Service
{
    public partial class DbInitializer
    {
        public static void Initialize(Mtp context)
        {
            //データ全削除前に自動採番インデックスを初期化
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Monsters', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Skills', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('TransTerms', RESEED, 0);");

            //初期化前にデータを全削除
            context.monsters.RemoveRange(context.monsters.ToList());
            context.skills.RemoveRange(context.skills.ToList());
            context.transTerms.RemoveRange(context.transTerms.ToList());

            //データ投入
            context.skills.AddRange(new List<Skill> {
                Skills.ハサミ,
                Skills.スミ,
                Skills.体当たり,
                Skills.牙,
                Skills.ファングクラッシュ,
                Skills.クチバシ,
                Skills.角,
                Skills.マヒ凝視,
                Skills.魅了凝視,
                Skills.石化凝視,
                Skills.死の凝視,
                Skills.催眠,
                Skills.吸血,
                Skills.丸のみ,
                Skills.石化撃,
                Skills.ダガージョウ,
                Skills.ヴェイパーブラスト,
                Skills.バニッシュ,
                Skills.リバースグラビティ,
                Skills.ライトシフト,
                Skills.ダークシフト,
                Skills.ヴォーテクス,

                Skills.ダブルアクス,
                Skills.ブレインクラッシュ,
                Skills.打撃,
                Skills.ハサミ,
                Skills.強打,
                Skills.ねこだまし,
                Skills.サミング,
                Skills.触手,
                Skills.爪,
                Skills.毒撃,
                Skills.ゴーストタッチ,
                Skills.デスタッチ,
                Skills.パラリシスタッチ,
                Skills.ブレード,
                Skills.烈風撃,
                Skills.草薙の剣,
                Skills.怒りの鉄拳,
                Skills.グランドヒット,
                Skills.ヒートスマッシュ,
                Skills.アイススマッシュ,
                Skills.タイタスウェイヴ,
                Skills.突き,
                Skills.ブーメランフック,

                Skills.キック,
                Skills.ふみつけ,
                Skills.しっぽ,
                Skills.尾撃,
                Skills.足払い,
                Skills.スカッシュ,
                Skills.毒針,
                Skills.フェイント,
                Skills.百足蹂躙,
                Skills.グリフィススクラッチ,

                Skills.ミニオンストライク,
                Skills.毛繕い,
                Skills.まきつき,
                Skills.体当たり,
                Skills.突進,
                Skills.ぶちかまし,
                Skills.暴走,
                Skills.翼,
                Skills.グライダースパイク,
                Skills.振動波,
                Skills.炎のくちづけ,
                Skills.胞子,
                Skills.シードバルカン,
                Skills.溶解液,
                Skills.針,
                Skills.ファイアーバリア,
                Skills.フリーズバリア,
                Skills.サンダーバリア,
                Skills.カウンターフィアー,
                Skills.サイリフレクター,
                Skills.光合成,
                Skills.死の属性,

                Skills.高温ガス,
                Skills.火炎,
                Skills.放射火炎,
                Skills.冷気,
                Skills.電撃,
                Skills.放射電撃,
                Skills.スミ,
                Skills.水撃,
                Skills.悪臭,
                Skills.毒ガス,
                Skills.石化ガス,
                Skills.睡眠ガス,
                Skills.トリップガス,
                Skills.ビートルジュース,
                Skills.強酸,
                Skills.死人ゴケ,
                Skills.毒液,
                Skills.スフィンクスリドル,

                Skills.生気吸収,
                Skills.誘惑,
                Skills.フェロモン,
                Skills.閃光,
                Skills.スパイダーネット,
                Skills.ブレードネット,
                Skills.エクトプラズムネット,
                Skills.落雷,
                Skills.ペインパウダー,
                Skills.毒霧,
                Skills.イルストーム,
                Skills.強風,
                Skills.竜巻,
                Skills.聖歌,
                Skills.マジカルヒール,
                Skills.アシスト,
                Skills.スポイル,
                Skills.グレムリンタッチ,
                Skills.ヒートウェイヴ,
                Skills.マイティサイクロン,
                Skills.メイルシュトローム,
                Skills.エルフショット,
                Skills.超音波,
                Skills.ララバイ,
                Skills.スクリーム,
                Skills.サイレン,
                Skills.ぽんぽこ,
                Skills.ライトボール,
                Skills.地響き,
                Skills.地震,
                Skills.流砂,
                Skills.岩石,
                Skills.磁気嵐,
                Skills.バトルソング,
                Skills.サッドソング,
                Skills.シルフィード,
                Skills.イグニスストリーム,
                Skills.生命の雨,
                Skills.麒麟の歌,
            });
            context.monsters.AddRange(new List<Monster>
            {
                Monsters.ロッキー,
                Monsters.ヘッジホッグ,
                Monsters.バーゲスト,
                Monsters.モンキーライダー,
                Monsters.ヘルハウンド,
                Monsters.マンティコア,
                Monsters.ユニコーン,
                Monsters.ブッチ,
                Monsters.キマイラ,

                Monsters.プリクタス,
                Monsters.スポアパイル,
                Monsters.マンドレイク,
                Monsters.トラップバイン,
                Monsters.ナイトシェイド,
                Monsters.トレント,
                Monsters.サンフラワー,
                Monsters.シュリーカー,
                Monsters.化石樹,

                Monsters.フェイトード,
                Monsters.ガンフィッシュ,
                Monsters.ソルジャービル,
                Monsters.マフラーザウルス,
                Monsters.ガイアトード,
                Monsters.トリケプス,
                Monsters.玄武,
                Monsters.バジリスク,
                Monsters.クラーケン,

                Monsters.シェルワーム,
                Monsters.アームウォーカー,
                Monsters.キラービー,
                Monsters.デスポーカー,
                Monsters.グルームモス,
                Monsters.ラバーウォーム,
                Monsters.ゼニスマンティス,
                Monsters.コスモデバウアー,
                Monsters.ゼロディバイダー,

                Monsters.ピックバード,
                Monsters.ラバット,
                Monsters.ドラゴンパピー,
                Monsters.ハーピー,
                Monsters.アクスビーク,
                Monsters.ワイバーン,
                Monsters.コカトリス,
                Monsters.スフィンクス,
                Monsters.朱雀,

                Monsters.ゼノ,
                Monsters.スライム,
                Monsters.ウィップジェリー,
                Monsters.フューズクリスタル,
                Monsters.アンノウン,
                Monsters.リキッドメタル,
                Monsters.エアエレメンタル,
                Monsters.ゼラチナスプランター,
                Monsters.雪の精,

                Monsters.マッドアクス,
                Monsters.ワンダーランス,
                Monsters.ダガーグラブ,
                Monsters.リビングアーマー,
                Monsters.グリランドリー,
                Monsters.魔銃,
                Monsters.魔鏡,
                Monsters.ミミック,
                Monsters.ジブサムスカウト,

                Monsters.スパルトイ,
                Monsters.ゴースト,
                Monsters.ゾンビ,
                Monsters.ライダーゴースト,
                Monsters.ナイトスケルトン,
                Monsters.アンクヘッグ,
                Monsters.リッチ,
                Monsters.スカルサウルス,
                Monsters.デュラハン,

                Monsters.ワンダードギー,
                Monsters.ガーゴイル,
                Monsters.マンスネーク,
                Monsters.魚人,
                Monsters.エインヘリアル,
                Monsters.グレムリン,
                Monsters.ベクサーク,
                Monsters.サイバーサーカー,
                Monsters.ゼフォン,

                Monsters.スプライト,
                Monsters.オンディーヌ,
                Monsters.ピンクパンチ,
                Monsters.バンシー,
                Monsters.メロウ,
                Monsters.ヴァルキリー槍,
                Monsters.サキュバス,
                Monsters.ラミア,
                Monsters.サイレン,

                Monsters.ブロンズプリマ,
                Monsters.ロックバブーン,
                Monsters.マスカラプリマ,
                Monsters.エティン,
                Monsters.ゴートギガース,
                Monsters.アースゴーレム,
                Monsters.サイクロプス,
                Monsters.メタルチャリオット,
                Monsters.巨人,

                Monsters.ストレイシープ,
                Monsters.マスキャット,
                Monsters.ティディ,
                Monsters.RABI,

                Monsters.カモフック,
                Monsters.カモキング,

                Monsters.ドラゴンミニー,
                Monsters.ソニックバット,
                Monsters.グリフォン小,

                Monsters.ファイアクリスタル,
                Monsters.フレイム,
                Monsters.ウォーター,
                Monsters.スライム大,
                Monsters.スライム特大,

                Monsters.ピンクショック,
                Monsters.ヴァルキリー剣,
                Monsters.タイタニア,
                Monsters.アンシリーコート,

                Monsters.ルナティックハイ,
                Monsters.マリーチ,

                Monsters.オーガ,
                Monsters.イエティ,
                Monsters.オーガロード,
                Monsters.ミノタウロス,
                Monsters.バフォメット,

                Monsters.赤竜,
                Monsters.雷竜,
                Monsters.黒竜,
            });
            context.transTerms.AddRange(TransTerms.list);
            context.SaveChanges();
        }
    }
}