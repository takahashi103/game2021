using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimibox_UI : MonoBehaviour
{
    public Texture texture;
    public Texture texture2;

    bool texSwitch;

    // Start is called before the first frame update
    void Start()
    {
        texSwitch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (texSwitch)
        {
            afterGimmickUI();
        }
        else if (!texSwitch)
        {
            beforeGimmickUI();
        }
    }

    public void afterGimmickUI()
    {
        
        GetComponent<Renderer>().material.mainTexture = texture2;
        GetComponent<Renderer>().material.color = Color.white;
        texSwitch = true;

        //Debug.Log("ボックスUI出てるよ");
    }

    public void beforeGimmickUI()
    {
        
        GetComponent<Renderer>().material.mainTexture = texture;
        GetComponent<Renderer>().material.color = Color.white;
        texSwitch = false;

        //Debug.Log("ボックスUI出てないよ");
    }
}
