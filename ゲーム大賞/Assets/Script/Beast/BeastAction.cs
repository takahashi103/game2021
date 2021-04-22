using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastAction : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Move PlayerAction;





    Rigidbody Brb;

    //GameObject Player; //Playerちゃんそのものが入る変数

    //Move script; //Moveが入る変数

    //Start is called before the first frame update
    void Start()
    {
        PlayerAction = Player.GetComponent<Move>();

        Brb = PlayerAction.rb;


    }
 
    void Update()
    {
        if (PlayerAction.isFloor)
        {
            if (Input.GetKeyDown("space"))
            {
                Vector3 force = new Vector3(0.0f, 8.0f, 0.0f);  // 力を設定
                PlayerAction.rb.AddForce(force, ForceMode.Impulse);          // 力を加える
                Debug.Log("跳んだ!");
            }
        }
    }
}