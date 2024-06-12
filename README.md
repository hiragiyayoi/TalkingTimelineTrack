# 字幕操作用カスタムトラック

## 概要
UnityのTimelineで任意の字幕を操作するためののノベルゲーム向けのカスタムトラックです。

Unityのノベルゲーム向けのカスタムトラックのライブラリを制作予定です。本プロジェクトは「にじさんじ格闘ゲーム制作プロジェクト」向けに制作したトラックをノベルゲーム向けに公開しています。

## 特徴
- 左右に１人ずつのキャラに対していずれの字幕（セリフ）を制御するかを選択可能
- リッチテキストによる字幕の装飾可能
- キャラごとにトラックを作成する。
- セリフごとにキャラ名の変更が可能

## 実装例
[![](https://img.youtube.com/vi/qewiuaeSpf0/0.jpg)](https://www.youtube.com/watch?v=qewiuaeSpf0)


## セットアップ
### 要件
- TextMeshProがインストールされている。

### インストール
1. [Releases](https://github.com/hiragiyayoi/TalkingTimelineTrack/releases)より最新のUnityPackagesをダウンロードする．
2. Asset > Import Pakages > Custom Pakege より1のパッケージをインポートする．
4. UnityEditorを再起動する．
5. AssetフォルダにYalkingTrackフォルダが生成されていることを確認する．


## 使い方
Menu.Runtime.TalkingTrack > Talking Text Track が該当のトラックです。

![image](https://github.com/hiragiyayoi/TalkingTimelineTrack/assets/84854644/47729f69-a736-4f49-9bc6-c48174403a11)

各トラックに以下の階層構造のGameObjectを選択する。また、canvasオブジェクト以下に配置されているものとする。

![image](https://github.com/hiragiyayoi/TalkingTimelineTrack/assets/84854644/e94c9d69-ccff-4633-b8b7-e8426decfba1)

![image](https://github.com/hiragiyayoi/TalkingTimelineTrack/assets/84854644/4a8a233f-1e08-4156-b3d6-ee5a418118b8)

### トラックについて
1キャラ1トラックを想定しています。
TrackのInspectorには以下の変数が存在します。

![image](https://github.com/hiragiyayoi/TalkingTimelineTrack/assets/84854644/ca372f28-bafe-4845-afb3-9f1e5f04852e)

- Default Name Text：該当トラックで制御するキャラの名前を入力する。入力しないことでキャラ以外の字幕で使用できる。
- name Position：Left、Rightのいずれの位置でキャラ名を表示するか選択する。
- Clip Num：トラックに配置されているクリップの個数を表示する。
＊クリップ削除時に手動で変更する必要がある。



### クリップについて
ClipのInspectorには以下の変数が存在します。(一部変数は現在使用していません)

![image](https://github.com/hiragiyayoi/TalkingTimelineTrack/assets/84854644/aca753c0-c181-44b4-b0ae-1199706491b5)

- Text Appeearance Interval：文字をタイプライター風に表示します。表示する最大文字数を増やすフレームの間隔を指定します。
例：3の場合、3フレームに１回最大表示文字数が増加する。0の場合にはクリップ再生直後に指定したすべてのテキストを表示する。
- Name Text：Trackで指定しているキャラ名をクリップ再生時にのみ一時的に上書きする。
- Conversation Content：字幕で表示する文字を入力します。表示する文字は[リッチテキスト](https://docs.unity3d.com/ja/2022.3/Manual/StyledText.html)を使用することで装飾できます。

＊これ以外の変数は現在使用していません。

## 注意点
- クリップを削除するときはTrackのClip Numを変更する必要がある。
- プレビュー再生時にクリップを削除すると字幕が切り替わらないことがある。（ランタイムでは問題なし）

