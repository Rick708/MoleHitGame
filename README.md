## アプリ名
##### MoleHitGame

## 開発環境
unity (バージョン:2018.4.3f1)  
C#

## ゲーム内容
モグラ叩きゲーム!!  
モグラ１匹につき１点もらえて４秒間に出てきたモグラをタップして点数を稼ぐゲームとなります。  
最高点数目指して頑張りましょう♪

## 概要
Title,Game,Historyの3つのSceneを作成
- Titleでは、StartButtonとHistoryButtonを置き、よりゲーム性を意識するためにテキストも表示しました。
- Gameでは、MolePrefabを場所指定して生成させました。また、一時停止も可能です。
- Historyでは、Gameの成績と時間をで持ち運びclassに入れてから保存して表示しております。
- また、SEやBGMを流し、TapActionとしてEffectも搭載させました。

## 工夫点
1. 各シーンに文字を表示させてよりゲームらしく見せました。
1. タップ時にSEだけでなくエフェクトも発生させて演出を増やしました。
1. Game中の一時停止を分かりやすいデザインを意識しました。

## 苦労点
##### GetComponent
Railsを学んでいましたが、まず最初にGetComponentという壁に当たりました。
ファイルに記載したデータをどうやって別のファイルに持っていくのかを悩みました。

##### 残り時間の表示
残り時間を表示した際にフレーム依存の時間経過になっており時間早かったり、アップデート内に入れていないが為に
時間が進まなかったりと苦戦しました。

##### 履歴＆ランキング表示（1番の苦労点）
時間と点数を表示する際にデータをPlayerPrefsを使いましたが、データをうまく扱うことができずにいました。
結果としては、Classを作りデータを持ち運びそして表示しました。

## 課題や今後について
##### シンプルなコードとファイル管理
設計を大きく見誤っており不足な部分が大きくなってしまいました。
その為に、処理をどのScriptに記載するか、SE,BGMファイルを一緒に出来なかったのか等
可視化という部分を追求できていなかった。
##### 追加してみたい技術
現状プレイヤー間の点数を差別化できていない(誰でも満点取れる)のでハズレprefadやinstansのタイミングを拘りたい

## Play動画
![Molegif](https://user-images.githubusercontent.com/56381794/79887796-6a9d1000-8436-11ea-9a2d-1544a9a83389.gif)

## その他画像
#### タイトル,履歴表示＆ランキング表示

<img width="200" height="200" alt="スクリーンショット 2020-04-21 20 25 00" src="https://user-images.githubusercontent.com/56381794/79883203-97e5c000-842e-11ea-9445-a5bdc8f2a08e.png"><img width="200" height="200" alt="スクリーンショット 2020-04-21 20 25 15" src="https://user-images.githubusercontent.com/56381794/79962266-cdd48400-84c2-11ea-88c7-6e37ad4d986f.png"><img width="200" height="200" alt="スクリーンショット 2020-04-21 21 03 21" src="https://user-images.githubusercontent.com/56381794/79883509-f612a300-842e-11ea-9f98-54d6b85d65b3.png"><img width="200" height="200" alt="スクリーンショット 2020-04-21 21 03 26" src="https://user-images.githubusercontent.com/56381794/79883519-f9a62a00-842e-11ea-9d1b-bfb5f75297ba.png">
