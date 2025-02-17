![Unity version](https://img.shields.io/badge/Unity-2020.3.16f1-blue.svg)

# Project details
forked from Taku3939/ArtNetReceiver

## Changes from the forked project

・Unityのバージョンをアップグレードしました (2020.3.6f1から2020.3.16f1へ)

・自身のプロジェクトへ流用するためのコード改変




## -=+=--=+=- 以下フォーク元プロジェクトのりどみ -=+=--=+=-
# ArtNetReceiver
Unity内でArtNetでデータを簡易に受信と録画するためのプロジェクト

## Operation Check
qlc+, TouchDesigner, DasLight4での動作確認は行いました

## Usage

ArtNetClientを任意なオブジェクトにアタッチし、Portを設定する（デフォルトで6454）.


以下のようなコードを書く

```C# : データ受信のサンプルコード
public class Sample : MonoBehaviour
{
    [SerializeField] private ArtNetClient artNetClient;
    private void Start()
    {
        artNetClient.onDataReceived += EventHandler;
    }

    private void EventHandler(ArtNetData data)
    {
         if (data.OpCode == ArtNetOpCode.OpDmx)
         {
        	// ここにデータ受信時のプログラムを書く
	        data.Logger(); //Log出力用関数 
         }
    }
}
```

## Recorder

ArtNetDataRecorderにパスを設定して, Unityを再生する。

録画開始は`R`、録画終了は`S`でできます。

License
-------

[MIT](LICENSE.md)ですがコメントくれたら作者は喜びます(*'ω'*)
