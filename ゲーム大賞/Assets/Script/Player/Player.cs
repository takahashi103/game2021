using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject human;
    public GameObject animal;
    public GameObject plant;

    public float cool;

    bool Hflag;
    bool Aflag;
    bool Pflag;

    private int DeathCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        Hflag = false;
        Aflag = false;
        Pflag = true;

        this.human.SetActive(Hflag);
        this.animal.SetActive(Aflag);
        this.plant.SetActive(Pflag);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("やつは死んだ");
            PlayerDeath();
        }

        //Qキーを押す
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerReincarnation();
        }

        this.human.SetActive(Hflag);//人無し
        this.animal.SetActive(Aflag);//動物有り
        this.plant.SetActive(Pflag);//植物有り
    }

    //転生処理＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
    void PlayerReincarnation()
    {
        Debug.Log("生き返った");

        if (Hflag == true)
        {
            Hflag = false;
            Aflag = true;
        }
        else if (Aflag == true)
        {
            Aflag = false;
            Pflag = true;
        }
        else if (Pflag == true)
        {
            Pflag = false;
            Hflag = true;
        }

        DeathCount += 1;
    }
    //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    //死んだ処理＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
    void PlayerDeath()
    {
        Debug.Log("転生しろ");
        PlayerReincarnation();
    }
    //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    public int GetDeathCount()
    {
        return DeathCount;
    }

}
