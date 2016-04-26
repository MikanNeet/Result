using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Result_Text : MonoBehaviour {

    public Text[] text = new Text[4];
    public Text text_all;
    public Text umr;
    GameObject point;
    GameObject money;

    bool move;
    // Use this for initialization
    void Start () {
        point = GameObject.Find("DeriverPoint");
        money = GameObject.Find("money");
    }

    // Update is called once per frame
    void Update()
    {
        //まだまとめられるけどとりあえず全体のステージ数増えるかもしんないからこのまんま
        //シルフィン
        if (point.GetComponent<B_StageNum>().game_name == "block")
        {
            text[0].text = "1st:" + point.GetComponent<B_StageNum>().score[0];
            text[1].text = "2nd:" + point.GetComponent<B_StageNum>().score[1];
            text[2].text = "3rd:" + point.GetComponent<B_StageNum>().score[2];
            text_all.text = "Total:" + point.GetComponent<B_StageNum>().since_score_;
            umr.text = "Money:" + money.GetComponent<Umr_Coin>().getMoney();
            if (!move && Input.GetMouseButtonDown(0))
            {
                move = true;
                point.GetComponent<B_StageNum>().Dec(point.GetComponent<B_StageNum>().since_score_);
                money.GetComponent<Umr_Coin>().Inc(point.GetComponent<B_StageNum>().since_score_ + 1);
            }
            else if (move && Input.GetMouseButtonDown(0))
            {
                point.GetComponent<B_StageNum>().Death();
                Application.LoadLevel("Block_Menu");
            }
        }
        //きりえ
        else if (point.GetComponent<B_StageNum>().game_name == "Kirie_Shooting")
        {
            text[0].text = "1st:" + point.GetComponent<B_StageNum>().score[0];
            text[1].text = "2nd:" + point.GetComponent<B_StageNum>().score[1];
            text[2].text = "3rd:" + point.GetComponent<B_StageNum>().score[2];
            text[3].text = "4th:" + point.GetComponent<B_StageNum>().score[3];
            text_all.text = "Total:" + point.GetComponent<B_StageNum>().since_score_;
            umr.text = "Money:" + money.GetComponent<Umr_Coin>().getMoney();

            if (!move && Input.GetMouseButtonDown(0))
            {
                move = true;
                point.GetComponent<B_StageNum>().Dec(point.GetComponent<B_StageNum>().since_score_);
                money.GetComponent<Umr_Coin>().Inc(point.GetComponent<B_StageNum>().since_score_ + 1);
            }
            else if (move && Input.GetMouseButtonDown(0))
            {
                point.GetComponent<B_StageNum>().Death();
                //Application.LoadLevel("Block_Menu");
            }
        }
        //海老菜
        else if (point.GetComponent<B_StageNum>().game_name == "typing")
        {
            text[0].text = "1st:" + point.GetComponent<B_StageNum>().score[0];
            text[1].text = "2nd:" + point.GetComponent<B_StageNum>().score[1];
            text[2].text = "3rd:" + point.GetComponent<B_StageNum>().score[2];
            text[3].text = "4th:" + point.GetComponent<B_StageNum>().score[3];
            text_all.text = "Total:" + point.GetComponent<B_StageNum>().since_score_;
            umr.text = "Money:" + money.GetComponent<Umr_Coin>().getMoney();
            if (!move && Input.GetMouseButtonDown(0))
            {
                move = true;
                point.GetComponent<B_StageNum>().Dec(point.GetComponent<B_StageNum>().since_score_);
                money.GetComponent<Umr_Coin>().Inc(point.GetComponent<B_StageNum>().since_score_ + 1);
            }
            else if (move && Input.GetMouseButtonDown(0))
            {
                point.GetComponent<B_StageNum>().Death();
                Application.LoadLevel("Main");
            }
        }
    }
}
