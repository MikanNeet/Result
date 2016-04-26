using UnityEngine;
using System.Collections;

public class Result_Manager : MonoBehaviour {


    public GameObject block;
    public GameObject shooting;
    public GameObject typing;


	// Use this for initialization
	void Start () {
        if (GameObject.Find("DeriverPoint").GetComponent<B_StageNum>().game_name == "block")
        {
            Instantiate(block, block.transform.position, block.transform.rotation);
        }
        else if (GameObject.Find("DeriverPoint").GetComponent<B_StageNum>().game_name == "Kirie_Shooting")
        {
            Instantiate(shooting, shooting.transform.position, shooting.transform.rotation);
        }
        else if (GameObject.Find("DeriverPoint").GetComponent<B_StageNum>().game_name == "typing")
        {
            Instantiate(typing, typing.transform.position, typing.transform.rotation);
        }
    }
	
}
