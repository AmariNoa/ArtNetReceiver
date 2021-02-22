# ArtNetReceiver
Unity内でArtNetでデータを簡易に受信と録画するためのプロジェクト

## Operation Check
qlc+, TouchDesignerでの動作確認は行いました

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
        //ここにデータ受信時のプログラムを書く
        data.Logger(); //Log出力用関数 
    }
}
```

## Recorder

ArtNetDataRecorderをアタッチし、Clientと保存するPATH(Asset直下ならAssets/SampleAnimationClip.asset). Unityを再生し、録画開始は`R`、録画終了は`S`でできます

License
-------

[MIT](LICENSE.md)ですがコメントくれたら作者は喜びます(*'ω'*)
