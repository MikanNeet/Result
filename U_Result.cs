using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/* 
UFOキャッチャーのみで使うやつ
    景品の結果を表示するクラスです。
*/

public class U_Result : MonoBehaviour {

    /* 定数一覧です。 */
    private const int NORMAL =      0;
    private const int RARE =        1;
    private const int SUPERRARE =   2;
    private const int ULTRARARE =   3;

    /* 景品獲得時のレア度をテキストで表示するオブジェクトです。(画像によっては必要ないかもしれません。) */
    public GameObject resultText;

    /* 景品獲得時の画像を表示するオブジェクトです。 */
    public GameObject resultImg;

    /* 景品獲得時の画像を格納する変数です。 */
    public Sprite normalImg;
    public Sprite rareImg;
    public Sprite superRareImg;
    public Sprite ultraRareImg;

    // Use this for initialization
    void Start () {

        int rareNum = 0;

        // 結果を表示する。
        showResultMsg(rareNum);
    }
	
	// Update is called once per frame
	void Update () {

        // スペースキーを押したなら
	    if (Input.GetKey(KeyCode.Space))
        {
            // シーン切り替え
            Debug.Log("シーンを切り替えます。");
            /* シーン先を記入する。 */

            /*                     */
        }
	}

    /* リザルト画面を表示します。 */
    void showResultMsg(int val)
    {
        if (resultImg == null)
        {
            Debug.Log("景品獲得時の画像を表示するオブジェクトを指定して下さい。");
            return;
        }

        if ((normalImg == null) || (rareImg == null) || (superRareImg == null) || (ultraRareImg == null))
        {
            Debug.Log("景品獲得時の画像を指定して下さい。");
            return;
        }

        switch (val)
        {
            case NORMAL:
                // ノーマル
                resultText.GetComponent<Text>().text = "ノーマルです。";
                resultImg.GetComponent<SpriteRenderer>().sprite = normalImg;
                break;
            case RARE:
                // レア
                resultText.GetComponent<Text>().text = "レアです。";
                resultImg.GetComponent<SpriteRenderer>().sprite = rareImg;
                break;
            case SUPERRARE:
                // スーパーレア
                resultText.GetComponent<Text>().text = "スーパーレアです。";
                resultImg.GetComponent<SpriteRenderer>().sprite = superRareImg;
                break;
            case ULTRARARE:
                // ウルトラレア
                resultText.GetComponent<Text>().text = "ウルトラレアです。";
                resultImg.GetComponent<SpriteRenderer>().sprite = ultraRareImg;
                break;
        }
    }
}
